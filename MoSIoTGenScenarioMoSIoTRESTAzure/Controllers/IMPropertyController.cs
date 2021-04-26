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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMPropertyControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMProperty")]
public class IMPropertyController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMProperty/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMPropertyRESTCAD iMPropertyRESTCAD = null;
        IMPropertyCEN iMPropertyCEN = null;

        List<IMPropertyEN> iMPropertyEN = null;
        List<IMPropertyDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMPropertyRESTCAD = new IMPropertyRESTCAD (session);
                iMPropertyCEN = new IMPropertyCEN (iMPropertyRESTCAD);

                // Data
                // TODO: paginación

                iMPropertyEN = iMPropertyCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMPropertyEN != null) {
                        returnValue = new List<IMPropertyDTOA>();
                        foreach (IMPropertyEN entry in iMPropertyEN)
                                returnValue.Add (IMPropertyAssembler.Convert (entry, session));
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
// [Route("{idIMProperty}", Name="GetOIDIMProperty")]

[Route ("~/api/IMProperty/{idIMProperty}")]

public HttpResponseMessage ReadOID (int idIMProperty)
{
        // CAD, CEN, EN, returnValue
        IMPropertyRESTCAD iMPropertyRESTCAD = null;
        IMPropertyCEN iMPropertyCEN = null;
        IMPropertyEN iMPropertyEN = null;
        IMPropertyDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMPropertyRESTCAD = new IMPropertyRESTCAD (session);
                iMPropertyCEN = new IMPropertyCEN (iMPropertyRESTCAD);

                // Data
                iMPropertyEN = iMPropertyCEN.ReadOID (idIMProperty);

                // Convert return
                if (iMPropertyEN != null) {
                        returnValue = IMPropertyAssembler.Convert (iMPropertyEN, session);
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


[Route ("~/api/IMProperty/New_")]




public HttpResponseMessage New_ ( [FromBody] IMPropertyDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMPropertyRESTCAD iMPropertyRESTCAD = null;
        IMPropertyCEN iMPropertyCEN = null;
        IMPropertyDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMPropertyRESTCAD = new IMPropertyRESTCAD (session);
                iMPropertyCEN = new IMPropertyCEN (iMPropertyRESTCAD);

                // Create
                returnOID = iMPropertyCEN.New_ (
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
                        //Atributo OID: p_property
                        // attr.estaRelacionado: true
                        dto.Property_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMPropertyAssembler.Convert (iMPropertyRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMProperty", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMProperty/Modify")]

public HttpResponseMessage Modify (int idIMProperty, [FromBody] IMPropertyDTO dto)
{
        // CAD, CEN, returnValue
        IMPropertyRESTCAD iMPropertyRESTCAD = null;
        IMPropertyCEN iMPropertyCEN = null;
        IMPropertyDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMPropertyRESTCAD = new IMPropertyRESTCAD (session);
                iMPropertyCEN = new IMPropertyCEN (iMPropertyRESTCAD);

                // Modify
                iMPropertyCEN.Modify (idIMProperty,
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
                returnValue = IMPropertyAssembler.Convert (iMPropertyRESTCAD.ReadOIDDefault (idIMProperty), session);

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


[Route ("~/api/IMProperty/Destroy")]

public HttpResponseMessage Destroy (int p_improperty_oid)
{
        // CAD, CEN
        IMPropertyRESTCAD iMPropertyRESTCAD = null;
        IMPropertyCEN iMPropertyCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMPropertyRESTCAD = new IMPropertyRESTCAD (session);
                iMPropertyCEN = new IMPropertyCEN (iMPropertyRESTCAD);

                iMPropertyCEN.Destroy (p_improperty_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMPropertyControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
