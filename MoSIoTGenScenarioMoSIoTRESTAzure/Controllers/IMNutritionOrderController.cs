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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMNutritionOrderControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMNutritionOrder")]
public class IMNutritionOrderController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMNutritionOrder/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMNutritionOrderRESTCAD iMNutritionOrderRESTCAD = null;
        IMNutritionOrderCEN iMNutritionOrderCEN = null;

        List<IMNutritionOrderEN> iMNutritionOrderEN = null;
        List<IMNutritionOrderDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMNutritionOrderRESTCAD = new IMNutritionOrderRESTCAD (session);
                iMNutritionOrderCEN = new IMNutritionOrderCEN (iMNutritionOrderRESTCAD);

                // Data
                // TODO: paginación

                iMNutritionOrderEN = iMNutritionOrderCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMNutritionOrderEN != null) {
                        returnValue = new List<IMNutritionOrderDTOA>();
                        foreach (IMNutritionOrderEN entry in iMNutritionOrderEN)
                                returnValue.Add (IMNutritionOrderAssembler.Convert (entry, session));
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





[Route ("~/api/IMNutritionOrder/NutritionOrderCareActivity")]

public HttpResponseMessage NutritionOrderCareActivity (int idIMCareActivity)
{
        // CAD, EN
        IMCareActivityRESTCAD iMCareActivityRESTCAD = null;
        IMCareActivityEN iMCareActivityEN = null;

        // returnValue
        List<IMNutritionOrderEN> en = null;
        List<IMNutritionOrderDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMCareActivityRESTCAD = new IMCareActivityRESTCAD (session);

                // Exists IMCareActivity
                iMCareActivityEN = iMCareActivityRESTCAD.ReadOIDDefault (idIMCareActivity);
                if (iMCareActivityEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IMCareActivity#" + idIMCareActivity + " not found"));

                // Rol
                // TODO: paginación


                en = iMCareActivityRESTCAD.NutritionOrderCareActivity (idIMCareActivity).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<IMNutritionOrderDTOA>();
                        foreach (IMNutritionOrderEN entry in en)
                                returnValue.Add (IMNutritionOrderAssembler.Convert (entry, session));
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
// [Route("{idIMNutritionOrder}", Name="GetOIDIMNutritionOrder")]

[Route ("~/api/IMNutritionOrder/{idIMNutritionOrder}")]

public HttpResponseMessage ReadOID (int idIMNutritionOrder)
{
        // CAD, CEN, EN, returnValue
        IMNutritionOrderRESTCAD iMNutritionOrderRESTCAD = null;
        IMNutritionOrderCEN iMNutritionOrderCEN = null;
        IMNutritionOrderEN iMNutritionOrderEN = null;
        IMNutritionOrderDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMNutritionOrderRESTCAD = new IMNutritionOrderRESTCAD (session);
                iMNutritionOrderCEN = new IMNutritionOrderCEN (iMNutritionOrderRESTCAD);

                // Data
                iMNutritionOrderEN = iMNutritionOrderCEN.ReadOID (idIMNutritionOrder);

                // Convert return
                if (iMNutritionOrderEN != null) {
                        returnValue = IMNutritionOrderAssembler.Convert (iMNutritionOrderEN, session);
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


[Route ("~/api/IMNutritionOrder/New_")]




public HttpResponseMessage New_ ( [FromBody] IMNutritionOrderDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMNutritionOrderRESTCAD iMNutritionOrderRESTCAD = null;
        IMNutritionOrderCEN iMNutritionOrderCEN = null;
        IMNutritionOrderDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMNutritionOrderRESTCAD = new IMNutritionOrderRESTCAD (session);
                iMNutritionOrderCEN = new IMNutritionOrderCEN (iMNutritionOrderRESTCAD);

                // Create
                returnOID = iMNutritionOrderCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_entity
                        // attr.estaRelacionado: true
                        dto.Entity_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMNutritionOrderAssembler.Convert (iMNutritionOrderRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMNutritionOrder", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMNutritionOrder/Modify")]

public HttpResponseMessage Modify (int idIMNutritionOrder, [FromBody] IMNutritionOrderDTO dto)
{
        // CAD, CEN, returnValue
        IMNutritionOrderRESTCAD iMNutritionOrderRESTCAD = null;
        IMNutritionOrderCEN iMNutritionOrderCEN = null;
        IMNutritionOrderDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMNutritionOrderRESTCAD = new IMNutritionOrderRESTCAD (session);
                iMNutritionOrderCEN = new IMNutritionOrderCEN (iMNutritionOrderRESTCAD);

                // Modify
                iMNutritionOrderCEN.Modify (idIMNutritionOrder,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IMNutritionOrderAssembler.Convert (iMNutritionOrderRESTCAD.ReadOIDDefault (idIMNutritionOrder), session);

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


[Route ("~/api/IMNutritionOrder/Destroy")]

public HttpResponseMessage Destroy (int p_imnutritionorder_oid)
{
        // CAD, CEN
        IMNutritionOrderRESTCAD iMNutritionOrderRESTCAD = null;
        IMNutritionOrderCEN iMNutritionOrderCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMNutritionOrderRESTCAD = new IMNutritionOrderRESTCAD (session);
                iMNutritionOrderCEN = new IMNutritionOrderCEN (iMNutritionOrderRESTCAD);

                iMNutritionOrderCEN.Destroy (p_imnutritionorder_oid);
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





[HttpPut]


[Route ("~/api/IMNutritionOrder/AssignNutrition")]

public HttpResponseMessage AssignNutrition (int p_imnutritionorder_oid, int p_nutritionorder_oid)
{
        // CAD, CEN, returnValue
        IMNutritionOrderRESTCAD iMNutritionOrderRESTCAD = null;
        IMNutritionOrderCEN iMNutritionOrderCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMNutritionOrderRESTCAD = new IMNutritionOrderRESTCAD (session);
                iMNutritionOrderCEN = new IMNutritionOrderCEN (iMNutritionOrderRESTCAD);

                // Relationer
                iMNutritionOrderCEN.AssignNutrition (p_imnutritionorder_oid, p_nutritionorder_oid);
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

        // Return 200 - OK
        return this.Request.CreateResponse (HttpStatusCode.OK);
}







/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMNutritionOrderControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
