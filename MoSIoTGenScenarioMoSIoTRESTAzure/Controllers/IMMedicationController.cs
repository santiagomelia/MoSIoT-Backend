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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMMedicationControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMMedication")]
public class IMMedicationController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMMedication/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMMedicationRESTCAD iMMedicationRESTCAD = null;
        IMMedicationCEN iMMedicationCEN = null;

        List<IMMedicationEN> iMMedicationEN = null;
        List<IMMedicationDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMMedicationRESTCAD = new IMMedicationRESTCAD (session);
                iMMedicationCEN = new IMMedicationCEN (iMMedicationRESTCAD);

                // Data
                // TODO: paginación

                iMMedicationEN = iMMedicationCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMMedicationEN != null) {
                        returnValue = new List<IMMedicationDTOA>();
                        foreach (IMMedicationEN entry in iMMedicationEN)
                                returnValue.Add (IMMedicationAssembler.Convert (entry, session));
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





[Route ("~/api/IMMedication/MedicationCareActivity")]

public HttpResponseMessage MedicationCareActivity (int idIMCareActivity)
{
        // CAD, EN
        IMCareActivityRESTCAD iMCareActivityRESTCAD = null;
        IMCareActivityEN iMCareActivityEN = null;

        // returnValue
        List<IMMedicationEN> en = null;
        List<IMMedicationDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMCareActivityRESTCAD = new IMCareActivityRESTCAD (session);

                // Exists IMCareActivity
                iMCareActivityEN = iMCareActivityRESTCAD.ReadOIDDefault (idIMCareActivity);
                if (iMCareActivityEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IMCareActivity#" + idIMCareActivity + " not found"));

                // Rol
                // TODO: paginación


                en = iMCareActivityRESTCAD.MedicationCareActivity (idIMCareActivity).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<IMMedicationDTOA>();
                        foreach (IMMedicationEN entry in en)
                                returnValue.Add (IMMedicationAssembler.Convert (entry, session));
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
// [Route("{idIMMedication}", Name="GetOIDIMMedication")]

[Route ("~/api/IMMedication/{idIMMedication}")]

public HttpResponseMessage ReadOID (int idIMMedication)
{
        // CAD, CEN, EN, returnValue
        IMMedicationRESTCAD iMMedicationRESTCAD = null;
        IMMedicationCEN iMMedicationCEN = null;
        IMMedicationEN iMMedicationEN = null;
        IMMedicationDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMMedicationRESTCAD = new IMMedicationRESTCAD (session);
                iMMedicationCEN = new IMMedicationCEN (iMMedicationRESTCAD);

                // Data
                iMMedicationEN = iMMedicationCEN.ReadOID (idIMMedication);

                // Convert return
                if (iMMedicationEN != null) {
                        returnValue = IMMedicationAssembler.Convert (iMMedicationEN, session);
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


[Route ("~/api/IMMedication/New_")]




public HttpResponseMessage New_ ( [FromBody] IMMedicationDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMMedicationRESTCAD iMMedicationRESTCAD = null;
        IMMedicationCEN iMMedicationCEN = null;
        IMMedicationDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMMedicationRESTCAD = new IMMedicationRESTCAD (session);
                iMMedicationCEN = new IMMedicationCEN (iMMedicationRESTCAD);

                // Create
                returnOID = iMMedicationCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_entity
                        // attr.estaRelacionado: true
                        dto.Entity_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMMedicationAssembler.Convert (iMMedicationRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMMedication", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMMedication/Modify")]

public HttpResponseMessage Modify (int idIMMedication, [FromBody] IMMedicationDTO dto)
{
        // CAD, CEN, returnValue
        IMMedicationRESTCAD iMMedicationRESTCAD = null;
        IMMedicationCEN iMMedicationCEN = null;
        IMMedicationDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMMedicationRESTCAD = new IMMedicationRESTCAD (session);
                iMMedicationCEN = new IMMedicationCEN (iMMedicationRESTCAD);

                // Modify
                iMMedicationCEN.Modify (idIMMedication,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IMMedicationAssembler.Convert (iMMedicationRESTCAD.ReadOIDDefault (idIMMedication), session);

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


[Route ("~/api/IMMedication/Destroy")]

public HttpResponseMessage Destroy (int p_immedication_oid)
{
        // CAD, CEN
        IMMedicationRESTCAD iMMedicationRESTCAD = null;
        IMMedicationCEN iMMedicationCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMMedicationRESTCAD = new IMMedicationRESTCAD (session);
                iMMedicationCEN = new IMMedicationCEN (iMMedicationRESTCAD);

                iMMedicationCEN.Destroy (p_immedication_oid);
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


[Route ("~/api/IMMedication/AssignMedication")]

public HttpResponseMessage AssignMedication (int p_immedication_oid, int p_medication_oid)
{
        // CAD, CEN, returnValue
        IMMedicationRESTCAD iMMedicationRESTCAD = null;
        IMMedicationCEN iMMedicationCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMMedicationRESTCAD = new IMMedicationRESTCAD (session);
                iMMedicationCEN = new IMMedicationCEN (iMMedicationRESTCAD);

                // Relationer
                iMMedicationCEN.AssignMedication (p_immedication_oid, p_medication_oid);
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







/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMMedicationControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
