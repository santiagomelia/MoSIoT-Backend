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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_PatientControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Patient")]
public class PatientController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Patient/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        PatientRESTCAD patientRESTCAD = null;
        PatientCEN patientCEN = null;

        List<PatientEN> patientEN = null;
        List<PatientDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                patientRESTCAD = new PatientRESTCAD (session);
                patientCEN = new PatientCEN (patientRESTCAD);

                // Data
                // TODO: paginación

                patientEN = patientCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (patientEN != null) {
                        returnValue = new List<PatientDTOA>();
                        foreach (PatientEN entry in patientEN)
                                returnValue.Add (PatientAssembler.Convert (entry, session));
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





[Route ("~/api/Patient/PatientScenario")]

public HttpResponseMessage PatientScenario (int idIoTScenario)
{
        // CAD, EN
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioEN ioTScenarioEN = null;

        // returnValue
        List<PatientEN> en = null;
        List<PatientDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);

                // Exists IoTScenario
                ioTScenarioEN = ioTScenarioRESTCAD.ReadOIDDefault (idIoTScenario);
                if (ioTScenarioEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IoTScenario#" + idIoTScenario + " not found"));

                // Rol
                // TODO: paginación


                en = ioTScenarioRESTCAD.PatientScenario (idIoTScenario).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<PatientDTOA>();
                        foreach (PatientEN entry in en)
                                returnValue.Add (PatientAssembler.Convert (entry, session));
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
// [Route("{idPatient}", Name="GetOIDPatient")]

[Route ("~/api/Patient/{idPatient}")]

public HttpResponseMessage ReadOID (int idPatient)
{
        // CAD, CEN, EN, returnValue
        PatientRESTCAD patientRESTCAD = null;
        PatientCEN patientCEN = null;
        PatientEN patientEN = null;
        PatientDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                patientRESTCAD = new PatientRESTCAD (session);
                patientCEN = new PatientCEN (patientRESTCAD);

                // Data
                patientEN = patientCEN.ReadOID (idPatient);

                // Convert return
                if (patientEN != null) {
                        returnValue = PatientAssembler.Convert (patientEN, session);
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


[Route ("~/api/Patient/New_")]




public HttpResponseMessage New_ ( [FromBody] PatientDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        PatientRESTCAD patientRESTCAD = null;
        PatientCEN patientCEN = null;
        PatientDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                patientRESTCAD = new PatientRESTCAD (session);
                patientCEN = new PatientCEN (patientRESTCAD);

                // Create
                returnOID = patientCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        ,
                        //Atributo OID: p_scenario
                        // attr.estaRelacionado: true
                        dto.Scenario_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_patientProfile
                        // attr.estaRelacionado: true
                        dto.PatientProfile_oid                 // association role

                        ,
                        //Atributo OID: p_userPatient
                        // attr.estaRelacionado: true
                        dto.UserPatient_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = PatientAssembler.Convert (patientRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDPatient", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Patient/Modify")]

public HttpResponseMessage Modify (int idPatient, [FromBody] PatientDTO dto)
{
        // CAD, CEN, returnValue
        PatientRESTCAD patientRESTCAD = null;
        PatientCEN patientCEN = null;
        PatientDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                patientRESTCAD = new PatientRESTCAD (session);
                patientCEN = new PatientCEN (patientRESTCAD);

                // Modify
                patientCEN.Modify (idPatient,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = PatientAssembler.Convert (patientRESTCAD.ReadOIDDefault (idPatient), session);

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


[Route ("~/api/Patient/Destroy")]

public HttpResponseMessage Destroy (int p_patient_oid)
{
        // CAD, CEN
        PatientRESTCAD patientRESTCAD = null;
        PatientCEN patientCEN = null;

        try
        {
                SessionInitializeTransaction ();


                patientRESTCAD = new PatientRESTCAD (session);
                patientCEN = new PatientCEN (patientRESTCAD);

                patientCEN.Destroy (p_patient_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_PatientControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
