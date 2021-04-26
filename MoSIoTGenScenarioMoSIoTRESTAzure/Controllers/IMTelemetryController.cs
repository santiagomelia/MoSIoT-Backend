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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMTelemetryControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMTelemetry")]
public class IMTelemetryController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMTelemetry/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMTelemetryRESTCAD iMTelemetryRESTCAD = null;
        IMTelemetryCEN iMTelemetryCEN = null;

        List<IMTelemetryEN> iMTelemetryEN = null;
        List<IMTelemetryDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMTelemetryRESTCAD = new IMTelemetryRESTCAD (session);
                iMTelemetryCEN = new IMTelemetryCEN (iMTelemetryRESTCAD);

                // Data
                // TODO: paginación

                iMTelemetryEN = iMTelemetryCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMTelemetryEN != null) {
                        returnValue = new List<IMTelemetryDTOA>();
                        foreach (IMTelemetryEN entry in iMTelemetryEN)
                                returnValue.Add (IMTelemetryAssembler.Convert (entry, session));
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





[Route ("~/api/IMTelemetry/IMTelemetries")]

public HttpResponseMessage IMTelemetries (int idIoTScenario)
{
        // CAD, EN
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioEN ioTScenarioEN = null;

        // returnValue
        List<IMTelemetryEN> en = null;
        List<IMTelemetryDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);

                // Exists IoTScenario
                ioTScenarioEN = ioTScenarioRESTCAD.ReadOIDDefault (idIoTScenario);
                if (ioTScenarioEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IoTScenario#" + idIoTScenario + " not found"));

                // Rol
                // TODO: paginación


                en = ioTScenarioRESTCAD.IMTelemetries (idIoTScenario).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<IMTelemetryDTOA>();
                        foreach (IMTelemetryEN entry in en)
                                returnValue.Add (IMTelemetryAssembler.Convert (entry, session));
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
// [Route("{idIMTelemetry}", Name="GetOIDIMTelemetry")]

[Route ("~/api/IMTelemetry/{idIMTelemetry}")]

public HttpResponseMessage ReadOID (int idIMTelemetry)
{
        // CAD, CEN, EN, returnValue
        IMTelemetryRESTCAD iMTelemetryRESTCAD = null;
        IMTelemetryCEN iMTelemetryCEN = null;
        IMTelemetryEN iMTelemetryEN = null;
        IMTelemetryDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMTelemetryRESTCAD = new IMTelemetryRESTCAD (session);
                iMTelemetryCEN = new IMTelemetryCEN (iMTelemetryRESTCAD);

                // Data
                iMTelemetryEN = iMTelemetryCEN.ReadOID (idIMTelemetry);

                // Convert return
                if (iMTelemetryEN != null) {
                        returnValue = IMTelemetryAssembler.Convert (iMTelemetryEN, session);
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


[Route ("~/api/IMTelemetry/New_")]




public HttpResponseMessage New_ ( [FromBody] IMTelemetryDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMTelemetryRESTCAD iMTelemetryRESTCAD = null;
        IMTelemetryCEN iMTelemetryCEN = null;
        IMTelemetryDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMTelemetryRESTCAD = new IMTelemetryRESTCAD (session);
                iMTelemetryCEN = new IMTelemetryCEN (iMTelemetryRESTCAD);

                // Create
                returnOID = iMTelemetryCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        ,
                        //Atributo OID: p_scenario
                        // attr.estaRelacionado: true
                        dto.Scenario_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_telemetry
                        // attr.estaRelacionado: true
                        dto.Telemetry_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMTelemetryAssembler.Convert (iMTelemetryRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMTelemetry", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMTelemetry/Modify")]

public HttpResponseMessage Modify (int idIMTelemetry, [FromBody] IMTelemetryDTO dto)
{
        // CAD, CEN, returnValue
        IMTelemetryRESTCAD iMTelemetryRESTCAD = null;
        IMTelemetryCEN iMTelemetryCEN = null;
        IMTelemetryDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMTelemetryRESTCAD = new IMTelemetryRESTCAD (session);
                iMTelemetryCEN = new IMTelemetryCEN (iMTelemetryRESTCAD);

                // Modify
                iMTelemetryCEN.Modify (idIMTelemetry,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IMTelemetryAssembler.Convert (iMTelemetryRESTCAD.ReadOIDDefault (idIMTelemetry), session);

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


[Route ("~/api/IMTelemetry/Destroy")]

public HttpResponseMessage Destroy (int p_imtelemetry_oid)
{
        // CAD, CEN
        IMTelemetryRESTCAD iMTelemetryRESTCAD = null;
        IMTelemetryCEN iMTelemetryCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMTelemetryRESTCAD = new IMTelemetryRESTCAD (session);
                iMTelemetryCEN = new IMTelemetryCEN (iMTelemetryRESTCAD);

                iMTelemetryCEN.Destroy (p_imtelemetry_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMTelemetryControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
