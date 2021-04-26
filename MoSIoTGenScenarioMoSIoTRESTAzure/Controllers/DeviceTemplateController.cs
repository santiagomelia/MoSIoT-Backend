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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_DeviceTemplateControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/DeviceTemplate")]
public class DeviceTemplateController : BasicController
{
// Voy a generar el readAll








[HttpGet]





[Route ("~/api/DeviceTemplate/DevTemplatesAccessMode")]

public HttpResponseMessage DevTemplatesAccessMode (int idAccessMode)
{
        // CAD, EN
        AccessModeRESTCAD accessModeRESTCAD = null;
        AccessModeEN accessModeEN = null;

        // returnValue
        List<DeviceTemplateEN> en = null;
        List<DeviceTemplateDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                accessModeRESTCAD = new AccessModeRESTCAD (session);

                // Exists AccessMode
                accessModeEN = accessModeRESTCAD.ReadOIDDefault (idAccessMode);
                if (accessModeEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "AccessMode#" + idAccessMode + " not found"));

                // Rol
                // TODO: paginación


                en = accessModeRESTCAD.DevTemplatesAccessMode (idAccessMode).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<DeviceTemplateDTOA>();
                        foreach (DeviceTemplateEN entry in en)
                                returnValue.Add (DeviceTemplateAssembler.Convert (entry, session));
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



























/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_DeviceTemplateControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
