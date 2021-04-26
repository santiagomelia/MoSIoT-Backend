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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_AppointmentControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Appointment")]
public class AppointmentController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Appointment/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        AppointmentRESTCAD appointmentRESTCAD = null;
        AppointmentCEN appointmentCEN = null;

        List<AppointmentEN> appointmentEN = null;
        List<AppointmentDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                appointmentRESTCAD = new AppointmentRESTCAD (session);
                appointmentCEN = new AppointmentCEN (appointmentRESTCAD);

                // Data
                // TODO: paginación

                appointmentEN = appointmentCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (appointmentEN != null) {
                        returnValue = new List<AppointmentDTOA>();
                        foreach (AppointmentEN entry in appointmentEN)
                                returnValue.Add (AppointmentAssembler.Convert (entry, session));
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
// [Route("{idAppointment}", Name="GetOIDAppointment")]

[Route ("~/api/Appointment/{idAppointment}")]

public HttpResponseMessage ReadOID (int idAppointment)
{
        // CAD, CEN, EN, returnValue
        AppointmentRESTCAD appointmentRESTCAD = null;
        AppointmentCEN appointmentCEN = null;
        AppointmentEN appointmentEN = null;
        AppointmentDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                appointmentRESTCAD = new AppointmentRESTCAD (session);
                appointmentCEN = new AppointmentCEN (appointmentRESTCAD);

                // Data
                appointmentEN = appointmentCEN.ReadOID (idAppointment);

                // Convert return
                if (appointmentEN != null) {
                        returnValue = AppointmentAssembler.Convert (appointmentEN, session);
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


[Route ("~/api/Appointment/New_")]




public HttpResponseMessage New_ ( [FromBody] AppointmentDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        AppointmentRESTCAD appointmentRESTCAD = null;
        AppointmentCEN appointmentCEN = null;
        AppointmentDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                appointmentRESTCAD = new AppointmentRESTCAD (session);
                appointmentCEN = new AppointmentCEN (appointmentRESTCAD);

                // Create
                returnOID = appointmentCEN.New_ (
                        dto.IsVirtual                                                                            //Atributo Primitivo: p_isVirtual
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        , dto.Direction                                                                                                                                                  //Atributo Primitivo: p_direction
                        , dto.ReasonCode                                                                                                                                                 //Atributo Primitivo: p_reasonCode
                        ,
                        //Atributo OID: p_careActivity
                        // attr.estaRelacionado: true
                        dto.CareActivity_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = AppointmentAssembler.Convert (appointmentRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDAppointment", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Appointment/Modify")]

public HttpResponseMessage Modify (int idAppointment, [FromBody] AppointmentDTO dto)
{
        // CAD, CEN, returnValue
        AppointmentRESTCAD appointmentRESTCAD = null;
        AppointmentCEN appointmentCEN = null;
        AppointmentDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                appointmentRESTCAD = new AppointmentRESTCAD (session);
                appointmentCEN = new AppointmentCEN (appointmentRESTCAD);

                // Modify
                appointmentCEN.Modify (idAppointment,
                        dto.IsVirtual
                        ,
                        dto.Description
                        ,
                        dto.Direction
                        ,
                        dto.ReasonCode
                        );

                // Return modified object
                returnValue = AppointmentAssembler.Convert (appointmentRESTCAD.ReadOIDDefault (idAppointment), session);

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


[Route ("~/api/Appointment/Destroy")]

public HttpResponseMessage Destroy (int p_appointment_oid)
{
        // CAD, CEN
        AppointmentRESTCAD appointmentRESTCAD = null;
        AppointmentCEN appointmentCEN = null;

        try
        {
                SessionInitializeTransaction ();


                appointmentRESTCAD = new AppointmentRESTCAD (session);
                appointmentCEN = new AppointmentCEN (appointmentRESTCAD);

                appointmentCEN.Destroy (p_appointment_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_AppointmentControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
