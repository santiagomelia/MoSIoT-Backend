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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_TelemetryControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Telemetry")]
public class TelemetryController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Telemetry/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        TelemetryRESTCAD telemetryRESTCAD = null;
        TelemetryCEN telemetryCEN = null;

        List<TelemetryEN> telemetryEN = null;
        List<TelemetryDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                telemetryRESTCAD = new TelemetryRESTCAD (session);
                telemetryCEN = new TelemetryCEN (telemetryRESTCAD);

                // Data
                // TODO: paginación

                telemetryEN = telemetryCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (telemetryEN != null) {
                        returnValue = new List<TelemetryDTOA>();
                        foreach (TelemetryEN entry in telemetryEN)
                                returnValue.Add (TelemetryAssembler.Convert (entry, session));
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
// [Route("{idTelemetry}", Name="GetOIDTelemetry")]

[Route ("~/api/Telemetry/{idTelemetry}")]

public HttpResponseMessage ReadOID (int idTelemetry)
{
        // CAD, CEN, EN, returnValue
        TelemetryRESTCAD telemetryRESTCAD = null;
        TelemetryCEN telemetryCEN = null;
        TelemetryEN telemetryEN = null;
        TelemetryDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                telemetryRESTCAD = new TelemetryRESTCAD (session);
                telemetryCEN = new TelemetryCEN (telemetryRESTCAD);

                // Data
                telemetryEN = telemetryCEN.ReadOID (idTelemetry);

                // Convert return
                if (telemetryEN != null) {
                        returnValue = TelemetryAssembler.Convert (telemetryEN, session);
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


[Route ("~/api/Telemetry/New_")]




public HttpResponseMessage New_ ( [FromBody] TelemetryDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        TelemetryRESTCAD telemetryRESTCAD = null;
        TelemetryCEN telemetryCEN = null;
        TelemetryDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                telemetryRESTCAD = new TelemetryRESTCAD (session);
                telemetryCEN = new TelemetryCEN (telemetryRESTCAD);

                // Create
                returnOID = telemetryCEN.New_ (

                        //Atributo OID: p_deviceTemplate
                        // attr.estaRelacionado: true
                        dto.DeviceTemplate_oid                 // association role

                        , dto.Frecuency                                                                                                                                                  //Atributo Primitivo: p_frecuency
                        , dto.Schema                                                                                                                                                     //Atributo Primitivo: p_schema
                        , dto.Unit                                                                                                                                                       //Atributo Primitivo: p_unit
                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.Type                                                                                                                                                       //Atributo Primitivo: p_type
                        );
                SessionCommit ();

                // Convert return
                returnValue = TelemetryAssembler.Convert (telemetryRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDTelemetry", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Telemetry/Modify")]

public HttpResponseMessage Modify (int idTelemetry, [FromBody] TelemetryDTO dto)
{
        // CAD, CEN, returnValue
        TelemetryRESTCAD telemetryRESTCAD = null;
        TelemetryCEN telemetryCEN = null;
        TelemetryDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                telemetryRESTCAD = new TelemetryRESTCAD (session);
                telemetryCEN = new TelemetryCEN (telemetryRESTCAD);

                // Modify
                telemetryCEN.Modify (idTelemetry,
                        dto.Frecuency
                        ,
                        dto.Schema
                        ,
                        dto.Unit
                        ,
                        dto.Name
                        ,
                        dto.Type
                        );

                // Return modified object
                returnValue = TelemetryAssembler.Convert (telemetryRESTCAD.ReadOIDDefault (idTelemetry), session);

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


[Route ("~/api/Telemetry/Destroy")]

public HttpResponseMessage Destroy (int p_telemetry_oid)
{
        // CAD, CEN
        TelemetryRESTCAD telemetryRESTCAD = null;
        TelemetryCEN telemetryCEN = null;

        try
        {
                SessionInitializeTransaction ();


                telemetryRESTCAD = new TelemetryRESTCAD (session);
                telemetryCEN = new TelemetryCEN (telemetryRESTCAD);

                telemetryCEN.Destroy (p_telemetry_oid);
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





[HttpPut]


[Route ("~/api/Telemetry/AsignarSpecific")]

public HttpResponseMessage AsignarSpecific (int p_telemetry_oid, int p_typetelemetry_oid)
{
        // CAD, CEN, returnValue
        TelemetryRESTCAD telemetryRESTCAD = null;
        TelemetryCEN telemetryCEN = null;

        try
        {
                SessionInitializeTransaction ();


                telemetryRESTCAD = new TelemetryRESTCAD (session);
                telemetryCEN = new TelemetryCEN (telemetryRESTCAD);

                // Relationer
                telemetryCEN.AsignarSpecific (p_telemetry_oid, p_typetelemetry_oid);
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

        // Return 200 - OK
        return this.Request.CreateResponse (HttpStatusCode.OK);
}







/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_TelemetryControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
