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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_MedicationControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Medication")]
public class MedicationController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Medication/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        MedicationRESTCAD medicationRESTCAD = null;
        MedicationCEN medicationCEN = null;

        List<MedicationEN> medicationEN = null;
        List<MedicationDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                medicationRESTCAD = new MedicationRESTCAD (session);
                medicationCEN = new MedicationCEN (medicationRESTCAD);

                // Data
                // TODO: paginación

                medicationEN = medicationCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (medicationEN != null) {
                        returnValue = new List<MedicationDTOA>();
                        foreach (MedicationEN entry in medicationEN)
                                returnValue.Add (MedicationAssembler.Convert (entry, session));
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
// [Route("{idMedication}", Name="GetOIDMedication")]

[Route ("~/api/Medication/{idMedication}")]

public HttpResponseMessage ReadOID (int idMedication)
{
        // CAD, CEN, EN, returnValue
        MedicationRESTCAD medicationRESTCAD = null;
        MedicationCEN medicationCEN = null;
        MedicationEN medicationEN = null;
        MedicationDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                medicationRESTCAD = new MedicationRESTCAD (session);
                medicationCEN = new MedicationCEN (medicationRESTCAD);

                // Data
                medicationEN = medicationCEN.ReadOID (idMedication);

                // Convert return
                if (medicationEN != null) {
                        returnValue = MedicationAssembler.Convert (medicationEN, session);
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


[Route ("~/api/Medication/New_")]




public HttpResponseMessage New_ ( [FromBody] MedicationDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        MedicationRESTCAD medicationRESTCAD = null;
        MedicationCEN medicationCEN = null;
        MedicationDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                medicationRESTCAD = new MedicationRESTCAD (session);
                medicationCEN = new MedicationCEN (medicationRESTCAD);

                // Create
                returnOID = medicationCEN.New_ (

                        //Atributo OID: p_careActivity
                        // attr.estaRelacionado: true
                        dto.CareActivity_oid                 // association role

                        , dto.ProductReference                                                                                                                                                   //Atributo Primitivo: p_productReference
                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.Manufacturer                                                                                                                                                       //Atributo Primitivo: p_manufacturer
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        , dto.Dosage                                                                                                                                                     //Atributo Primitivo: p_dosage
                        , dto.Form                                                                                                                                                       //Atributo Primitivo: p_form
                        , dto.MedicationCode                                                                                                                                                     //Atributo Primitivo: p_medicationCode
                        );
                SessionCommit ();

                // Convert return
                returnValue = MedicationAssembler.Convert (medicationRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDMedication", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Medication/Modify")]

public HttpResponseMessage Modify (int idMedication, [FromBody] MedicationDTO dto)
{
        // CAD, CEN, returnValue
        MedicationRESTCAD medicationRESTCAD = null;
        MedicationCEN medicationCEN = null;
        MedicationDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                medicationRESTCAD = new MedicationRESTCAD (session);
                medicationCEN = new MedicationCEN (medicationRESTCAD);

                // Modify
                medicationCEN.Modify (idMedication,
                        dto.Name
                        ,
                        dto.Manufacturer
                        ,
                        dto.Description
                        ,
                        dto.Dosage
                        ,
                        dto.Form
                        ,
                        dto.MedicationCode
                        );

                // Return modified object
                returnValue = MedicationAssembler.Convert (medicationRESTCAD.ReadOIDDefault (idMedication), session);

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


[Route ("~/api/Medication/Destroy")]

public HttpResponseMessage Destroy (int p_medication_oid)
{
        // CAD, CEN
        MedicationRESTCAD medicationRESTCAD = null;
        MedicationCEN medicationCEN = null;

        try
        {
                SessionInitializeTransaction ();


                medicationRESTCAD = new MedicationRESTCAD (session);
                medicationCEN = new MedicationCEN (medicationRESTCAD);

                medicationCEN.Destroy (p_medication_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_MedicationControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
