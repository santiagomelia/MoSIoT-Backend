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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMDisabilityControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMDisability")]
public class IMDisabilityController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMDisability/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMDisabilityRESTCAD iMDisabilityRESTCAD = null;
        IMDisabilityCEN iMDisabilityCEN = null;

        List<IMDisabilityEN> iMDisabilityEN = null;
        List<IMDisabilityDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMDisabilityRESTCAD = new IMDisabilityRESTCAD (session);
                iMDisabilityCEN = new IMDisabilityCEN (iMDisabilityRESTCAD);

                // Data
                // TODO: paginación

                iMDisabilityEN = iMDisabilityCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMDisabilityEN != null) {
                        returnValue = new List<IMDisabilityDTOA>();
                        foreach (IMDisabilityEN entry in iMDisabilityEN)
                                returnValue.Add (IMDisabilityAssembler.Convert (entry, session));
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





[Route ("~/api/IMDisability/PatientDisabilities")]

public HttpResponseMessage PatientDisabilities (int idPatient)
{
        // CAD, EN
        PatientRESTCAD patientRESTCAD = null;
        PatientEN patientEN = null;

        // returnValue
        List<IMDisabilityEN> en = null;
        List<IMDisabilityDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                patientRESTCAD = new PatientRESTCAD (session);

                // Exists Patient
                patientEN = patientRESTCAD.ReadOIDDefault (idPatient);
                if (patientEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "Patient#" + idPatient + " not found"));

                // Rol
                // TODO: paginación


                en = patientRESTCAD.PatientDisabilities (idPatient).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<IMDisabilityDTOA>();
                        foreach (IMDisabilityEN entry in en)
                                returnValue.Add (IMDisabilityAssembler.Convert (entry, session));
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
// [Route("{idIMDisability}", Name="GetOIDIMDisability")]

[Route ("~/api/IMDisability/{idIMDisability}")]

public HttpResponseMessage ReadOID (int idIMDisability)
{
        // CAD, CEN, EN, returnValue
        IMDisabilityRESTCAD iMDisabilityRESTCAD = null;
        IMDisabilityCEN iMDisabilityCEN = null;
        IMDisabilityEN iMDisabilityEN = null;
        IMDisabilityDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMDisabilityRESTCAD = new IMDisabilityRESTCAD (session);
                iMDisabilityCEN = new IMDisabilityCEN (iMDisabilityRESTCAD);

                // Data
                iMDisabilityEN = iMDisabilityCEN.ReadOID (idIMDisability);

                // Convert return
                if (iMDisabilityEN != null) {
                        returnValue = IMDisabilityAssembler.Convert (iMDisabilityEN, session);
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


[Route ("~/api/IMDisability/New_")]




public HttpResponseMessage New_ ( [FromBody] IMDisabilityDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMDisabilityRESTCAD iMDisabilityRESTCAD = null;
        IMDisabilityCEN iMDisabilityCEN = null;
        IMDisabilityDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMDisabilityRESTCAD = new IMDisabilityRESTCAD (session);
                iMDisabilityCEN = new IMDisabilityCEN (iMDisabilityRESTCAD);

                // Create
                returnOID = iMDisabilityCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_entity
                        // attr.estaRelacionado: true
                        dto.Entity_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMDisabilityAssembler.Convert (iMDisabilityRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMDisability", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMDisability/Modify")]

public HttpResponseMessage Modify (int idIMDisability, [FromBody] IMDisabilityDTO dto)
{
        // CAD, CEN, returnValue
        IMDisabilityRESTCAD iMDisabilityRESTCAD = null;
        IMDisabilityCEN iMDisabilityCEN = null;
        IMDisabilityDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMDisabilityRESTCAD = new IMDisabilityRESTCAD (session);
                iMDisabilityCEN = new IMDisabilityCEN (iMDisabilityRESTCAD);

                // Modify
                iMDisabilityCEN.Modify (idIMDisability,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IMDisabilityAssembler.Convert (iMDisabilityRESTCAD.ReadOIDDefault (idIMDisability), session);

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


[Route ("~/api/IMDisability/Destroy")]

public HttpResponseMessage Destroy (int p_imdisability_oid)
{
        // CAD, CEN
        IMDisabilityRESTCAD iMDisabilityRESTCAD = null;
        IMDisabilityCEN iMDisabilityCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMDisabilityRESTCAD = new IMDisabilityRESTCAD (session);
                iMDisabilityCEN = new IMDisabilityCEN (iMDisabilityRESTCAD);

                iMDisabilityCEN.Destroy (p_imdisability_oid);
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


[Route ("~/api/IMDisability/AssignDisability")]

public HttpResponseMessage AssignDisability (int p_imdisability_oid, int p_disability_oid)
{
        // CAD, CEN, returnValue
        IMDisabilityRESTCAD iMDisabilityRESTCAD = null;
        IMDisabilityCEN iMDisabilityCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMDisabilityRESTCAD = new IMDisabilityRESTCAD (session);
                iMDisabilityCEN = new IMDisabilityCEN (iMDisabilityRESTCAD);

                // Relationer
                iMDisabilityCEN.AssignDisability (p_imdisability_oid, p_disability_oid);
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







/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMDisabilityControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
