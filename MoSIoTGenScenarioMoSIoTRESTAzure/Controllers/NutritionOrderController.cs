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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_NutritionOrderControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/NutritionOrder")]
public class NutritionOrderController : BasicController
{
// Voy a generar el readAll








[HttpGet]





[Route ("~/api/NutritionOrder/ValueNutrition")]

public HttpResponseMessage ValueNutrition (int idIMNutritionOrder)
{
        // CAD, EN
        IMNutritionOrderRESTCAD iMNutritionOrderRESTCAD = null;
        IMNutritionOrderEN iMNutritionOrderEN = null;

        // returnValue
        NutritionOrderEN en = null;
        NutritionOrderDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMNutritionOrderRESTCAD = new IMNutritionOrderRESTCAD (session);

                // Exists IMNutritionOrder
                iMNutritionOrderEN = iMNutritionOrderRESTCAD.ReadOIDDefault (idIMNutritionOrder);
                if (iMNutritionOrderEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IMNutritionOrder#" + idIMNutritionOrder + " not found"));

                // Rol
                // TODO: paginación


                en = iMNutritionOrderRESTCAD.ValueNutrition (idIMNutritionOrder);



                // Convert return
                if (en != null) {
                        returnValue = NutritionOrderAssembler.Convert (en, session);
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
        if (returnValue == null)
                return this.Request.CreateResponse (HttpStatusCode.NoContent);
        // Return 200 - OK
        else return this.Request.CreateResponse (HttpStatusCode.OK, returnValue);
}



























/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_NutritionOrderControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
