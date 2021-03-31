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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_TargetControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Target")]
public class TargetController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Target/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        TargetRESTCAD targetRESTCAD = null;
        TargetCEN targetCEN = null;

        List<TargetEN> targetEN = null;
        List<TargetDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                targetRESTCAD = new TargetRESTCAD (session);
                targetCEN = new TargetCEN (targetRESTCAD);

                // Data
                // TODO: paginación

                targetEN = targetCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (targetEN != null) {
                        returnValue = new List<TargetDTOA>();
                        foreach (TargetEN entry in targetEN)
                                returnValue.Add (TargetAssembler.Convert (entry, session));
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
// [Route("{idTarget}", Name="GetOIDTarget")]

[Route ("~/api/Target/{idTarget}")]

public HttpResponseMessage ReadOID (int idTarget)
{
        // CAD, CEN, EN, returnValue
        TargetRESTCAD targetRESTCAD = null;
        TargetCEN targetCEN = null;
        TargetEN targetEN = null;
        TargetDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                targetRESTCAD = new TargetRESTCAD (session);
                targetCEN = new TargetCEN (targetRESTCAD);

                // Data
                targetEN = targetCEN.ReadOID (idTarget);

                // Convert return
                if (targetEN != null) {
                        returnValue = TargetAssembler.Convert (targetEN, session);
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


[Route ("~/api/Target/New_")]




public HttpResponseMessage New_ ( [FromBody] TargetDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        TargetRESTCAD targetRESTCAD = null;
        TargetCEN targetCEN = null;
        TargetDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                targetRESTCAD = new TargetRESTCAD (session);
                targetCEN = new TargetCEN (targetRESTCAD);

                // Create
                returnOID = targetCEN.New_ (

                        //Atributo OID: p_goal
                        // attr.estaRelacionado: true
                        dto.Goal_oid                 // association role

                        , dto.DesiredValue                                                                                                                                                       //Atributo Primitivo: p_desiredValue
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        , dto.DueDate                                                                                                                                                    //Atributo Primitivo: p_dueDate
                        );
                SessionCommit ();

                // Convert return
                returnValue = TargetAssembler.Convert (targetRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDTarget", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Target/Modify")]

public HttpResponseMessage Modify (int idTarget, [FromBody] TargetDTO dto)
{
        // CAD, CEN, returnValue
        TargetRESTCAD targetRESTCAD = null;
        TargetCEN targetCEN = null;
        TargetDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                targetRESTCAD = new TargetRESTCAD (session);
                targetCEN = new TargetCEN (targetRESTCAD);

                // Modify
                targetCEN.Modify (idTarget,
                        dto.DesiredValue
                        ,
                        dto.Description
                        ,
                        dto.DueDate
                        );

                // Return modified object
                returnValue = TargetAssembler.Convert (targetRESTCAD.ReadOIDDefault (idTarget), session);

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


[Route ("~/api/Target/Destroy")]

public HttpResponseMessage Destroy (int p_target_oid)
{
        // CAD, CEN
        TargetRESTCAD targetRESTCAD = null;
        TargetCEN targetCEN = null;

        try
        {
                SessionInitializeTransaction ();


                targetRESTCAD = new TargetRESTCAD (session);
                targetCEN = new TargetCEN (targetRESTCAD);

                targetCEN.Destroy (p_target_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_TargetControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
