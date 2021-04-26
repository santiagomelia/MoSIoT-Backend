using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MoSIoTGenMosIoTRESTAzure.DTO;
using MoSIoTGenMosIoTRESTAzure.DTOA;
using MoSIoTGenMosIoTRESTAzure.CAD;
using MoSIoTGenMosIoTRESTAzure.Assemblers;
using MoSIoTGenMosIoTRESTAzure.AssemblersDTO;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CP.MosIoT;


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_ConditionControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Condition")]
public class ConditionController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Condition/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        ConditionRESTCAD conditionRESTCAD = null;
        ConditionCEN conditionCEN = null;

        List<ConditionEN> conditionEN = null;
        List<ConditionDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                conditionRESTCAD = new ConditionRESTCAD (session);
                conditionCEN = new ConditionCEN (conditionRESTCAD);

                // Data
                // TODO: paginación

                conditionEN = conditionCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (conditionEN != null) {
                        returnValue = new List<ConditionDTOA>();
                        foreach (ConditionEN entry in conditionEN)
                                returnValue.Add (ConditionAssembler.Convert (entry, session));
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
// [Route("{idCondition}", Name="GetOIDCondition")]

[Route ("~/api/Condition/{idCondition}")]

public HttpResponseMessage ReadOID (int idCondition)
{
        // CAD, CEN, EN, returnValue
        ConditionRESTCAD conditionRESTCAD = null;
        ConditionCEN conditionCEN = null;
        ConditionEN conditionEN = null;
        ConditionDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                conditionRESTCAD = new ConditionRESTCAD (session);
                conditionCEN = new ConditionCEN (conditionRESTCAD);

                // Data
                conditionEN = conditionCEN.ReadOID (idCondition);

                // Convert return
                if (conditionEN != null) {
                        returnValue = ConditionAssembler.Convert (conditionEN, session);
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


[Route ("~/api/Condition/New_")]




public HttpResponseMessage New_ ( [FromBody] ConditionDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        ConditionRESTCAD conditionRESTCAD = null;
        ConditionCEN conditionCEN = null;
        ConditionDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                conditionRESTCAD = new ConditionRESTCAD (session);
                conditionCEN = new ConditionCEN (conditionRESTCAD);

                // Create
                returnOID = conditionCEN.New_ (

                        //Atributo OID: p_patientProfile
                        // attr.estaRelacionado: true
                        dto.PatientProfile_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        , dto.ClinicalStatus                                                                                                                                                     //Atributo Primitivo: p_clinicalStatus
                        , dto.Disease                                                                                                                                                    //Atributo Primitivo: p_disease
                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        );
                SessionCommit ();

                // Convert return
                returnValue = ConditionAssembler.Convert (conditionRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDCondition", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Condition/Modify")]

public HttpResponseMessage Modify (int idCondition, [FromBody] ConditionDTO dto)
{
        // CAD, CEN, returnValue
        ConditionRESTCAD conditionRESTCAD = null;
        ConditionCEN conditionCEN = null;
        ConditionDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                conditionRESTCAD = new ConditionRESTCAD (session);
                conditionCEN = new ConditionCEN (conditionRESTCAD);

                // Modify
                conditionCEN.Modify (idCondition,
                        dto.Description
                        ,
                        dto.ClinicalStatus
                        ,
                        dto.Disease
                        ,
                        dto.Name
                        );

                // Return modified object
                returnValue = ConditionAssembler.Convert (conditionRESTCAD.ReadOIDDefault (idCondition), session);

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


[Route ("~/api/Condition/Destroy")]

public HttpResponseMessage Destroy (int p_condition_oid)
{
        // CAD, CEN
        ConditionRESTCAD conditionRESTCAD = null;
        ConditionCEN conditionCEN = null;

        try
        {
                SessionInitializeTransaction ();


                conditionRESTCAD = new ConditionRESTCAD (session);
                conditionCEN = new ConditionCEN (conditionRESTCAD);

                conditionCEN.Destroy (p_condition_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_ConditionControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
