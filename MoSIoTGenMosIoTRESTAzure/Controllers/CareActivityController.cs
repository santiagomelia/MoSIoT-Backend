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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_CareActivityControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/CareActivity")]
public class CareActivityController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/CareActivity/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        CareActivityRESTCAD careActivityRESTCAD = null;
        CareActivityCEN careActivityCEN = null;

        List<CareActivityEN> careActivityEN = null;
        List<CareActivityDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                careActivityRESTCAD = new CareActivityRESTCAD (session);
                careActivityCEN = new CareActivityCEN (careActivityRESTCAD);

                // Data
                // TODO: paginación

                careActivityEN = careActivityCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (careActivityEN != null) {
                        returnValue = new List<CareActivityDTOA>();
                        foreach (CareActivityEN entry in careActivityEN)
                                returnValue.Add (CareActivityAssembler.Convert (entry, session));
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
// [Route("{idCareActivity}", Name="GetOIDCareActivity")]

[Route ("~/api/CareActivity/{idCareActivity}")]

public HttpResponseMessage ReadOID (int idCareActivity)
{
        // CAD, CEN, EN, returnValue
        CareActivityRESTCAD careActivityRESTCAD = null;
        CareActivityCEN careActivityCEN = null;
        CareActivityEN careActivityEN = null;
        CareActivityDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                careActivityRESTCAD = new CareActivityRESTCAD (session);
                careActivityCEN = new CareActivityCEN (careActivityRESTCAD);

                // Data
                careActivityEN = careActivityCEN.ReadOID (idCareActivity);

                // Convert return
                if (careActivityEN != null) {
                        returnValue = CareActivityAssembler.Convert (careActivityEN, session);
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


[Route ("~/api/CareActivity/New_")]




public HttpResponseMessage New_ ( [FromBody] CareActivityDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        CareActivityRESTCAD careActivityRESTCAD = null;
        CareActivityCEN careActivityCEN = null;
        CareActivityDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                careActivityRESTCAD = new CareActivityRESTCAD (session);
                careActivityCEN = new CareActivityCEN (careActivityRESTCAD);

                // Create
                returnOID = careActivityCEN.New_ (

                        //Atributo OID: p_carePlan
                        // attr.estaRelacionado: true
                        dto.CarePlan_oid                 // association role

                        , dto.Periodicity                                                                                                                                                //Atributo Primitivo: p_periodicity
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        , dto.Duration                                                                                                                                                   //Atributo Primitivo: p_duration
                        , dto.Location                                                                                                                                                   //Atributo Primitivo: p_location
                        , dto.OutcomeCode                                                                                                                                                //Atributo Primitivo: p_outcomeCode
                        , dto.TypeActivity                                                                                                                                                       //Atributo Primitivo: p_typeActivity
                        , dto.ActivityCode                                                                                                                                                       //Atributo Primitivo: p_activityCode
                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        );
                SessionCommit ();

                // Convert return
                returnValue = CareActivityAssembler.Convert (careActivityRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDCareActivity", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/CareActivity/Modify")]

public HttpResponseMessage Modify (int idCareActivity, [FromBody] CareActivityDTO dto)
{
        // CAD, CEN, returnValue
        CareActivityRESTCAD careActivityRESTCAD = null;
        CareActivityCEN careActivityCEN = null;
        CareActivityDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                careActivityRESTCAD = new CareActivityRESTCAD (session);
                careActivityCEN = new CareActivityCEN (careActivityRESTCAD);

                // Modify
                careActivityCEN.Modify (idCareActivity,
                        dto.Periodicity
                        ,
                        dto.Description
                        ,
                        dto.Duration
                        ,
                        dto.Location
                        ,
                        dto.OutcomeCode
                        ,
                        dto.TypeActivity
                        ,
                        dto.ActivityCode
                        ,
                        dto.Name
                        );

                // Return modified object
                returnValue = CareActivityAssembler.Convert (careActivityRESTCAD.ReadOIDDefault (idCareActivity), session);

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


[Route ("~/api/CareActivity/Destroy")]

public HttpResponseMessage Destroy (int p_careactivity_oid)
{
        // CAD, CEN
        CareActivityRESTCAD careActivityRESTCAD = null;
        CareActivityCEN careActivityCEN = null;

        try
        {
                SessionInitializeTransaction ();


                careActivityRESTCAD = new CareActivityRESTCAD (session);
                careActivityCEN = new CareActivityCEN (careActivityRESTCAD);

                careActivityCEN.Destroy (p_careactivity_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_CareActivityControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
