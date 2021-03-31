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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_PatientProfileControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/PatientProfile")]
public class PatientProfileController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/PatientProfile/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        PatientProfileRESTCAD patientProfileRESTCAD = null;
        PatientProfileCEN patientProfileCEN = null;

        List<PatientProfileEN> patientProfileEN = null;
        List<PatientProfileDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                patientProfileRESTCAD = new PatientProfileRESTCAD (session);
                patientProfileCEN = new PatientProfileCEN (patientProfileRESTCAD);

                // Data
                // TODO: paginación

                patientProfileEN = patientProfileCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (patientProfileEN != null) {
                        returnValue = new List<PatientProfileDTOA>();
                        foreach (PatientProfileEN entry in patientProfileEN)
                                returnValue.Add (PatientProfileAssembler.Convert (entry, session));
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
// [Route("{idPatientProfile}", Name="GetOIDPatientProfile")]

[Route ("~/api/PatientProfile/{idPatientProfile}")]

public HttpResponseMessage ReadOID (int idPatientProfile)
{
        // CAD, CEN, EN, returnValue
        PatientProfileRESTCAD patientProfileRESTCAD = null;
        PatientProfileCEN patientProfileCEN = null;
        PatientProfileEN patientProfileEN = null;
        PatientProfileDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                patientProfileRESTCAD = new PatientProfileRESTCAD (session);
                patientProfileCEN = new PatientProfileCEN (patientProfileRESTCAD);

                // Data
                patientProfileEN = patientProfileCEN.ReadOID (idPatientProfile);

                // Convert return
                if (patientProfileEN != null) {
                        returnValue = PatientProfileAssembler.Convert (patientProfileEN, session);
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


[Route ("~/api/PatientProfile/New_")]




public HttpResponseMessage New_ ( [FromBody] PatientProfileDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        PatientProfileRESTCAD patientProfileRESTCAD = null;
        PatientProfileCEN patientProfileCEN = null;
        PatientProfileDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                patientProfileRESTCAD = new PatientProfileRESTCAD (session);
                patientProfileCEN = new PatientProfileCEN (patientProfileRESTCAD);

                // Create
                returnOID = patientProfileCEN.New_ (
                        dto.PreferredLanguage                                                                            //Atributo Primitivo: p_preferredLanguage
                        , dto.Region                                                                                                                                                     //Atributo Primitivo: p_region
                        , dto.HazardAvoidance                                                                                                                                                    //Atributo Primitivo: p_hazardAvoidance
                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = PatientProfileAssembler.Convert (patientProfileRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDPatientProfile", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}




[HttpPut]


[Route ("~/api/PatientProfile/Modify")]

public HttpResponseMessage Modify (int idPatientProfile, [FromBody] PatientProfileDTO dto)
{
        // CAD, CEN, returnValue
        PatientProfileRESTCAD patientProfileRESTCAD = null;
        PatientProfileCEN patientProfileCEN = null;
        PatientProfileDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                patientProfileRESTCAD = new PatientProfileRESTCAD (session);
                patientProfileCEN = new PatientProfileCEN (patientProfileRESTCAD);

                // Modify
                patientProfileCEN.Modify (idPatientProfile,
                        dto.PreferredLanguage
                        ,
                        dto.Region
                        ,
                        dto.HazardAvoidance
                        ,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = PatientProfileAssembler.Convert (patientProfileRESTCAD.ReadOIDDefault (idPatientProfile), session);

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


[Route ("~/api/PatientProfile/Destroy")]

public HttpResponseMessage Destroy (int p_patientprofile_oid)
{
        // CAD, CEN
        PatientProfileRESTCAD patientProfileRESTCAD = null;
        PatientProfileCEN patientProfileCEN = null;

        try
        {
                SessionInitializeTransaction ();


                patientProfileRESTCAD = new PatientProfileRESTCAD (session);
                patientProfileCEN = new PatientProfileCEN (patientProfileRESTCAD);

                patientProfileCEN.Destroy (p_patientprofile_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_PatientProfileControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
