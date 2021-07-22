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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_CarePlanControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/CarePlan")]
public class CarePlanController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/CarePlan/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        CarePlanRESTCAD carePlanRESTCAD = null;
        CarePlanCEN carePlanCEN = null;

        List<CarePlanEN> carePlanEN = null;
        List<CarePlanDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                carePlanRESTCAD = new CarePlanRESTCAD (session);
                carePlanCEN = new CarePlanCEN (carePlanRESTCAD);

                // Data
                // TODO: paginación

                carePlanEN = carePlanCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (carePlanEN != null) {
                        returnValue = new List<CarePlanDTOA>();
                        foreach (CarePlanEN entry in carePlanEN)
                                returnValue.Add (CarePlanAssembler.Convert (entry, session));
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





[Route ("~/api/CarePlan/CarePlanScenario")]

public HttpResponseMessage CarePlanScenario (int idIoTScenario)
{
        // CAD, EN
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioEN ioTScenarioEN = null;

        // returnValue
        List<CarePlanEN> en = null;
        List<CarePlanDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);

                // Exists IoTScenario
                ioTScenarioEN = ioTScenarioRESTCAD.ReadOIDDefault (idIoTScenario);
                if (ioTScenarioEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IoTScenario#" + idIoTScenario + " not found"));

                // Rol
                // TODO: paginación


                en = ioTScenarioRESTCAD.CarePlanScenario (idIoTScenario).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<CarePlanDTOA>();
                        foreach (CarePlanEN entry in en)
                                returnValue.Add (CarePlanAssembler.Convert (entry, session));
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
// [Route("{idCarePlan}", Name="GetOIDCarePlan")]

[Route ("~/api/CarePlan/{idCarePlan}")]

public HttpResponseMessage ReadOID (int idCarePlan)
{
        // CAD, CEN, EN, returnValue
        CarePlanRESTCAD carePlanRESTCAD = null;
        CarePlanCEN carePlanCEN = null;
        CarePlanEN carePlanEN = null;
        CarePlanDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                carePlanRESTCAD = new CarePlanRESTCAD (session);
                carePlanCEN = new CarePlanCEN (carePlanRESTCAD);

                // Data
                carePlanEN = carePlanCEN.ReadOID (idCarePlan);

                // Convert return
                if (carePlanEN != null) {
                        returnValue = CarePlanAssembler.Convert (carePlanEN, session);
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
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        ,
                        //Atributo OID: p_scenario
                        // attr.estaRelacionado: true
                        dto.Scenario_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_template
                        // attr.estaRelacionado: true
                        dto.Template_oid                 // association role

                        );
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
                        dto.Name
                        ,
                        dto.Description
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_CarePlanControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
