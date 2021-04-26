using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTOA;
using MoSIoTGenScenarioMoSIoTRESTAzure.CAD;
using MoSIoTGenScenarioMoSIoTRESTAzure.Assemblers;
using MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CP.MosIoT;


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMConditionControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMCondition")]
public class IMConditionController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMCondition/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMConditionRESTCAD iMConditionRESTCAD = null;
        IMConditionCEN iMConditionCEN = null;

        List<IMConditionEN> iMConditionEN = null;
        List<IMConditionDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMConditionRESTCAD = new IMConditionRESTCAD (session);
                iMConditionCEN = new IMConditionCEN (iMConditionRESTCAD);

                // Data
                // TODO: paginación

                iMConditionEN = iMConditionCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMConditionEN != null) {
                        returnValue = new List<IMConditionDTOA>();
                        foreach (IMConditionEN entry in iMConditionEN)
                                returnValue.Add (IMConditionAssembler.Convert (entry, session));
                }
        }

        catch (Exception e)
        {
                if (e.GetType () == typeof(HttpResponseException)) throw e;
                else if (e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) throw new HttpResponseException (HttpStatusCode.Forbidden);
                else if (e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.ModelException) || e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.DataLayerException)) throw new HttpResponseException (HttpStatusCode.BadRequest);
                else throw new HttpResponseException (HttpStatusCode.InternalServerError);
        }
        finally
        {
                SessionClose ();
        }

        // Return 204 - Empty
        if (returnValue == null || returnValue.Count == 0)
                return this.Request.CreateResponse (HttpStatusCode.NoContent);
        // Return 200 - OK
        else return this.Request.CreateResponse (HttpStatusCode.OK, returnValue);
}









[HttpGet]
// [Route("{idIMCondition}", Name="GetOIDIMCondition")]

[Route ("~/api/IMCondition/{idIMCondition}")]

public HttpResponseMessage ReadOID (int idIMCondition)
{
        // CAD, CEN, EN, returnValue
        IMConditionRESTCAD iMConditionRESTCAD = null;
        IMConditionCEN iMConditionCEN = null;
        IMConditionEN iMConditionEN = null;
        IMConditionDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMConditionRESTCAD = new IMConditionRESTCAD (session);
                iMConditionCEN = new IMConditionCEN (iMConditionRESTCAD);

                // Data
                iMConditionEN = iMConditionCEN.ReadOID (idIMCondition);

                // Convert return
                if (iMConditionEN != null) {
                        returnValue = IMConditionAssembler.Convert (iMConditionEN, session);
                }
        }

        catch (Exception e)
        {
                if (e.GetType () == typeof(HttpResponseException)) throw e;
                else if (e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) throw new HttpResponseException (HttpStatusCode.Forbidden);
                else if (e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.ModelException) || e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.DataLayerException)) throw new HttpResponseException (HttpStatusCode.BadRequest);
                else throw new HttpResponseException (HttpStatusCode.InternalServerError);
        }
        finally
        {
                SessionClose ();
        }

        // Return 404 - Not found
        if (returnValue == null)
                return this.Request.CreateResponse (HttpStatusCode.NotFound);
        // Return 200 - OK
        else return this.Request.CreateResponse (HttpStatusCode.OK, returnValue);
}




[HttpPost]


[Route ("~/api/IMCondition/New_")]




public HttpResponseMessage New_ ( [FromBody] IMConditionDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMConditionRESTCAD iMConditionRESTCAD = null;
        IMConditionCEN iMConditionCEN = null;
        IMConditionDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMConditionRESTCAD = new IMConditionRESTCAD (session);
                iMConditionCEN = new IMConditionCEN (iMConditionRESTCAD);

                // Create
                returnOID = iMConditionCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Type                                                                                                                                                       //Atributo Primitivo: p_type
                        , dto.IsOID                                                                                                                                                      //Atributo Primitivo: p_isOID
                        , dto.IsWritable                                                                                                                                                 //Atributo Primitivo: p_isWritable
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_entity
                        // attr.estaRelacionado: true
                        dto.Entity_oid                 // association role

                        , dto.Value                                                                                                                                                      //Atributo Primitivo: p_value
                        ,
                        //Atributo OID: p_condition
                        // attr.estaRelacionado: true
                        dto.Condition_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMConditionAssembler.Convert (iMConditionRESTCAD.ReadOIDDefault (returnOID), session);
        }

        catch (Exception e)
        {
                SessionRollBack ();

                if (e.GetType () == typeof(HttpResponseException)) throw e;
                else if (e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) throw new HttpResponseException (HttpStatusCode.Forbidden);
                else if (e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.ModelException) || e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.DataLayerException)) throw new HttpResponseException (HttpStatusCode.BadRequest);
                else throw new HttpResponseException (HttpStatusCode.InternalServerError);
        }
        finally
        {
                SessionClose ();
        }

        // Return 201 - Created
        response = this.Request.CreateResponse (HttpStatusCode.Created, returnValue);

        // Location Header
        /*
         * Dictionary<string, object> routeValues = new Dictionary<string, object>();
         *
         * // TODO: y rolPaths
         * routeValues.Add("id", returnOID);
         *
         * uri = Url.Link("GetOIDIMCondition", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMCondition/Modify")]

public HttpResponseMessage Modify (int idIMCondition, [FromBody] IMConditionDTO dto)
{
        // CAD, CEN, returnValue
        IMConditionRESTCAD iMConditionRESTCAD = null;
        IMConditionCEN iMConditionCEN = null;
        IMConditionDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMConditionRESTCAD = new IMConditionRESTCAD (session);
                iMConditionCEN = new IMConditionCEN (iMConditionRESTCAD);

                // Modify
                iMConditionCEN.Modify (idIMCondition,
                        dto.Name
                        ,
                        dto.Type
                        ,
                        dto.IsOID
                        ,
                        dto.IsWritable
                        ,
                        dto.Description
                        ,
                        dto.Value
                        );

                // Return modified object
                returnValue = IMConditionAssembler.Convert (iMConditionRESTCAD.ReadOIDDefault (idIMCondition), session);

                SessionCommit ();
        }

        catch (Exception e)
        {
                SessionRollBack ();

                if (e.GetType () == typeof(HttpResponseException)) throw e;
                else if (e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) throw new HttpResponseException (HttpStatusCode.Forbidden);
                else if (e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.ModelException) || e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.DataLayerException)) throw new HttpResponseException (HttpStatusCode.BadRequest);
                else throw new HttpResponseException (HttpStatusCode.InternalServerError);
        }
        finally
        {
                SessionClose ();
        }

        // Return 404 - Not found
        if (returnValue == null)
                return this.Request.CreateResponse (HttpStatusCode.NotFound);
        // Return 200 - OK
        else{
                response = this.Request.CreateResponse (HttpStatusCode.OK, returnValue);

                return response;
        }
}





[HttpDelete]


[Route ("~/api/IMCondition/Destroy")]

public HttpResponseMessage Destroy (int p_imcondition_oid)
{
        // CAD, CEN
        IMConditionRESTCAD iMConditionRESTCAD = null;
        IMConditionCEN iMConditionCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMConditionRESTCAD = new IMConditionRESTCAD (session);
                iMConditionCEN = new IMConditionCEN (iMConditionRESTCAD);

                iMConditionCEN.Destroy (p_imcondition_oid);
                SessionCommit ();
        }

        catch (Exception e)
        {
                SessionRollBack ();

                if (e.GetType () == typeof(HttpResponseException)) throw e;
                else if (e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) throw new HttpResponseException (HttpStatusCode.Forbidden);
                else if (e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.ModelException) || e.GetType () == typeof(MoSIoTGenNHibernate.Exceptions.DataLayerException)) throw new HttpResponseException (HttpStatusCode.BadRequest);
                else throw new HttpResponseException (HttpStatusCode.InternalServerError);
        }
        finally
        {
                SessionClose ();
        }

        // Return 204 - No Content
        return this.Request.CreateResponse (HttpStatusCode.NoContent);
}









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMConditionControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
