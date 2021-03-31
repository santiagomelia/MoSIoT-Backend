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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_EventTelemetryControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/EventTelemetry")]
public class EventTelemetryController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/EventTelemetry/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        EventTelemetryRESTCAD eventTelemetryRESTCAD = null;
        EventTelemetryCEN eventTelemetryCEN = null;

        List<EventTelemetryEN> eventTelemetryEN = null;
        List<EventTelemetryDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                eventTelemetryRESTCAD = new EventTelemetryRESTCAD (session);
                eventTelemetryCEN = new EventTelemetryCEN (eventTelemetryRESTCAD);

                // Data
                // TODO: paginación

                eventTelemetryEN = eventTelemetryCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (eventTelemetryEN != null) {
                        returnValue = new List<EventTelemetryDTOA>();
                        foreach (EventTelemetryEN entry in eventTelemetryEN)
                                returnValue.Add (EventTelemetryAssembler.Convert (entry, session));
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
// [Route("{idEventTelemetry}", Name="GetOIDEventTelemetry")]

[Route ("~/api/EventTelemetry/{idEventTelemetry}")]

public HttpResponseMessage ReadOID (int idEventTelemetry)
{
        // CAD, CEN, EN, returnValue
        EventTelemetryRESTCAD eventTelemetryRESTCAD = null;
        EventTelemetryCEN eventTelemetryCEN = null;
        EventTelemetryEN eventTelemetryEN = null;
        EventTelemetryDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                eventTelemetryRESTCAD = new EventTelemetryRESTCAD (session);
                eventTelemetryCEN = new EventTelemetryCEN (eventTelemetryRESTCAD);

                // Data
                eventTelemetryEN = eventTelemetryCEN.ReadOID (idEventTelemetry);

                // Convert return
                if (eventTelemetryEN != null) {
                        returnValue = EventTelemetryAssembler.Convert (eventTelemetryEN, session);
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


[Route ("~/api/EventTelemetry/New_")]




public HttpResponseMessage New_ ( [FromBody] EventTelemetryDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        EventTelemetryRESTCAD eventTelemetryRESTCAD = null;
        EventTelemetryCEN eventTelemetryCEN = null;
        EventTelemetryDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                eventTelemetryRESTCAD = new EventTelemetryRESTCAD (session);
                eventTelemetryCEN = new EventTelemetryCEN (eventTelemetryRESTCAD);

                // Create
                returnOID = eventTelemetryCEN.New_ (

                        //Atributo OID: p_telemetry
                        // attr.estaRelacionado: true
                        dto.Telemetry_oid                 // association role

                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.Severity                                                                                                                                                   //Atributo Primitivo: p_severity
                        );
                SessionCommit ();

                // Convert return
                returnValue = EventTelemetryAssembler.Convert (eventTelemetryRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDEventTelemetry", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/EventTelemetry/Modify")]

public HttpResponseMessage Modify (int idEventTelemetry, [FromBody] EventTelemetryDTO dto)
{
        // CAD, CEN, returnValue
        EventTelemetryRESTCAD eventTelemetryRESTCAD = null;
        EventTelemetryCEN eventTelemetryCEN = null;
        EventTelemetryDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                eventTelemetryRESTCAD = new EventTelemetryRESTCAD (session);
                eventTelemetryCEN = new EventTelemetryCEN (eventTelemetryRESTCAD);

                // Modify
                eventTelemetryCEN.Modify (idEventTelemetry,
                        dto.Name
                        ,
                        dto.Severity
                        );

                // Return modified object
                returnValue = EventTelemetryAssembler.Convert (eventTelemetryRESTCAD.ReadOIDDefault (idEventTelemetry), session);

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


[Route ("~/api/EventTelemetry/Destroy")]

public HttpResponseMessage Destroy (int p_eventtelemetry_oid)
{
        // CAD, CEN
        EventTelemetryRESTCAD eventTelemetryRESTCAD = null;
        EventTelemetryCEN eventTelemetryCEN = null;

        try
        {
                SessionInitializeTransaction ();


                eventTelemetryRESTCAD = new EventTelemetryRESTCAD (session);
                eventTelemetryCEN = new EventTelemetryCEN (eventTelemetryRESTCAD);

                eventTelemetryCEN.Destroy (p_eventtelemetry_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_EventTelemetryControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
