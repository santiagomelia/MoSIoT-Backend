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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMCareActivityControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMCareActivity")]
public class IMCareActivityController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMCareActivity/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMCareActivityRESTCAD iMCareActivityRESTCAD = null;
        IMCareActivityCEN iMCareActivityCEN = null;

        List<IMCareActivityEN> iMCareActivityEN = null;
        List<IMCareActivityDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMCareActivityRESTCAD = new IMCareActivityRESTCAD (session);
                iMCareActivityCEN = new IMCareActivityCEN (iMCareActivityRESTCAD);

                // Data
                // TODO: paginación

                iMCareActivityEN = iMCareActivityCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMCareActivityEN != null) {
                        returnValue = new List<IMCareActivityDTOA>();
                        foreach (IMCareActivityEN entry in iMCareActivityEN)
                                returnValue.Add (IMCareActivityAssembler.Convert (entry, session));
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





[Route ("~/api/IMCareActivity/CareActivitiesScenario")]

public HttpResponseMessage CareActivitiesScenario (int idIoTScenario)
{
        // CAD, EN
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioEN ioTScenarioEN = null;

        // returnValue
        List<IMCareActivityEN> en = null;
        List<IMCareActivityDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);

                // Exists IoTScenario
                ioTScenarioEN = ioTScenarioRESTCAD.ReadOIDDefault (idIoTScenario);
                if (ioTScenarioEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IoTScenario#" + idIoTScenario + " not found"));

                // Rol
                // TODO: paginación


                en = ioTScenarioRESTCAD.CareActivitiesScenario (idIoTScenario).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<IMCareActivityDTOA>();
                        foreach (IMCareActivityEN entry in en)
                                returnValue.Add (IMCareActivityAssembler.Convert (entry, session));
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
// [Route("{idIMCareActivity}", Name="GetOIDIMCareActivity")]

[Route ("~/api/IMCareActivity/{idIMCareActivity}")]

public HttpResponseMessage ReadOID (int idIMCareActivity)
{
        // CAD, CEN, EN, returnValue
        IMCareActivityRESTCAD iMCareActivityRESTCAD = null;
        IMCareActivityCEN iMCareActivityCEN = null;
        IMCareActivityEN iMCareActivityEN = null;
        IMCareActivityDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMCareActivityRESTCAD = new IMCareActivityRESTCAD (session);
                iMCareActivityCEN = new IMCareActivityCEN (iMCareActivityRESTCAD);

                // Data
                iMCareActivityEN = iMCareActivityCEN.ReadOID (idIMCareActivity);

                // Convert return
                if (iMCareActivityEN != null) {
                        returnValue = IMCareActivityAssembler.Convert (iMCareActivityEN, session);
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


[Route ("~/api/IMCareActivity/New_")]




public HttpResponseMessage New_ ( [FromBody] IMCareActivityDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMCareActivityRESTCAD iMCareActivityRESTCAD = null;
        IMCareActivityCEN iMCareActivityCEN = null;
        IMCareActivityDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMCareActivityRESTCAD = new IMCareActivityRESTCAD (session);
                iMCareActivityCEN = new IMCareActivityCEN (iMCareActivityRESTCAD);

                // Create
                returnOID = iMCareActivityCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        ,
                        //Atributo OID: p_scenario
                        // attr.estaRelacionado: true
                        dto.Scenario_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = IMCareActivityAssembler.Convert (iMCareActivityRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMCareActivity", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMCareActivity/Modify")]

public HttpResponseMessage Modify (int idIMCareActivity, [FromBody] IMCareActivityDTO dto)
{
        // CAD, CEN, returnValue
        IMCareActivityRESTCAD iMCareActivityRESTCAD = null;
        IMCareActivityCEN iMCareActivityCEN = null;
        IMCareActivityDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMCareActivityRESTCAD = new IMCareActivityRESTCAD (session);
                iMCareActivityCEN = new IMCareActivityCEN (iMCareActivityRESTCAD);

                // Modify
                iMCareActivityCEN.Modify (idIMCareActivity,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IMCareActivityAssembler.Convert (iMCareActivityRESTCAD.ReadOIDDefault (idIMCareActivity), session);

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


[Route ("~/api/IMCareActivity/Destroy")]

public HttpResponseMessage Destroy (int p_imcareactivity_oid)
{
        // CAD, CEN
        IMCareActivityRESTCAD iMCareActivityRESTCAD = null;
        IMCareActivityCEN iMCareActivityCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMCareActivityRESTCAD = new IMCareActivityRESTCAD (session);
                iMCareActivityCEN = new IMCareActivityCEN (iMCareActivityRESTCAD);

                iMCareActivityCEN.Destroy (p_imcareactivity_oid);
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


[Route ("~/api/IMCareActivity/AssignCareActivity")]

public HttpResponseMessage AssignCareActivity (int p_imcareactivity_oid, int p_careactivity_oid)
{
        // CAD, CEN, returnValue
        IMCareActivityRESTCAD iMCareActivityRESTCAD = null;
        IMCareActivityCEN iMCareActivityCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMCareActivityRESTCAD = new IMCareActivityRESTCAD (session);
                iMCareActivityCEN = new IMCareActivityCEN (iMCareActivityRESTCAD);

                // Relationer
                iMCareActivityCEN.AssignCareActivity (p_imcareactivity_oid, p_careactivity_oid);
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







/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMCareActivityControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
