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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_LocationTelemetryControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/LocationTelemetry")]
public class LocationTelemetryController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/LocationTelemetry/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        LocationTelemetryRESTCAD locationTelemetryRESTCAD = null;
        LocationTelemetryCEN locationTelemetryCEN = null;

        List<LocationTelemetryEN> locationTelemetryEN = null;
        List<LocationTelemetryDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                locationTelemetryRESTCAD = new LocationTelemetryRESTCAD (session);
                locationTelemetryCEN = new LocationTelemetryCEN (locationTelemetryRESTCAD);

                // Data
                // TODO: paginación

                locationTelemetryEN = locationTelemetryCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (locationTelemetryEN != null) {
                        returnValue = new List<LocationTelemetryDTOA>();
                        foreach (LocationTelemetryEN entry in locationTelemetryEN)
                                returnValue.Add (LocationTelemetryAssembler.Convert (entry, session));
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
// [Route("{idLocationTelemetry}", Name="GetOIDLocationTelemetry")]

[Route ("~/api/LocationTelemetry/{idLocationTelemetry}")]

public HttpResponseMessage ReadOID (int idLocationTelemetry)
{
        // CAD, CEN, EN, returnValue
        LocationTelemetryRESTCAD locationTelemetryRESTCAD = null;
        LocationTelemetryCEN locationTelemetryCEN = null;
        LocationTelemetryEN locationTelemetryEN = null;
        LocationTelemetryDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                locationTelemetryRESTCAD = new LocationTelemetryRESTCAD (session);
                locationTelemetryCEN = new LocationTelemetryCEN (locationTelemetryRESTCAD);

                // Data
                locationTelemetryEN = locationTelemetryCEN.ReadOID (idLocationTelemetry);

                // Convert return
                if (locationTelemetryEN != null) {
                        returnValue = LocationTelemetryAssembler.Convert (locationTelemetryEN, session);
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


[Route ("~/api/LocationTelemetry/New_")]




public HttpResponseMessage New_ ( [FromBody] LocationTelemetryDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        LocationTelemetryRESTCAD locationTelemetryRESTCAD = null;
        LocationTelemetryCEN locationTelemetryCEN = null;
        LocationTelemetryDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                locationTelemetryRESTCAD = new LocationTelemetryRESTCAD (session);
                locationTelemetryCEN = new LocationTelemetryCEN (locationTelemetryRESTCAD);

                // Create
                returnOID = locationTelemetryCEN.New_ (

                        //Atributo OID: p_telemetry
                        // attr.estaRelacionado: true
                        dto.Telemetry_oid                 // association role

                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.Latitude                                                                                                                                                   //Atributo Primitivo: p_latitude
                        , dto.Longitude                                                                                                                                                  //Atributo Primitivo: p_longitude
                        , dto.Altitude                                                                                                                                                   //Atributo Primitivo: p_altitude
                        );
                SessionCommit ();

                // Convert return
                returnValue = LocationTelemetryAssembler.Convert (locationTelemetryRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDLocationTelemetry", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/LocationTelemetry/Modify")]

public HttpResponseMessage Modify (int idLocationTelemetry, [FromBody] LocationTelemetryDTO dto)
{
        // CAD, CEN, returnValue
        LocationTelemetryRESTCAD locationTelemetryRESTCAD = null;
        LocationTelemetryCEN locationTelemetryCEN = null;
        LocationTelemetryDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                locationTelemetryRESTCAD = new LocationTelemetryRESTCAD (session);
                locationTelemetryCEN = new LocationTelemetryCEN (locationTelemetryRESTCAD);

                // Modify
                locationTelemetryCEN.Modify (idLocationTelemetry,
                        dto.Name
                        ,
                        dto.Latitude
                        ,
                        dto.Longitude
                        ,
                        dto.Altitude
                        );

                // Return modified object
                returnValue = LocationTelemetryAssembler.Convert (locationTelemetryRESTCAD.ReadOIDDefault (idLocationTelemetry), session);

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


[Route ("~/api/LocationTelemetry/Destroy")]

public HttpResponseMessage Destroy (int p_locationtelemetry_oid)
{
        // CAD, CEN
        LocationTelemetryRESTCAD locationTelemetryRESTCAD = null;
        LocationTelemetryCEN locationTelemetryCEN = null;

        try
        {
                SessionInitializeTransaction ();


                locationTelemetryRESTCAD = new LocationTelemetryRESTCAD (session);
                locationTelemetryCEN = new LocationTelemetryCEN (locationTelemetryRESTCAD);

                locationTelemetryCEN.Destroy (p_locationtelemetry_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_LocationTelemetryControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
