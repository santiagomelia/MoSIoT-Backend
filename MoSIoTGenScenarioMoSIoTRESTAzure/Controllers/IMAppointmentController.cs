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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMAppointmentControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMAppointment")]
public class IMAppointmentController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMAppointment/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMAppointmentRESTCAD iMAppointmentRESTCAD = null;
        IMAppointmentCEN iMAppointmentCEN = null;

        List<IMAppointmentEN> iMAppointmentEN = null;
        List<IMAppointmentDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMAppointmentRESTCAD = new IMAppointmentRESTCAD (session);
                iMAppointmentCEN = new IMAppointmentCEN (iMAppointmentRESTCAD);

                // Data
                // TODO: paginación

                iMAppointmentEN = iMAppointmentCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMAppointmentEN != null) {
                        returnValue = new List<IMAppointmentDTOA>();
                        foreach (IMAppointmentEN entry in iMAppointmentEN)
                                returnValue.Add (IMAppointmentAssembler.Convert (entry, session));
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
// [Route("{idIMAppointment}", Name="GetOIDIMAppointment")]

[Route ("~/api/IMAppointment/{idIMAppointment}")]

public HttpResponseMessage ReadOID (int idIMAppointment)
{
        // CAD, CEN, EN, returnValue
        IMAppointmentRESTCAD iMAppointmentRESTCAD = null;
        IMAppointmentCEN iMAppointmentCEN = null;
        IMAppointmentEN iMAppointmentEN = null;
        IMAppointmentDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMAppointmentRESTCAD = new IMAppointmentRESTCAD (session);
                iMAppointmentCEN = new IMAppointmentCEN (iMAppointmentRESTCAD);

                // Data
                iMAppointmentEN = iMAppointmentCEN.ReadOID (idIMAppointment);

                // Convert return
                if (iMAppointmentEN != null) {
                        returnValue = IMAppointmentAssembler.Convert (iMAppointmentEN, session);
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


[Route ("~/api/IMAppointment/New_")]




public HttpResponseMessage New_ ( [FromBody] IMAppointmentDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMAppointmentRESTCAD iMAppointmentRESTCAD = null;
        IMAppointmentCEN iMAppointmentCEN = null;
        IMAppointmentDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMAppointmentRESTCAD = new IMAppointmentRESTCAD (session);
                iMAppointmentCEN = new IMAppointmentCEN (iMAppointmentRESTCAD);

                // Create
                returnOID = iMAppointmentCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        ,
                        //Atributo OID: p_scenario
                        // attr.estaRelacionado: true
                        dto.Scenario_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        , dto.Date                                                                                                                                                       //Atributo Primitivo: p_date
                        ,
                        //Atributo OID: p_appointment
                        // attr.estaRelacionado: true
                        dto.Appointment_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMAppointmentAssembler.Convert (iMAppointmentRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMAppointment", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMAppointment/Modify")]

public HttpResponseMessage Modify (int idIMAppointment, [FromBody] IMAppointmentDTO dto)
{
        // CAD, CEN, returnValue
        IMAppointmentRESTCAD iMAppointmentRESTCAD = null;
        IMAppointmentCEN iMAppointmentCEN = null;
        IMAppointmentDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMAppointmentRESTCAD = new IMAppointmentRESTCAD (session);
                iMAppointmentCEN = new IMAppointmentCEN (iMAppointmentRESTCAD);

                // Modify
                iMAppointmentCEN.Modify (idIMAppointment,
                        dto.Name
                        ,
                        dto.Description
                        ,
                        dto.Date
                        );

                // Return modified object
                returnValue = IMAppointmentAssembler.Convert (iMAppointmentRESTCAD.ReadOIDDefault (idIMAppointment), session);

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


[Route ("~/api/IMAppointment/Destroy")]

public HttpResponseMessage Destroy (int p_imappointment_oid)
{
        // CAD, CEN
        IMAppointmentRESTCAD iMAppointmentRESTCAD = null;
        IMAppointmentCEN iMAppointmentCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMAppointmentRESTCAD = new IMAppointmentRESTCAD (session);
                iMAppointmentCEN = new IMAppointmentCEN (iMAppointmentRESTCAD);

                iMAppointmentCEN.Destroy (p_imappointment_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMAppointmentControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
