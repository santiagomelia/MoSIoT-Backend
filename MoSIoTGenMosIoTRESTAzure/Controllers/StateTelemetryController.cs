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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_StateTelemetryControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/StateTelemetry")]
public class StateTelemetryController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/StateTelemetry/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        StateTelemetryRESTCAD stateTelemetryRESTCAD = null;
        StateTelemetryCEN stateTelemetryCEN = null;

        List<StateTelemetryEN> stateTelemetryEN = null;
        List<StateTelemetryDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                stateTelemetryRESTCAD = new StateTelemetryRESTCAD (session);
                stateTelemetryCEN = new StateTelemetryCEN (stateTelemetryRESTCAD);

                // Data
                // TODO: paginación

                stateTelemetryEN = stateTelemetryCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (stateTelemetryEN != null) {
                        returnValue = new List<StateTelemetryDTOA>();
                        foreach (StateTelemetryEN entry in stateTelemetryEN)
                                returnValue.Add (StateTelemetryAssembler.Convert (entry, session));
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
// [Route("{idStateTelemetry}", Name="GetOIDStateTelemetry")]

[Route ("~/api/StateTelemetry/{idStateTelemetry}")]

public HttpResponseMessage ReadOID (int idStateTelemetry)
{
        // CAD, CEN, EN, returnValue
        StateTelemetryRESTCAD stateTelemetryRESTCAD = null;
        StateTelemetryCEN stateTelemetryCEN = null;
        StateTelemetryEN stateTelemetryEN = null;
        StateTelemetryDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                stateTelemetryRESTCAD = new StateTelemetryRESTCAD (session);
                stateTelemetryCEN = new StateTelemetryCEN (stateTelemetryRESTCAD);

                // Data
                stateTelemetryEN = stateTelemetryCEN.ReadOID (idStateTelemetry);

                // Convert return
                if (stateTelemetryEN != null) {
                        returnValue = StateTelemetryAssembler.Convert (stateTelemetryEN, session);
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


[Route ("~/api/StateTelemetry/New_")]




public HttpResponseMessage New_ ( [FromBody] StateTelemetryDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        StateTelemetryRESTCAD stateTelemetryRESTCAD = null;
        StateTelemetryCEN stateTelemetryCEN = null;
        StateTelemetryDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                stateTelemetryRESTCAD = new StateTelemetryRESTCAD (session);
                stateTelemetryCEN = new StateTelemetryCEN (stateTelemetryRESTCAD);

                // Create
                returnOID = stateTelemetryCEN.New_ (

                        //Atributo OID: p_telemetry
                        // attr.estaRelacionado: true
                        dto.Telemetry_oid                 // association role

                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        );
                SessionCommit ();

                // Convert return
                returnValue = StateTelemetryAssembler.Convert (stateTelemetryRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDStateTelemetry", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}










[HttpDelete]


[Route ("~/api/StateTelemetry/Destroy")]

public HttpResponseMessage Destroy (int p_statetelemetry_oid)
{
        // CAD, CEN
        StateTelemetryRESTCAD stateTelemetryRESTCAD = null;
        StateTelemetryCEN stateTelemetryCEN = null;

        try
        {
                SessionInitializeTransaction ();


                stateTelemetryRESTCAD = new StateTelemetryRESTCAD (session);
                stateTelemetryCEN = new StateTelemetryCEN (stateTelemetryRESTCAD);

                stateTelemetryCEN.Destroy (p_statetelemetry_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_StateTelemetryControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
