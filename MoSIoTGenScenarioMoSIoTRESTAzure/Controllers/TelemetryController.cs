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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_TelemetryControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Telemetry")]
public class TelemetryController : BasicController
{
// Voy a generar el readAll







[HttpGet]





[Route ("~/api/Telemetry/DeviceTelemetries")]

public HttpResponseMessage DeviceTelemetries (int idDeviceTemplate)
{
        // CAD, EN
        DeviceTemplateRESTCAD deviceTemplateRESTCAD = null;
        DeviceTemplateEN deviceTemplateEN = null;

        // returnValue
        List<TelemetryEN> en = null;
        List<TelemetryDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                deviceTemplateRESTCAD = new DeviceTemplateRESTCAD (session);

                // Exists DeviceTemplate
                deviceTemplateEN = deviceTemplateRESTCAD.ReadOIDDefault (idDeviceTemplate);
                if (deviceTemplateEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "DeviceTemplate#" + idDeviceTemplate + " not found"));

                // Rol
                // TODO: paginaci�n


                en = deviceTemplateRESTCAD.DeviceTelemetries (idDeviceTemplate).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<TelemetryDTOA>();
                        foreach (TelemetryEN entry in en)
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




























/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_TelemetryControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
