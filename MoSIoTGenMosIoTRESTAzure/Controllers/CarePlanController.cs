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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_CarePlanControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/CarePlan")]
public class CarePlanController : BasicController
{
// Voy a generar el readAll














[HttpPost]


[Route ("~/api/CarePlan/New_")]




public HttpResponseMessage New_ ( [FromBody] CarePlanDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        CarePlanRESTCAD carePlanRESTCAD = null;
        CarePlanCEN carePlanCEN = null;
        CarePlanDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                carePlanRESTCAD = new CarePlanRESTCAD (session);
                carePlanCEN = new CarePlanCEN (carePlanRESTCAD);

                // Create
                returnOID = carePlanCEN.New_ (
                        //Atributo Primitivo: p_startDate
                        dto.StartDate,                                                                                                                                      //Atributo Primitivo: p_endDate
                        dto.EndDate,                                                                                                                                        //Atributo Primitivo: p_status
                        dto.Status,                                                                                                                                         //Atributo Primitivo: p_intent
                        dto.Intent,                                                                                                                                         //Atributo Primitivo: p_title
                        dto.Title,                                                                                                                                        //Atributo OID: p_patient
                        // attr.estaRelacionado: true
                        dto.Patient_oid                 // association role

                        ,                                           //Atributo Primitivo: p_modified
                        dto.Modified);
                SessionCommit ();

                // Convert return
                returnValue = CarePlanAssembler.Convert (carePlanRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDCarePlan", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]



[Route ("~/api/CarePlan/Modify")]

public HttpResponseMessage Modify (int idCarePlan, [FromBody] CarePlanDTO dto)
{
        // CAD, CEN, returnValue
        CarePlanRESTCAD carePlanRESTCAD = null;
        CarePlanCEN carePlanCEN = null;
        CarePlanDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                carePlanRESTCAD = new CarePlanRESTCAD (session);
                carePlanCEN = new CarePlanCEN (carePlanRESTCAD);

                // Modify
                carePlanCEN.Modify (idCarePlan,
                        dto.StartDate
                        ,
                        dto.EndDate
                        ,
                        dto.Status
                        ,
                        dto.Intent
                        ,
                        dto.Title
                        ,
                        dto.Modified
                        );

                // Return modified object
                returnValue = CarePlanAssembler.Convert (carePlanRESTCAD.ReadOIDDefault (idCarePlan), session);

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


[Route ("~/api/CarePlan/Destroy")]

public HttpResponseMessage Destroy (int p_careplan_oid)
{
        // CAD, CEN
        CarePlanRESTCAD carePlanRESTCAD = null;
        CarePlanCEN carePlanCEN = null;

        try
        {
                SessionInitializeTransaction ();


                carePlanRESTCAD = new CarePlanRESTCAD (session);
                carePlanCEN = new CarePlanCEN (carePlanRESTCAD);

                carePlanCEN.Destroy (p_careplan_oid);
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

[Route ("~/api/CarePlan/AddCondition")]

public HttpResponseMessage AddCondition (int p_careplan_oid, System.Collections.Generic.IList<int> p_addressconditions_oids)
{
        // CAD, CEN, returnValue
        CarePlanRESTCAD carePlanRESTCAD = null;
        CarePlanCEN carePlanCEN = null;

        try
        {
                SessionInitializeTransaction ();


                carePlanRESTCAD = new CarePlanRESTCAD (session);
                carePlanCEN = new CarePlanCEN (carePlanRESTCAD);

                // Relationer
                carePlanCEN.AddCondition (p_careplan_oid, p_addressconditions_oids);
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







/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_CarePlanControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
