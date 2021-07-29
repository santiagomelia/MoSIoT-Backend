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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMGoalControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMGoal")]
public class IMGoalController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMGoal/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMGoalRESTCAD iMGoalRESTCAD = null;
        IMGoalCEN iMGoalCEN = null;

        List<IMGoalEN> iMGoalEN = null;
        List<IMGoalDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMGoalRESTCAD = new IMGoalRESTCAD (session);
                iMGoalCEN = new IMGoalCEN (iMGoalRESTCAD);

                // Data
                // TODO: paginación

                iMGoalEN = iMGoalCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMGoalEN != null) {
                        returnValue = new List<IMGoalDTOA>();
                        foreach (IMGoalEN entry in iMGoalEN)
                                returnValue.Add (IMGoalAssembler.Convert (entry, session));
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





[Route ("~/api/IMGoal/GoalsCarePlan")]

public HttpResponseMessage GoalsCarePlan (int idCarePlan)
{
        // CAD, EN
        CarePlanRESTCAD carePlanRESTCAD = null;
        CarePlanEN carePlanEN = null;

        // returnValue
        List<IMGoalEN> en = null;
        List<IMGoalDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                carePlanRESTCAD = new CarePlanRESTCAD (session);

                // Exists CarePlan
                carePlanEN = carePlanRESTCAD.ReadOIDDefault (idCarePlan);
                if (carePlanEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "CarePlan#" + idCarePlan + " not found"));

                // Rol
                // TODO: paginación


                en = carePlanRESTCAD.GoalsCarePlan (idCarePlan).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<IMGoalDTOA>();
                        foreach (IMGoalEN entry in en)
                                returnValue.Add (IMGoalAssembler.Convert (entry, session));
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
// [Route("{idIMGoal}", Name="GetOIDIMGoal")]

[Route ("~/api/IMGoal/{idIMGoal}")]

public HttpResponseMessage ReadOID (int idIMGoal)
{
        // CAD, CEN, EN, returnValue
        IMGoalRESTCAD iMGoalRESTCAD = null;
        IMGoalCEN iMGoalCEN = null;
        IMGoalEN iMGoalEN = null;
        IMGoalDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMGoalRESTCAD = new IMGoalRESTCAD (session);
                iMGoalCEN = new IMGoalCEN (iMGoalRESTCAD);

                // Data
                iMGoalEN = iMGoalCEN.ReadOID (idIMGoal);

                // Convert return
                if (iMGoalEN != null) {
                        returnValue = IMGoalAssembler.Convert (iMGoalEN, session);
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


[Route ("~/api/IMGoal/New_")]




public HttpResponseMessage New_ ( [FromBody] IMGoalDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMGoalRESTCAD iMGoalRESTCAD = null;
        IMGoalCEN iMGoalCEN = null;
        IMGoalDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMGoalRESTCAD = new IMGoalRESTCAD (session);
                iMGoalCEN = new IMGoalCEN (iMGoalRESTCAD);

                // Create
                returnOID = iMGoalCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_entity
                        // attr.estaRelacionado: true
                        dto.Entity_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMGoalAssembler.Convert (iMGoalRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMGoal", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMGoal/Modify")]

public HttpResponseMessage Modify (int idIMGoal, [FromBody] IMGoalDTO dto)
{
        // CAD, CEN, returnValue
        IMGoalRESTCAD iMGoalRESTCAD = null;
        IMGoalCEN iMGoalCEN = null;
        IMGoalDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMGoalRESTCAD = new IMGoalRESTCAD (session);
                iMGoalCEN = new IMGoalCEN (iMGoalRESTCAD);

                // Modify
                iMGoalCEN.Modify (idIMGoal,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IMGoalAssembler.Convert (iMGoalRESTCAD.ReadOIDDefault (idIMGoal), session);

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


[Route ("~/api/IMGoal/Destroy")]

public HttpResponseMessage Destroy (int p_imgoal_oid)
{
        // CAD, CEN
        IMGoalRESTCAD iMGoalRESTCAD = null;
        IMGoalCEN iMGoalCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMGoalRESTCAD = new IMGoalRESTCAD (session);
                iMGoalCEN = new IMGoalCEN (iMGoalRESTCAD);

                iMGoalCEN.Destroy (p_imgoal_oid);
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


[Route ("~/api/IMGoal/AssignGoal")]

public HttpResponseMessage AssignGoal (int p_imgoal_oid, int p_goal_oid)
{
        // CAD, CEN, returnValue
        IMGoalRESTCAD iMGoalRESTCAD = null;
        IMGoalCEN iMGoalCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMGoalRESTCAD = new IMGoalRESTCAD (session);
                iMGoalCEN = new IMGoalCEN (iMGoalRESTCAD);

                // Relationer
                iMGoalCEN.AssignGoal (p_imgoal_oid, p_goal_oid);
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







/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMGoalControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
