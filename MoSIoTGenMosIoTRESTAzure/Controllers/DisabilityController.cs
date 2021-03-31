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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_DisabilityControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Disability")]
public class DisabilityController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Disability/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        DisabilityRESTCAD disabilityRESTCAD = null;
        DisabilityCEN disabilityCEN = null;

        List<DisabilityEN> disabilityEN = null;
        List<DisabilityDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                disabilityRESTCAD = new DisabilityRESTCAD (session);
                disabilityCEN = new DisabilityCEN (disabilityRESTCAD);

                // Data
                // TODO: paginación

                disabilityEN = disabilityCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (disabilityEN != null) {
                        returnValue = new List<DisabilityDTOA>();
                        foreach (DisabilityEN entry in disabilityEN)
                                returnValue.Add (DisabilityAssembler.Convert (entry, session));
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





[Route ("~/api/Disability/GetAllDisabilityOfPatient")]

public HttpResponseMessage GetAllDisabilityOfPatient (int idPatientProfile)
{
        // CAD, EN
        PatientProfileRESTCAD patientProfileRESTCAD = null;
        PatientProfileEN patientProfileEN = null;

        // returnValue
        List<DisabilityEN> en = null;
        List<DisabilityDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                patientProfileRESTCAD = new PatientProfileRESTCAD (session);

                // Exists PatientProfile
                patientProfileEN = patientProfileRESTCAD.ReadOIDDefault (idPatientProfile);
                if (patientProfileEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "PatientProfile#" + idPatientProfile + " not found"));

                // Rol
                // TODO: paginación


                en = patientProfileRESTCAD.GetAllDisabilityOfPatient (idPatientProfile).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<DisabilityDTOA>();
                        foreach (DisabilityEN entry in en)
                                returnValue.Add (DisabilityAssembler.Convert (entry, session));
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
// [Route("{idDisability}", Name="GetOIDDisability")]

[Route ("~/api/Disability/{idDisability}")]

public HttpResponseMessage ReadOID (int idDisability)
{
        // CAD, CEN, EN, returnValue
        DisabilityRESTCAD disabilityRESTCAD = null;
        DisabilityCEN disabilityCEN = null;
        DisabilityEN disabilityEN = null;
        DisabilityDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                disabilityRESTCAD = new DisabilityRESTCAD (session);
                disabilityCEN = new DisabilityCEN (disabilityRESTCAD);

                // Data
                disabilityEN = disabilityCEN.ReadOID (idDisability);

                // Convert return
                if (disabilityEN != null) {
                        returnValue = DisabilityAssembler.Convert (disabilityEN, session);
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


[Route ("~/api/Disability/New_")]




public HttpResponseMessage New_ ( [FromBody] DisabilityDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        DisabilityRESTCAD disabilityRESTCAD = null;
        DisabilityCEN disabilityCEN = null;
        DisabilityDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                disabilityRESTCAD = new DisabilityRESTCAD (session);
                disabilityCEN = new DisabilityCEN (disabilityRESTCAD);

                // Create
                returnOID = disabilityCEN.New_ (

                        //Atributo OID: p_patient
                        // attr.estaRelacionado: true
                        dto.Patient_oid                 // association role

                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.Type                                                                                                                                                       //Atributo Primitivo: p_type
                        , dto.Severity                                                                                                                                                   //Atributo Primitivo: p_severity
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = DisabilityAssembler.Convert (disabilityRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDDisability", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Disability/Modify")]

public HttpResponseMessage Modify (int idDisability, [FromBody] DisabilityDTO dto)
{
        // CAD, CEN, returnValue
        DisabilityRESTCAD disabilityRESTCAD = null;
        DisabilityCEN disabilityCEN = null;
        DisabilityDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                disabilityRESTCAD = new DisabilityRESTCAD (session);
                disabilityCEN = new DisabilityCEN (disabilityRESTCAD);

                // Modify
                disabilityCEN.Modify (idDisability,
                        dto.Name
                        ,
                        dto.Type
                        ,
                        dto.Severity
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = DisabilityAssembler.Convert (disabilityRESTCAD.ReadOIDDefault (idDisability), session);

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


[Route ("~/api/Disability/Destroy")]

public HttpResponseMessage Destroy (int p_disability_oid)
{
        // CAD, CEN
        DisabilityRESTCAD disabilityRESTCAD = null;
        DisabilityCEN disabilityCEN = null;

        try
        {
                SessionInitializeTransaction ();


                disabilityRESTCAD = new DisabilityRESTCAD (session);
                disabilityCEN = new DisabilityCEN (disabilityRESTCAD);

                disabilityCEN.Destroy (p_disability_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_DisabilityControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
