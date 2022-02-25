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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_PatientAccessControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/PatientAccess")]
public class PatientAccessController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/PatientAccess/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        PatientAccessRESTCAD patientAccessRESTCAD = null;
        PatientAccessCEN patientAccessCEN = null;

        List<PatientAccessEN> patientAccessEN = null;
        List<PatientAccessDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                patientAccessRESTCAD = new PatientAccessRESTCAD (session);
                patientAccessCEN = new PatientAccessCEN (patientAccessRESTCAD);

                // Data
                // TODO: paginación

                patientAccessEN = patientAccessCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (patientAccessEN != null) {
                        returnValue = new List<PatientAccessDTOA>();
                        foreach (PatientAccessEN entry in patientAccessEN)
                                returnValue.Add (PatientAccessAssembler.Convert (entry, session));
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





[Route ("~/api/PatientAccess/PatientAccessScenario")]

public HttpResponseMessage PatientAccessScenario (int idIoTScenario)
{
        // CAD, EN
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioEN ioTScenarioEN = null;

        // returnValue
        List<PatientAccessEN> en = null;
        List<PatientAccessDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);

                // Exists IoTScenario
                ioTScenarioEN = ioTScenarioRESTCAD.ReadOIDDefault (idIoTScenario);
                if (ioTScenarioEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IoTScenario#" + idIoTScenario + " not found"));

                // Rol
                // TODO: paginación


                en = ioTScenarioRESTCAD.PatientAccessScenario (idIoTScenario).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<PatientAccessDTOA>();
                        foreach (PatientAccessEN entry in en)
                                returnValue.Add (PatientAccessAssembler.Convert (entry, session));
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
// [Route("{idPatientAccess}", Name="GetOIDPatientAccess")]

[Route ("~/api/PatientAccess/{idPatientAccess}")]

public HttpResponseMessage ReadOID (int idPatientAccess)
{
        // CAD, CEN, EN, returnValue
        PatientAccessRESTCAD patientAccessRESTCAD = null;
        PatientAccessCEN patientAccessCEN = null;
        PatientAccessEN patientAccessEN = null;
        PatientAccessDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                patientAccessRESTCAD = new PatientAccessRESTCAD (session);
                patientAccessCEN = new PatientAccessCEN (patientAccessRESTCAD);

                // Data
                patientAccessEN = patientAccessCEN.ReadOID (idPatientAccess);

                // Convert return
                if (patientAccessEN != null) {
                        returnValue = PatientAccessAssembler.Convert (patientAccessEN, session);
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


[Route ("~/api/PatientAccess/New_")]




public HttpResponseMessage New_ ( [FromBody] PatientAccessDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        PatientAccessRESTCAD patientAccessRESTCAD = null;
        PatientAccessCEN patientAccessCEN = null;
        PatientAccessDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                patientAccessRESTCAD = new PatientAccessRESTCAD (session);
                patientAccessCEN = new PatientAccessCEN (patientAccessRESTCAD);

                // Create
                returnOID = patientAccessCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        ,
                        //Atributo OID: p_scenario
                        // attr.estaRelacionado: true
                        dto.Scenario_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = PatientAccessAssembler.Convert (patientAccessRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDPatientAccess", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/PatientAccess/Modify")]

public HttpResponseMessage Modify (int idPatientAccess, [FromBody] PatientAccessDTO dto)
{
        // CAD, CEN, returnValue
        PatientAccessRESTCAD patientAccessRESTCAD = null;
        PatientAccessCEN patientAccessCEN = null;
        PatientAccessDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                patientAccessRESTCAD = new PatientAccessRESTCAD (session);
                patientAccessCEN = new PatientAccessCEN (patientAccessRESTCAD);

                // Modify
                patientAccessCEN.Modify (idPatientAccess,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = PatientAccessAssembler.Convert (patientAccessRESTCAD.ReadOIDDefault (idPatientAccess), session);

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


[Route ("~/api/PatientAccess/Destroy")]

public HttpResponseMessage Destroy (int p_patientaccess_oid)
{
        // CAD, CEN
        PatientAccessRESTCAD patientAccessRESTCAD = null;
        PatientAccessCEN patientAccessCEN = null;

        try
        {
                SessionInitializeTransaction ();


                patientAccessRESTCAD = new PatientAccessRESTCAD (session);
                patientAccessCEN = new PatientAccessCEN (patientAccessRESTCAD);

                patientAccessCEN.Destroy (p_patientaccess_oid);
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


[Route ("~/api/PatientAccess/AssignAccessMode")]

public HttpResponseMessage AssignAccessMode (int p_patientaccess_oid, int p_accessmode_oid)
{
        // CAD, CEN, returnValue
        PatientAccessRESTCAD patientAccessRESTCAD = null;
        PatientAccessCEN patientAccessCEN = null;

        try
        {
                SessionInitializeTransaction ();


                patientAccessRESTCAD = new PatientAccessRESTCAD (session);
                patientAccessCEN = new PatientAccessCEN (patientAccessRESTCAD);

                // Relationer
                patientAccessCEN.AssignAccessMode (p_patientaccess_oid, p_accessmode_oid);
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







/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_PatientAccessControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
