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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_GoalControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Goal")]
public class GoalController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Goal/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        GoalRESTCAD goalRESTCAD = null;
        GoalCEN goalCEN = null;

        List<GoalEN> goalEN = null;
        List<GoalDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                goalRESTCAD = new GoalRESTCAD (session);
                goalCEN = new GoalCEN (goalRESTCAD);

                // Data
                // TODO: paginación

                goalEN = goalCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (goalEN != null) {
                        returnValue = new List<GoalDTOA>();
                        foreach (GoalEN entry in goalEN)
                                returnValue.Add (GoalAssembler.Convert (entry, session));
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
// [Route("{idGoal}", Name="GetOIDGoal")]

[Route ("~/api/Goal/{idGoal}")]

public HttpResponseMessage ReadOID (int idGoal)
{
        // CAD, CEN, EN, returnValue
        GoalRESTCAD goalRESTCAD = null;
        GoalCEN goalCEN = null;
        GoalEN goalEN = null;
        GoalDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                goalRESTCAD = new GoalRESTCAD (session);
                goalCEN = new GoalCEN (goalRESTCAD);

                // Data
                goalEN = goalCEN.ReadOID (idGoal);

                // Convert return
                if (goalEN != null) {
                        returnValue = GoalAssembler.Convert (goalEN, session);
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


[Route ("~/api/Goal/New_")]




public HttpResponseMessage New_ ( [FromBody] GoalDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        GoalRESTCAD goalRESTCAD = null;
        GoalCEN goalCEN = null;
        GoalDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                goalRESTCAD = new GoalRESTCAD (session);
                goalCEN = new GoalCEN (goalRESTCAD);

                // Create
                returnOID = goalCEN.New_ (

                        //Atributo OID: p_carePlan
                        // attr.estaRelacionado: true
                        dto.CarePlan_oid                 // association role

                        , dto.Priority                                                                                                                                                   //Atributo Primitivo: p_priority
                        , dto.Status                                                                                                                                                     //Atributo Primitivo: p_status
                        ,
                        //Atributo OID: p_condition
                        // attr.estaRelacionado: true
                        dto.Condition_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        , dto.Category                                                                                                                                                   //Atributo Primitivo: p_category
                        , dto.OutcomeCode                                                                                                                                                //Atributo Primitivo: p_outcomeCode
                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        );
                SessionCommit ();

                // Convert return
                returnValue = GoalAssembler.Convert (goalRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDGoal", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Goal/Modify")]

public HttpResponseMessage Modify (int idGoal, [FromBody] GoalDTO dto)
{
        // CAD, CEN, returnValue
        GoalRESTCAD goalRESTCAD = null;
        GoalCEN goalCEN = null;
        GoalDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                goalRESTCAD = new GoalRESTCAD (session);
                goalCEN = new GoalCEN (goalRESTCAD);

                // Modify
                goalCEN.Modify (idGoal,
                        dto.Priority
                        ,
                        dto.Status
                        ,
                        dto.Description
                        ,
                        dto.Category
                        ,
                        dto.OutcomeCode
                        ,
                        dto.Name
                        );

                // Return modified object
                returnValue = GoalAssembler.Convert (goalRESTCAD.ReadOIDDefault (idGoal), session);

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


[Route ("~/api/Goal/Destroy")]

public HttpResponseMessage Destroy (int p_goal_oid)
{
        // CAD, CEN
        GoalRESTCAD goalRESTCAD = null;
        GoalCEN goalCEN = null;

        try
        {
                SessionInitializeTransaction ();


                goalRESTCAD = new GoalRESTCAD (session);
                goalCEN = new GoalCEN (goalRESTCAD);

                goalCEN.Destroy (p_goal_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_GoalControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
