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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_AdaptationRequestControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/AdaptationRequest")]
public class AdaptationRequestController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/AdaptationRequest/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        AdaptationRequestRESTCAD adaptationRequestRESTCAD = null;
        AdaptationRequestCEN adaptationRequestCEN = null;

        List<AdaptationRequestEN> adaptationRequestEN = null;
        List<AdaptationRequestDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                adaptationRequestRESTCAD = new AdaptationRequestRESTCAD (session);
                adaptationRequestCEN = new AdaptationRequestCEN (adaptationRequestRESTCAD);

                // Data
                // TODO: paginación

                adaptationRequestEN = adaptationRequestCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (adaptationRequestEN != null) {
                        returnValue = new List<AdaptationRequestDTOA>();
                        foreach (AdaptationRequestEN entry in adaptationRequestEN)
                                returnValue.Add (AdaptationRequestAssembler.Convert (entry, session));
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
// [Route("{idAdaptationRequest}", Name="GetOIDAdaptationRequest")]

[Route ("~/api/AdaptationRequest/{idAdaptationRequest}")]

public HttpResponseMessage ReadOID (int idAdaptationRequest)
{
        // CAD, CEN, EN, returnValue
        AdaptationRequestRESTCAD adaptationRequestRESTCAD = null;
        AdaptationRequestCEN adaptationRequestCEN = null;
        AdaptationRequestEN adaptationRequestEN = null;
        AdaptationRequestDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                adaptationRequestRESTCAD = new AdaptationRequestRESTCAD (session);
                adaptationRequestCEN = new AdaptationRequestCEN (adaptationRequestRESTCAD);

                // Data
                adaptationRequestEN = adaptationRequestCEN.ReadOID (idAdaptationRequest);

                // Convert return
                if (adaptationRequestEN != null) {
                        returnValue = AdaptationRequestAssembler.Convert (adaptationRequestEN, session);
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


[Route ("~/api/AdaptationRequest/New_")]




public HttpResponseMessage New_ ( [FromBody] AdaptationRequestDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        AdaptationRequestRESTCAD adaptationRequestRESTCAD = null;
        AdaptationRequestCEN adaptationRequestCEN = null;
        AdaptationRequestDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                adaptationRequestRESTCAD = new AdaptationRequestRESTCAD (session);
                adaptationRequestCEN = new AdaptationRequestCEN (adaptationRequestRESTCAD);

                // Create
                returnOID = adaptationRequestCEN.New_ (
                        dto.AccessModeTarget                                                                             //Atributo Primitivo: p_AccessModeTarget
                        ,
                        //Atributo OID: p_accessMode
                        // attr.estaRelacionado: true
                        dto.AccessMode_oid                 // association role

                        , dto.LanguageOfAdaptation                                                                                                                                                       //Atributo Primitivo: p_languageOfAdaptation
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = AdaptationRequestAssembler.Convert (adaptationRequestRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDAdaptationRequest", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/AdaptationRequest/Modify")]

public HttpResponseMessage Modify (int idAdaptationRequest, [FromBody] AdaptationRequestDTO dto)
{
        // CAD, CEN, returnValue
        AdaptationRequestRESTCAD adaptationRequestRESTCAD = null;
        AdaptationRequestCEN adaptationRequestCEN = null;
        AdaptationRequestDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                adaptationRequestRESTCAD = new AdaptationRequestRESTCAD (session);
                adaptationRequestCEN = new AdaptationRequestCEN (adaptationRequestRESTCAD);

                // Modify
                adaptationRequestCEN.Modify (idAdaptationRequest,
                        dto.AccessModeTarget
                        ,
                        dto.LanguageOfAdaptation
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = AdaptationRequestAssembler.Convert (adaptationRequestRESTCAD.ReadOIDDefault (idAdaptationRequest), session);

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


[Route ("~/api/AdaptationRequest/Destroy")]

public HttpResponseMessage Destroy (int p_adaptationrequest_oid)
{
        // CAD, CEN
        AdaptationRequestRESTCAD adaptationRequestRESTCAD = null;
        AdaptationRequestCEN adaptationRequestCEN = null;

        try
        {
                SessionInitializeTransaction ();


                adaptationRequestRESTCAD = new AdaptationRequestRESTCAD (session);
                adaptationRequestCEN = new AdaptationRequestCEN (adaptationRequestRESTCAD);

                adaptationRequestCEN.Destroy (p_adaptationrequest_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_AdaptationRequestControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
