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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_RangeStateTelemetryControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/RangeStateTelemetry")]
public class RangeStateTelemetryController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/RangeStateTelemetry/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        RangeStateTelemetryRESTCAD rangeStateTelemetryRESTCAD = null;
        RangeStateTelemetryCEN rangeStateTelemetryCEN = null;

        List<RangeStateTelemetryEN> rangeStateTelemetryEN = null;
        List<RangeStateTelemetryDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                rangeStateTelemetryRESTCAD = new RangeStateTelemetryRESTCAD (session);
                rangeStateTelemetryCEN = new RangeStateTelemetryCEN (rangeStateTelemetryRESTCAD);

                // Data
                // TODO: paginación

                rangeStateTelemetryEN = rangeStateTelemetryCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (rangeStateTelemetryEN != null) {
                        returnValue = new List<RangeStateTelemetryDTOA>();
                        foreach (RangeStateTelemetryEN entry in rangeStateTelemetryEN)
                                returnValue.Add (RangeStateTelemetryAssembler.Convert (entry, session));
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
// [Route("{idRangeStateTelemetry}", Name="GetOIDRangeStateTelemetry")]

[Route ("~/api/RangeStateTelemetry/{idRangeStateTelemetry}")]

public HttpResponseMessage ReadOID (int idRangeStateTelemetry)
{
        // CAD, CEN, EN, returnValue
        RangeStateTelemetryRESTCAD rangeStateTelemetryRESTCAD = null;
        RangeStateTelemetryCEN rangeStateTelemetryCEN = null;
        RangeStateTelemetryEN rangeStateTelemetryEN = null;
        RangeStateTelemetryDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                rangeStateTelemetryRESTCAD = new RangeStateTelemetryRESTCAD (session);
                rangeStateTelemetryCEN = new RangeStateTelemetryCEN (rangeStateTelemetryRESTCAD);

                // Data
                rangeStateTelemetryEN = rangeStateTelemetryCEN.ReadOID (idRangeStateTelemetry);

                // Convert return
                if (rangeStateTelemetryEN != null) {
                        returnValue = RangeStateTelemetryAssembler.Convert (rangeStateTelemetryEN, session);
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


[Route ("~/api/RangeStateTelemetry/New_")]




public HttpResponseMessage New_ ( [FromBody] RangeStateTelemetryDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        RangeStateTelemetryRESTCAD rangeStateTelemetryRESTCAD = null;
        RangeStateTelemetryCEN rangeStateTelemetryCEN = null;
        RangeStateTelemetryDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                rangeStateTelemetryRESTCAD = new RangeStateTelemetryRESTCAD (session);
                rangeStateTelemetryCEN = new RangeStateTelemetryCEN (rangeStateTelemetryRESTCAD);

                // Create
                returnOID = rangeStateTelemetryCEN.New_ (
                        //Atributo Primitivo: p_name
                        dto.Name,                                                                                                                                           //Atributo Primitivo: p_value
                        dto.Value);
                SessionCommit ();

                // Convert return
                returnValue = RangeStateTelemetryAssembler.Convert (rangeStateTelemetryRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDRangeStateTelemetry", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]



[Route ("~/api/RangeStateTelemetry/Modify")]

public HttpResponseMessage Modify (int idRangeStateTelemetry, [FromBody] RangeStateTelemetryDTO dto)
{
        // CAD, CEN, returnValue
        RangeStateTelemetryRESTCAD rangeStateTelemetryRESTCAD = null;
        RangeStateTelemetryCEN rangeStateTelemetryCEN = null;
        RangeStateTelemetryDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                rangeStateTelemetryRESTCAD = new RangeStateTelemetryRESTCAD (session);
                rangeStateTelemetryCEN = new RangeStateTelemetryCEN (rangeStateTelemetryRESTCAD);

                // Modify
                rangeStateTelemetryCEN.Modify (idRangeStateTelemetry,
                        dto.Name
                        ,
                        dto.Value
                        );

                // Return modified object
                returnValue = RangeStateTelemetryAssembler.Convert (rangeStateTelemetryRESTCAD.ReadOIDDefault (idRangeStateTelemetry), session);

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


[Route ("~/api/RangeStateTelemetry/Destroy")]

public HttpResponseMessage Destroy (int p_rangestatetelemetry_oid)
{
        // CAD, CEN
        RangeStateTelemetryRESTCAD rangeStateTelemetryRESTCAD = null;
        RangeStateTelemetryCEN rangeStateTelemetryCEN = null;

        try
        {
                SessionInitializeTransaction ();


                rangeStateTelemetryRESTCAD = new RangeStateTelemetryRESTCAD (session);
                rangeStateTelemetryCEN = new RangeStateTelemetryCEN (rangeStateTelemetryRESTCAD);

                rangeStateTelemetryCEN.Destroy (p_rangestatetelemetry_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_RangeStateTelemetryControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
