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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMTargetControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMTarget")]
public class IMTargetController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMTarget/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMTargetRESTCAD iMTargetRESTCAD = null;
        IMTargetCEN iMTargetCEN = null;

        List<IMTargetEN> iMTargetEN = null;
        List<IMTargetDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMTargetRESTCAD = new IMTargetRESTCAD (session);
                iMTargetCEN = new IMTargetCEN (iMTargetRESTCAD);

                // Data
                // TODO: paginación

                iMTargetEN = iMTargetCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMTargetEN != null) {
                        returnValue = new List<IMTargetDTOA>();
                        foreach (IMTargetEN entry in iMTargetEN)
                                returnValue.Add (IMTargetAssembler.Convert (entry, session));
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





[Route ("~/api/IMTarget/TargetsCarePlan")]

public HttpResponseMessage TargetsCarePlan (int idCarePlan)
{
        // CAD, EN
        CarePlanRESTCAD carePlanRESTCAD = null;
        CarePlanEN carePlanEN = null;

        // returnValue
        List<IMTargetEN> en = null;
        List<IMTargetDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                carePlanRESTCAD = new CarePlanRESTCAD (session);

                // Exists CarePlan
                carePlanEN = carePlanRESTCAD.ReadOIDDefault (idCarePlan);
                if (carePlanEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "CarePlan#" + idCarePlan + " not found"));

                // Rol
                // TODO: paginación


                en = carePlanRESTCAD.TargetsCarePlan (idCarePlan).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<IMTargetDTOA>();
                        foreach (IMTargetEN entry in en)
                                returnValue.Add (IMTargetAssembler.Convert (entry, session));
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
// [Route("{idIMTarget}", Name="GetOIDIMTarget")]

[Route ("~/api/IMTarget/{idIMTarget}")]

public HttpResponseMessage ReadOID (int idIMTarget)
{
        // CAD, CEN, EN, returnValue
        IMTargetRESTCAD iMTargetRESTCAD = null;
        IMTargetCEN iMTargetCEN = null;
        IMTargetEN iMTargetEN = null;
        IMTargetDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMTargetRESTCAD = new IMTargetRESTCAD (session);
                iMTargetCEN = new IMTargetCEN (iMTargetRESTCAD);

                // Data
                iMTargetEN = iMTargetCEN.ReadOID (idIMTarget);

                // Convert return
                if (iMTargetEN != null) {
                        returnValue = IMTargetAssembler.Convert (iMTargetEN, session);
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


[Route ("~/api/IMTarget/New_")]




public HttpResponseMessage New_ ( [FromBody] IMTargetDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMTargetRESTCAD iMTargetRESTCAD = null;
        IMTargetCEN iMTargetCEN = null;
        IMTargetDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMTargetRESTCAD = new IMTargetRESTCAD (session);
                iMTargetCEN = new IMTargetCEN (iMTargetRESTCAD);

                // Create
                returnOID = iMTargetCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_entity
                        // attr.estaRelacionado: true
                        dto.Entity_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMTargetAssembler.Convert (iMTargetRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMTarget", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMTarget/Modify")]

public HttpResponseMessage Modify (int idIMTarget, [FromBody] IMTargetDTO dto)
{
        // CAD, CEN, returnValue
        IMTargetRESTCAD iMTargetRESTCAD = null;
        IMTargetCEN iMTargetCEN = null;
        IMTargetDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMTargetRESTCAD = new IMTargetRESTCAD (session);
                iMTargetCEN = new IMTargetCEN (iMTargetRESTCAD);

                // Modify
                iMTargetCEN.Modify (idIMTarget,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IMTargetAssembler.Convert (iMTargetRESTCAD.ReadOIDDefault (idIMTarget), session);

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


[Route ("~/api/IMTarget/Destroy")]

public HttpResponseMessage Destroy (int p_imtarget_oid)
{
        // CAD, CEN
        IMTargetRESTCAD iMTargetRESTCAD = null;
        IMTargetCEN iMTargetCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMTargetRESTCAD = new IMTargetRESTCAD (session);
                iMTargetCEN = new IMTargetCEN (iMTargetRESTCAD);

                iMTargetCEN.Destroy (p_imtarget_oid);
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


[Route ("~/api/IMTarget/AssignTarget")]

public HttpResponseMessage AssignTarget (int p_imtarget_oid, int p_target_oid)
{
        // CAD, CEN, returnValue
        IMTargetRESTCAD iMTargetRESTCAD = null;
        IMTargetCEN iMTargetCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMTargetRESTCAD = new IMTargetRESTCAD (session);
                iMTargetCEN = new IMTargetCEN (iMTargetRESTCAD);

                // Relationer
                iMTargetCEN.AssignTarget (p_imtarget_oid, p_target_oid);
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







/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMTargetControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
