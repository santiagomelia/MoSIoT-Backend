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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_NutritionOrderControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/NutritionOrder")]
public class NutritionOrderController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/NutritionOrder/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        NutritionOrderRESTCAD nutritionOrderRESTCAD = null;
        NutritionOrderCEN nutritionOrderCEN = null;

        List<NutritionOrderEN> nutritionOrderEN = null;
        List<NutritionOrderDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                nutritionOrderRESTCAD = new NutritionOrderRESTCAD (session);
                nutritionOrderCEN = new NutritionOrderCEN (nutritionOrderRESTCAD);

                // Data
                // TODO: paginación

                nutritionOrderEN = nutritionOrderCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (nutritionOrderEN != null) {
                        returnValue = new List<NutritionOrderDTOA>();
                        foreach (NutritionOrderEN entry in nutritionOrderEN)
                                returnValue.Add (NutritionOrderAssembler.Convert (entry, session));
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
// [Route("{idNutritionOrder}", Name="GetOIDNutritionOrder")]

[Route ("~/api/NutritionOrder/{idNutritionOrder}")]

public HttpResponseMessage ReadOID (int idNutritionOrder)
{
        // CAD, CEN, EN, returnValue
        NutritionOrderRESTCAD nutritionOrderRESTCAD = null;
        NutritionOrderCEN nutritionOrderCEN = null;
        NutritionOrderEN nutritionOrderEN = null;
        NutritionOrderDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                nutritionOrderRESTCAD = new NutritionOrderRESTCAD (session);
                nutritionOrderCEN = new NutritionOrderCEN (nutritionOrderRESTCAD);

                // Data
                nutritionOrderEN = nutritionOrderCEN.ReadOID (idNutritionOrder);

                // Convert return
                if (nutritionOrderEN != null) {
                        returnValue = NutritionOrderAssembler.Convert (nutritionOrderEN, session);
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


[Route ("~/api/NutritionOrder/New_")]




public HttpResponseMessage New_ ( [FromBody] NutritionOrderDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        NutritionOrderRESTCAD nutritionOrderRESTCAD = null;
        NutritionOrderCEN nutritionOrderCEN = null;
        NutritionOrderDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                nutritionOrderRESTCAD = new NutritionOrderRESTCAD (session);
                nutritionOrderCEN = new NutritionOrderCEN (nutritionOrderRESTCAD);

                // Create
                returnOID = nutritionOrderCEN.New_ (
                        dto.Description                                                                          //Atributo Primitivo: p_description
                        , dto.DietCode                                                                                                                                                   //Atributo Primitivo: p_dietCode
                        ,
                        //Atributo OID: p_careActivity
                        // attr.estaRelacionado: true
                        dto.CareActivity_oid                 // association role

                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        );
                SessionCommit ();

                // Convert return
                returnValue = NutritionOrderAssembler.Convert (nutritionOrderRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDNutritionOrder", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/NutritionOrder/Modify")]

public HttpResponseMessage Modify (int idNutritionOrder, [FromBody] NutritionOrderDTO dto)
{
        // CAD, CEN, returnValue
        NutritionOrderRESTCAD nutritionOrderRESTCAD = null;
        NutritionOrderCEN nutritionOrderCEN = null;
        NutritionOrderDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                nutritionOrderRESTCAD = new NutritionOrderRESTCAD (session);
                nutritionOrderCEN = new NutritionOrderCEN (nutritionOrderRESTCAD);

                // Modify
                nutritionOrderCEN.Modify (idNutritionOrder,
                        dto.Description
                        ,
                        dto.DietCode
                        ,
                        dto.Name
                        );

                // Return modified object
                returnValue = NutritionOrderAssembler.Convert (nutritionOrderRESTCAD.ReadOIDDefault (idNutritionOrder), session);

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


[Route ("~/api/NutritionOrder/Destroy")]

public HttpResponseMessage Destroy (int p_nutritionorder_oid)
{
        // CAD, CEN
        NutritionOrderRESTCAD nutritionOrderRESTCAD = null;
        NutritionOrderCEN nutritionOrderCEN = null;

        try
        {
                SessionInitializeTransaction ();


                nutritionOrderRESTCAD = new NutritionOrderRESTCAD (session);
                nutritionOrderCEN = new NutritionOrderCEN (nutritionOrderRESTCAD);

                nutritionOrderCEN.Destroy (p_nutritionorder_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_NutritionOrderControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
