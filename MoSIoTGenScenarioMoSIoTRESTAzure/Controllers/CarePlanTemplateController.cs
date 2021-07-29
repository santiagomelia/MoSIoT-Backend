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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_CarePlanTemplateControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/CarePlanTemplate")]
public class CarePlanTemplateController : BasicController
{
// Voy a generar el readAll








[HttpGet]





[Route ("~/api/CarePlanTemplate/PatientProfileCarePlanTemplate")]

public HttpResponseMessage PatientProfileCarePlanTemplate (int idPatientProfile)
{
        // CAD, EN
        PatientProfileRESTCAD patientProfileRESTCAD = null;
        PatientProfileEN patientProfileEN = null;

        // returnValue
        List<CarePlanTemplateEN> en = null;
        List<CarePlanTemplateDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                patientProfileRESTCAD = new PatientProfileRESTCAD (session);

                // Exists PatientProfile
                patientProfileEN = patientProfileRESTCAD.ReadOIDDefault (idPatientProfile);
                if (patientProfileEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "PatientProfile#" + idPatientProfile + " not found"));

                // Rol
                // TODO: paginación


                en = patientProfileRESTCAD.PatientProfileCarePlanTemplate (idPatientProfile).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<CarePlanTemplateDTOA>();
                        foreach (CarePlanTemplateEN entry in en)
                                returnValue.Add (CarePlanTemplateAssembler.Convert (entry, session));
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



























/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_CarePlanTemplateControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
