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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMAdaptationRequestControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMAdaptationRequest")]
public class IMAdaptationRequestController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMAdaptationRequest/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMAdaptationRequestRESTCAD iMAdaptationRequestRESTCAD = null;
        IMAdaptationRequestCEN iMAdaptationRequestCEN = null;

        List<IMAdaptationRequestEN> iMAdaptationRequestEN = null;
        List<IMAdaptationRequestDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMAdaptationRequestRESTCAD = new IMAdaptationRequestRESTCAD (session);
                iMAdaptationRequestCEN = new IMAdaptationRequestCEN (iMAdaptationRequestRESTCAD);

                // Data
                // TODO: paginación

                iMAdaptationRequestEN = iMAdaptationRequestCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMAdaptationRequestEN != null) {
                        returnValue = new List<IMAdaptationRequestDTOA>();
                        foreach (IMAdaptationRequestEN entry in iMAdaptationRequestEN)
                                returnValue.Add (IMAdaptationRequestAssembler.Convert (entry, session));
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
// [Route("{idIMAdaptationRequest}", Name="GetOIDIMAdaptationRequest")]

[Route ("~/api/IMAdaptationRequest/{idIMAdaptationRequest}")]

public HttpResponseMessage ReadOID (int idIMAdaptationRequest)
{
        // CAD, CEN, EN, returnValue
        IMAdaptationRequestRESTCAD iMAdaptationRequestRESTCAD = null;
        IMAdaptationRequestCEN iMAdaptationRequestCEN = null;
        IMAdaptationRequestEN iMAdaptationRequestEN = null;
        IMAdaptationRequestDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMAdaptationRequestRESTCAD = new IMAdaptationRequestRESTCAD (session);
                iMAdaptationRequestCEN = new IMAdaptationRequestCEN (iMAdaptationRequestRESTCAD);

                // Data
                iMAdaptationRequestEN = iMAdaptationRequestCEN.ReadOID (idIMAdaptationRequest);

                // Convert return
                if (iMAdaptationRequestEN != null) {
                        returnValue = IMAdaptationRequestAssembler.Convert (iMAdaptationRequestEN, session);
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


[Route ("~/api/IMAdaptationRequest/New_")]




public HttpResponseMessage New_ ( [FromBody] IMAdaptationRequestDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMAdaptationRequestRESTCAD iMAdaptationRequestRESTCAD = null;
        IMAdaptationRequestCEN iMAdaptationRequestCEN = null;
        IMAdaptationRequestDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMAdaptationRequestRESTCAD = new IMAdaptationRequestRESTCAD (session);
                iMAdaptationRequestCEN = new IMAdaptationRequestCEN (iMAdaptationRequestRESTCAD);

                // Create
                returnOID = iMAdaptationRequestCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Type                                                                                                                                                       //Atributo Primitivo: p_type
                        , dto.IsOID                                                                                                                                                      //Atributo Primitivo: p_isOID
                        , dto.IsWritable                                                                                                                                                 //Atributo Primitivo: p_isWritable
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_entity
                        // attr.estaRelacionado: true
                        dto.Entity_oid                 // association role

                        , dto.Value                                                                                                                                                      //Atributo Primitivo: p_value
                        ,
                        //Atributo OID: p_adaptationRequest
                        // attr.estaRelacionado: true
                        dto.AdaptationRequest_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMAdaptationRequestAssembler.Convert (iMAdaptationRequestRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMAdaptationRequest", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMAdaptationRequest/Modify")]

public HttpResponseMessage Modify (int idIMAdaptationRequest, [FromBody] IMAdaptationRequestDTO dto)
{
        // CAD, CEN, returnValue
        IMAdaptationRequestRESTCAD iMAdaptationRequestRESTCAD = null;
        IMAdaptationRequestCEN iMAdaptationRequestCEN = null;
        IMAdaptationRequestDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMAdaptationRequestRESTCAD = new IMAdaptationRequestRESTCAD (session);
                iMAdaptationRequestCEN = new IMAdaptationRequestCEN (iMAdaptationRequestRESTCAD);

                // Modify
                iMAdaptationRequestCEN.Modify (idIMAdaptationRequest,
                        dto.Name
                        ,
                        dto.Type
                        ,
                        dto.IsOID
                        ,
                        dto.IsWritable
                        ,
                        dto.Description
                        ,
                        dto.Value
                        );

                // Return modified object
                returnValue = IMAdaptationRequestAssembler.Convert (iMAdaptationRequestRESTCAD.ReadOIDDefault (idIMAdaptationRequest), session);

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


[Route ("~/api/IMAdaptationRequest/Destroy")]

public HttpResponseMessage Destroy (int p_imadaptationrequest_oid)
{
        // CAD, CEN
        IMAdaptationRequestRESTCAD iMAdaptationRequestRESTCAD = null;
        IMAdaptationRequestCEN iMAdaptationRequestCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMAdaptationRequestRESTCAD = new IMAdaptationRequestRESTCAD (session);
                iMAdaptationRequestCEN = new IMAdaptationRequestCEN (iMAdaptationRequestRESTCAD);

                iMAdaptationRequestCEN.Destroy (p_imadaptationrequest_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMAdaptationRequestControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
