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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_CarePlanTemplateControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/CarePlanTemplate")]
public class CarePlanTemplateController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/CarePlanTemplate/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        CarePlanTemplateRESTCAD carePlanTemplateRESTCAD = null;
        CarePlanTemplateCEN carePlanTemplateCEN = null;

        List<CarePlanTemplateEN> carePlanTemplateEN = null;
        List<CarePlanTemplateDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                carePlanTemplateRESTCAD = new CarePlanTemplateRESTCAD (session);
                carePlanTemplateCEN = new CarePlanTemplateCEN (carePlanTemplateRESTCAD);

                // Data
                // TODO: paginación

                carePlanTemplateEN = carePlanTemplateCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (carePlanTemplateEN != null) {
                        returnValue = new List<CarePlanTemplateDTOA>();
                        foreach (CarePlanTemplateEN entry in carePlanTemplateEN)
                                returnValue.Add (CarePlanTemplateAssembler.Convert (entry, session));
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
// [Route("{idCarePlanTemplate}", Name="GetOIDCarePlanTemplate")]

[Route ("~/api/CarePlanTemplate/{idCarePlanTemplate}")]

public HttpResponseMessage ReadOID (int idCarePlanTemplate)
{
        // CAD, CEN, EN, returnValue
        CarePlanTemplateRESTCAD carePlanTemplateRESTCAD = null;
        CarePlanTemplateCEN carePlanTemplateCEN = null;
        CarePlanTemplateEN carePlanTemplateEN = null;
        CarePlanTemplateDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                carePlanTemplateRESTCAD = new CarePlanTemplateRESTCAD (session);
                carePlanTemplateCEN = new CarePlanTemplateCEN (carePlanTemplateRESTCAD);

                // Data
                carePlanTemplateEN = carePlanTemplateCEN.ReadOID (idCarePlanTemplate);

                // Convert return
                if (carePlanTemplateEN != null) {
                        returnValue = CarePlanTemplateAssembler.Convert (carePlanTemplateEN, session);
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


[Route ("~/api/CarePlanTemplate/New_")]




public HttpResponseMessage New_ ( [FromBody] CarePlanTemplateDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        CarePlanTemplateRESTCAD carePlanTemplateRESTCAD = null;
        CarePlanTemplateCEN carePlanTemplateCEN = null;
        CarePlanTemplateDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                carePlanTemplateRESTCAD = new CarePlanTemplateRESTCAD (session);
                carePlanTemplateCEN = new CarePlanTemplateCEN (carePlanTemplateRESTCAD);

                // Create
                returnOID = carePlanTemplateCEN.New_ (
                        dto.Status                                                                               //Atributo Primitivo: p_status
                        , dto.Intent                                                                                                                                                     //Atributo Primitivo: p_intent
                        , dto.Title                                                                                                                                                      //Atributo Primitivo: p_title
                        , dto.Modified                                                                                                                                                   //Atributo Primitivo: p_modified
                        , dto.DurationDays                                                                                                                                                       //Atributo Primitivo: p_durationDays
                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = CarePlanTemplateAssembler.Convert (carePlanTemplateRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDCarePlanTemplate", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/CarePlanTemplate/Modify")]

public HttpResponseMessage Modify (int idCarePlanTemplate, [FromBody] CarePlanTemplateDTO dto)
{
        // CAD, CEN, returnValue
        CarePlanTemplateRESTCAD carePlanTemplateRESTCAD = null;
        CarePlanTemplateCEN carePlanTemplateCEN = null;
        CarePlanTemplateDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                carePlanTemplateRESTCAD = new CarePlanTemplateRESTCAD (session);
                carePlanTemplateCEN = new CarePlanTemplateCEN (carePlanTemplateRESTCAD);

                // Modify
                carePlanTemplateCEN.Modify (idCarePlanTemplate,
                        dto.Status
                        ,
                        dto.Intent
                        ,
                        dto.Title
                        ,
                        dto.Modified
                        ,
                        dto.DurationDays
                        ,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = CarePlanTemplateAssembler.Convert (carePlanTemplateRESTCAD.ReadOIDDefault (idCarePlanTemplate), session);

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


[Route ("~/api/CarePlanTemplate/Destroy")]

public HttpResponseMessage Destroy (int p_careplantemplate_oid)
{
        // CAD, CEN
        CarePlanTemplateRESTCAD carePlanTemplateRESTCAD = null;
        CarePlanTemplateCEN carePlanTemplateCEN = null;

        try
        {
                SessionInitializeTransaction ();


                carePlanTemplateRESTCAD = new CarePlanTemplateRESTCAD (session);
                carePlanTemplateCEN = new CarePlanTemplateCEN (carePlanTemplateRESTCAD);

                carePlanTemplateCEN.Destroy (p_careplantemplate_oid);
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


[Route ("~/api/CarePlanTemplate/AddCondition")]

public HttpResponseMessage AddCondition (int p_careplantemplate_oid, System.Collections.Generic.IList<int> p_addressconditions_oids)
{
        // CAD, CEN, returnValue
        CarePlanTemplateRESTCAD carePlanTemplateRESTCAD = null;
        CarePlanTemplateCEN carePlanTemplateCEN = null;

        try
        {
                SessionInitializeTransaction ();


                carePlanTemplateRESTCAD = new CarePlanTemplateRESTCAD (session);
                carePlanTemplateCEN = new CarePlanTemplateCEN (carePlanTemplateRESTCAD);

                // Relationer
                carePlanTemplateCEN.AddCondition (p_careplantemplate_oid, p_addressconditions_oids);
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



[HttpPut]


[Route ("~/api/CarePlanTemplate/AddPatientProfile")]

public HttpResponseMessage AddPatientProfile (int p_careplantemplate_oid, int p_patientprofile_oid)
{
        // CAD, CEN, returnValue
        CarePlanTemplateRESTCAD carePlanTemplateRESTCAD = null;
        CarePlanTemplateCEN carePlanTemplateCEN = null;

        try
        {
                SessionInitializeTransaction ();


                carePlanTemplateRESTCAD = new CarePlanTemplateRESTCAD (session);
                carePlanTemplateCEN = new CarePlanTemplateCEN (carePlanTemplateRESTCAD);

                // Relationer
                carePlanTemplateCEN.AddPatientProfile (p_careplantemplate_oid, p_patientprofile_oid);
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







/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_CarePlanTemplateControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
