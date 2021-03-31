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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_SensorTelemetryControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/SensorTelemetry")]
public class SensorTelemetryController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/SensorTelemetry/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        SensorTelemetryRESTCAD sensorTelemetryRESTCAD = null;
        SensorTelemetryCEN sensorTelemetryCEN = null;

        List<SensorTelemetryEN> sensorTelemetryEN = null;
        List<SensorTelemetryDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                sensorTelemetryRESTCAD = new SensorTelemetryRESTCAD (session);
                sensorTelemetryCEN = new SensorTelemetryCEN (sensorTelemetryRESTCAD);

                // Data
                // TODO: paginación

                sensorTelemetryEN = sensorTelemetryCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (sensorTelemetryEN != null) {
                        returnValue = new List<SensorTelemetryDTOA>();
                        foreach (SensorTelemetryEN entry in sensorTelemetryEN)
                                returnValue.Add (SensorTelemetryAssembler.Convert (entry, session));
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
// [Route("{idSensorTelemetry}", Name="GetOIDSensorTelemetry")]

[Route ("~/api/SensorTelemetry/{idSensorTelemetry}")]

public HttpResponseMessage ReadOID (int idSensorTelemetry)
{
        // CAD, CEN, EN, returnValue
        SensorTelemetryRESTCAD sensorTelemetryRESTCAD = null;
        SensorTelemetryCEN sensorTelemetryCEN = null;
        SensorTelemetryEN sensorTelemetryEN = null;
        SensorTelemetryDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                sensorTelemetryRESTCAD = new SensorTelemetryRESTCAD (session);
                sensorTelemetryCEN = new SensorTelemetryCEN (sensorTelemetryRESTCAD);

                // Data
                sensorTelemetryEN = sensorTelemetryCEN.ReadOID (idSensorTelemetry);

                // Convert return
                if (sensorTelemetryEN != null) {
                        returnValue = SensorTelemetryAssembler.Convert (sensorTelemetryEN, session);
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


[Route ("~/api/SensorTelemetry/New_")]




public HttpResponseMessage New_ ( [FromBody] SensorTelemetryDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        SensorTelemetryRESTCAD sensorTelemetryRESTCAD = null;
        SensorTelemetryCEN sensorTelemetryCEN = null;
        SensorTelemetryDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                sensorTelemetryRESTCAD = new SensorTelemetryRESTCAD (session);
                sensorTelemetryCEN = new SensorTelemetryCEN (sensorTelemetryRESTCAD);

                // Create
                returnOID = sensorTelemetryCEN.New_ (

                        //Atributo OID: p_telemetry
                        // attr.estaRelacionado: true
                        dto.Telemetry_oid                 // association role

                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.SensorType                                                                                                                                                 //Atributo Primitivo: p_sensorType
                        );
                SessionCommit ();

                // Convert return
                returnValue = SensorTelemetryAssembler.Convert (sensorTelemetryRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDSensorTelemetry", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/SensorTelemetry/Modify")]

public HttpResponseMessage Modify (int idSensorTelemetry, [FromBody] SensorTelemetryDTO dto)
{
        // CAD, CEN, returnValue
        SensorTelemetryRESTCAD sensorTelemetryRESTCAD = null;
        SensorTelemetryCEN sensorTelemetryCEN = null;
        SensorTelemetryDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                sensorTelemetryRESTCAD = new SensorTelemetryRESTCAD (session);
                sensorTelemetryCEN = new SensorTelemetryCEN (sensorTelemetryRESTCAD);

                // Modify
                sensorTelemetryCEN.Modify (idSensorTelemetry,
                        dto.Name
                        ,
                        dto.SensorType
                        );

                // Return modified object
                returnValue = SensorTelemetryAssembler.Convert (sensorTelemetryRESTCAD.ReadOIDDefault (idSensorTelemetry), session);

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


[Route ("~/api/SensorTelemetry/Destroy")]

public HttpResponseMessage Destroy (int p_sensortelemetry_oid)
{
        // CAD, CEN
        SensorTelemetryRESTCAD sensorTelemetryRESTCAD = null;
        SensorTelemetryCEN sensorTelemetryCEN = null;

        try
        {
                SessionInitializeTransaction ();


                sensorTelemetryRESTCAD = new SensorTelemetryRESTCAD (session);
                sensorTelemetryCEN = new SensorTelemetryCEN (sensorTelemetryRESTCAD);

                sensorTelemetryCEN.Destroy (p_sensortelemetry_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_SensorTelemetryControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
