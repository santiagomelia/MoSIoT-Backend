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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_CareActivityControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/CareActivity")]
public class CareActivityController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/CareActivity/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        CareActivityRESTCAD careActivityRESTCAD = null;
        CareActivityCEN careActivityCEN = null;

        List<CareActivityEN> careActivityEN = null;
        List<CareActivityDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                careActivityRESTCAD = new CareActivityRESTCAD (session);
                careActivityCEN = new CareActivityCEN (careActivityRESTCAD);

                // Data
                // TODO: paginación

                careActivityEN = careActivityCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (careActivityEN != null) {
                        returnValue = new List<CareActivityDTOA>();
                        foreach (CareActivityEN entry in careActivityEN)
                                returnValue.Add (CareActivityAssembler.Convert (entry, session));
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





[Route ("~/api/CareActivity/CarePlanActivities")]

public HttpResponseMessage CarePlanActivities (int idCarePlanTemplate)
{
        // CAD, EN
        CarePlanTemplateRESTCAD carePlanTemplateRESTCAD = null;
        CarePlanTemplateEN carePlanTemplateEN = null;

        // returnValue
        List<CareActivityEN> en = null;
        List<CareActivityDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                carePlanTemplateRESTCAD = new CarePlanTemplateRESTCAD (session);

                // Exists CarePlanTemplate
                carePlanTemplateEN = carePlanTemplateRESTCAD.ReadOIDDefault (idCarePlanTemplate);
                if (carePlanTemplateEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "CarePlanTemplate#" + idCarePlanTemplate + " not found"));

                // Rol
                // TODO: paginación


                en = carePlanTemplateRESTCAD.CarePlanActivities (idCarePlanTemplate).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<CareActivityDTOA>();
                        foreach (CareActivityEN entry in en)
                                returnValue.Add (CareActivityAssembler.Convert (entry, session));
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



























/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_CareActivityControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
