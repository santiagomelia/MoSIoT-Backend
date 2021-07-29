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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMAdaptationTypeControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMAdaptationType")]
public class IMAdaptationTypeController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMAdaptationType/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMAdaptationTypeRESTCAD iMAdaptationTypeRESTCAD = null;
        IMAdaptationTypeCEN iMAdaptationTypeCEN = null;

        List<IMAdaptationTypeEN> iMAdaptationTypeEN = null;
        List<IMAdaptationTypeDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMAdaptationTypeRESTCAD = new IMAdaptationTypeRESTCAD (session);
                iMAdaptationTypeCEN = new IMAdaptationTypeCEN (iMAdaptationTypeRESTCAD);

                // Data
                // TODO: paginación

                iMAdaptationTypeEN = iMAdaptationTypeCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMAdaptationTypeEN != null) {
                        returnValue = new List<IMAdaptationTypeDTOA>();
                        foreach (IMAdaptationTypeEN entry in iMAdaptationTypeEN)
                                returnValue.Add (IMAdaptationTypeAssembler.Convert (entry, session));
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





[Route ("~/api/IMAdaptationType/PaAdaptionType")]

public HttpResponseMessage PaAdaptionType (int idPatientAccess)
{
        // CAD, EN
        PatientAccessRESTCAD patientAccessRESTCAD = null;
        PatientAccessEN patientAccessEN = null;

        // returnValue
        List<IMAdaptationTypeEN> en = null;
        List<IMAdaptationTypeDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                patientAccessRESTCAD = new PatientAccessRESTCAD (session);

                // Exists PatientAccess
                patientAccessEN = patientAccessRESTCAD.ReadOIDDefault (idPatientAccess);
                if (patientAccessEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "PatientAccess#" + idPatientAccess + " not found"));

                // Rol
                // TODO: paginación


                en = patientAccessRESTCAD.PaAdaptionType (idPatientAccess).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<IMAdaptationTypeDTOA>();
                        foreach (IMAdaptationTypeEN entry in en)
                                returnValue.Add (IMAdaptationTypeAssembler.Convert (entry, session));
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
// [Route("{idIMAdaptationType}", Name="GetOIDIMAdaptationType")]

[Route ("~/api/IMAdaptationType/{idIMAdaptationType}")]

public HttpResponseMessage ReadOID (int idIMAdaptationType)
{
        // CAD, CEN, EN, returnValue
        IMAdaptationTypeRESTCAD iMAdaptationTypeRESTCAD = null;
        IMAdaptationTypeCEN iMAdaptationTypeCEN = null;
        IMAdaptationTypeEN iMAdaptationTypeEN = null;
        IMAdaptationTypeDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMAdaptationTypeRESTCAD = new IMAdaptationTypeRESTCAD (session);
                iMAdaptationTypeCEN = new IMAdaptationTypeCEN (iMAdaptationTypeRESTCAD);

                // Data
                iMAdaptationTypeEN = iMAdaptationTypeCEN.ReadOID (idIMAdaptationType);

                // Convert return
                if (iMAdaptationTypeEN != null) {
                        returnValue = IMAdaptationTypeAssembler.Convert (iMAdaptationTypeEN, session);
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


[Route ("~/api/IMAdaptationType/New_")]




public HttpResponseMessage New_ ( [FromBody] IMAdaptationTypeDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMAdaptationTypeRESTCAD iMAdaptationTypeRESTCAD = null;
        IMAdaptationTypeCEN iMAdaptationTypeCEN = null;
        IMAdaptationTypeDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMAdaptationTypeRESTCAD = new IMAdaptationTypeRESTCAD (session);
                iMAdaptationTypeCEN = new IMAdaptationTypeCEN (iMAdaptationTypeRESTCAD);

                // Create
                returnOID = iMAdaptationTypeCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_entity
                        // attr.estaRelacionado: true
                        dto.Entity_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMAdaptationTypeAssembler.Convert (iMAdaptationTypeRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMAdaptationType", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMAdaptationType/Modify")]

public HttpResponseMessage Modify (int idIMAdaptationType, [FromBody] IMAdaptationTypeDTO dto)
{
        // CAD, CEN, returnValue
        IMAdaptationTypeRESTCAD iMAdaptationTypeRESTCAD = null;
        IMAdaptationTypeCEN iMAdaptationTypeCEN = null;
        IMAdaptationTypeDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMAdaptationTypeRESTCAD = new IMAdaptationTypeRESTCAD (session);
                iMAdaptationTypeCEN = new IMAdaptationTypeCEN (iMAdaptationTypeRESTCAD);

                // Modify
                iMAdaptationTypeCEN.Modify (idIMAdaptationType,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IMAdaptationTypeAssembler.Convert (iMAdaptationTypeRESTCAD.ReadOIDDefault (idIMAdaptationType), session);

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


[Route ("~/api/IMAdaptationType/Destroy")]

public HttpResponseMessage Destroy (int p_imadaptationtype_oid)
{
        // CAD, CEN
        IMAdaptationTypeRESTCAD iMAdaptationTypeRESTCAD = null;
        IMAdaptationTypeCEN iMAdaptationTypeCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMAdaptationTypeRESTCAD = new IMAdaptationTypeRESTCAD (session);
                iMAdaptationTypeCEN = new IMAdaptationTypeCEN (iMAdaptationTypeRESTCAD);

                iMAdaptationTypeCEN.Destroy (p_imadaptationtype_oid);
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


[Route ("~/api/IMAdaptationType/AssignAdaptationT")]

public HttpResponseMessage AssignAdaptationT (int p_imadaptationtype_oid, int p_adaptationtyperequired_oid)
{
        // CAD, CEN, returnValue
        IMAdaptationTypeRESTCAD iMAdaptationTypeRESTCAD = null;
        IMAdaptationTypeCEN iMAdaptationTypeCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMAdaptationTypeRESTCAD = new IMAdaptationTypeRESTCAD (session);
                iMAdaptationTypeCEN = new IMAdaptationTypeCEN (iMAdaptationTypeRESTCAD);

                // Relationer
                iMAdaptationTypeCEN.AssignAdaptationT (p_imadaptationtype_oid, p_adaptationtyperequired_oid);
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







/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMAdaptationTypeControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
