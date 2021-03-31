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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_AdaptationDetailRequiredControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/AdaptationDetailRequired")]
public class AdaptationDetailRequiredController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/AdaptationDetailRequired/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        AdaptationDetailRequiredRESTCAD adaptationDetailRequiredRESTCAD = null;
        AdaptationDetailRequiredCEN adaptationDetailRequiredCEN = null;

        List<AdaptationDetailRequiredEN> adaptationDetailRequiredEN = null;
        List<AdaptationDetailRequiredDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                adaptationDetailRequiredRESTCAD = new AdaptationDetailRequiredRESTCAD (session);
                adaptationDetailRequiredCEN = new AdaptationDetailRequiredCEN (adaptationDetailRequiredRESTCAD);

                // Data
                // TODO: paginación

                adaptationDetailRequiredEN = adaptationDetailRequiredCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (adaptationDetailRequiredEN != null) {
                        returnValue = new List<AdaptationDetailRequiredDTOA>();
                        foreach (AdaptationDetailRequiredEN entry in adaptationDetailRequiredEN)
                                returnValue.Add (AdaptationDetailRequiredAssembler.Convert (entry, session));
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
// [Route("{idAdaptationDetailRequired}", Name="GetOIDAdaptationDetailRequired")]

[Route ("~/api/AdaptationDetailRequired/{idAdaptationDetailRequired}")]

public HttpResponseMessage ReadOID (int idAdaptationDetailRequired)
{
        // CAD, CEN, EN, returnValue
        AdaptationDetailRequiredRESTCAD adaptationDetailRequiredRESTCAD = null;
        AdaptationDetailRequiredCEN adaptationDetailRequiredCEN = null;
        AdaptationDetailRequiredEN adaptationDetailRequiredEN = null;
        AdaptationDetailRequiredDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                adaptationDetailRequiredRESTCAD = new AdaptationDetailRequiredRESTCAD (session);
                adaptationDetailRequiredCEN = new AdaptationDetailRequiredCEN (adaptationDetailRequiredRESTCAD);

                // Data
                adaptationDetailRequiredEN = adaptationDetailRequiredCEN.ReadOID (idAdaptationDetailRequired);

                // Convert return
                if (adaptationDetailRequiredEN != null) {
                        returnValue = AdaptationDetailRequiredAssembler.Convert (adaptationDetailRequiredEN, session);
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


[Route ("~/api/AdaptationDetailRequired/New_")]




public HttpResponseMessage New_ ( [FromBody] AdaptationDetailRequiredDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        AdaptationDetailRequiredRESTCAD adaptationDetailRequiredRESTCAD = null;
        AdaptationDetailRequiredCEN adaptationDetailRequiredCEN = null;
        AdaptationDetailRequiredDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                adaptationDetailRequiredRESTCAD = new AdaptationDetailRequiredRESTCAD (session);
                adaptationDetailRequiredCEN = new AdaptationDetailRequiredCEN (adaptationDetailRequiredRESTCAD);

                // Create
                returnOID = adaptationDetailRequiredCEN.New_ (
                        dto.AdaptationRequest                                                                            //Atributo Primitivo: p_adaptationRequest
                        ,
                        //Atributo OID: p_accessMode
                        // attr.estaRelacionado: true
                        dto.AccessMode_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = AdaptationDetailRequiredAssembler.Convert (adaptationDetailRequiredRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDAdaptationDetailRequired", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/AdaptationDetailRequired/Modify")]

public HttpResponseMessage Modify (int idAdaptationDetailRequired, [FromBody] AdaptationDetailRequiredDTO dto)
{
        // CAD, CEN, returnValue
        AdaptationDetailRequiredRESTCAD adaptationDetailRequiredRESTCAD = null;
        AdaptationDetailRequiredCEN adaptationDetailRequiredCEN = null;
        AdaptationDetailRequiredDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                adaptationDetailRequiredRESTCAD = new AdaptationDetailRequiredRESTCAD (session);
                adaptationDetailRequiredCEN = new AdaptationDetailRequiredCEN (adaptationDetailRequiredRESTCAD);

                // Modify
                adaptationDetailRequiredCEN.Modify (idAdaptationDetailRequired,
                        dto.AdaptationRequest
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = AdaptationDetailRequiredAssembler.Convert (adaptationDetailRequiredRESTCAD.ReadOIDDefault (idAdaptationDetailRequired), session);

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


[Route ("~/api/AdaptationDetailRequired/Destroy")]

public HttpResponseMessage Destroy (int p_adaptationdetailrequired_oid)
{
        // CAD, CEN
        AdaptationDetailRequiredRESTCAD adaptationDetailRequiredRESTCAD = null;
        AdaptationDetailRequiredCEN adaptationDetailRequiredCEN = null;

        try
        {
                SessionInitializeTransaction ();


                adaptationDetailRequiredRESTCAD = new AdaptationDetailRequiredRESTCAD (session);
                adaptationDetailRequiredCEN = new AdaptationDetailRequiredCEN (adaptationDetailRequiredRESTCAD);

                adaptationDetailRequiredCEN.Destroy (p_adaptationdetailrequired_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_AdaptationDetailRequiredControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
