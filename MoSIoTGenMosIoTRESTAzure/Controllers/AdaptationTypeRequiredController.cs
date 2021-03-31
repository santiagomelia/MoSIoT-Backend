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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_AdaptationTypeRequiredControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/AdaptationTypeRequired")]
public class AdaptationTypeRequiredController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/AdaptationTypeRequired/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        AdaptationTypeRequiredRESTCAD adaptationTypeRequiredRESTCAD = null;
        AdaptationTypeRequiredCEN adaptationTypeRequiredCEN = null;

        List<AdaptationTypeRequiredEN> adaptationTypeRequiredEN = null;
        List<AdaptationTypeRequiredDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                adaptationTypeRequiredRESTCAD = new AdaptationTypeRequiredRESTCAD (session);
                adaptationTypeRequiredCEN = new AdaptationTypeRequiredCEN (adaptationTypeRequiredRESTCAD);

                // Data
                // TODO: paginación

                adaptationTypeRequiredEN = adaptationTypeRequiredCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (adaptationTypeRequiredEN != null) {
                        returnValue = new List<AdaptationTypeRequiredDTOA>();
                        foreach (AdaptationTypeRequiredEN entry in adaptationTypeRequiredEN)
                                returnValue.Add (AdaptationTypeRequiredAssembler.Convert (entry, session));
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
// [Route("{idAdaptationTypeRequired}", Name="GetOIDAdaptationTypeRequired")]

[Route ("~/api/AdaptationTypeRequired/{idAdaptationTypeRequired}")]

public HttpResponseMessage ReadOID (int idAdaptationTypeRequired)
{
        // CAD, CEN, EN, returnValue
        AdaptationTypeRequiredRESTCAD adaptationTypeRequiredRESTCAD = null;
        AdaptationTypeRequiredCEN adaptationTypeRequiredCEN = null;
        AdaptationTypeRequiredEN adaptationTypeRequiredEN = null;
        AdaptationTypeRequiredDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                adaptationTypeRequiredRESTCAD = new AdaptationTypeRequiredRESTCAD (session);
                adaptationTypeRequiredCEN = new AdaptationTypeRequiredCEN (adaptationTypeRequiredRESTCAD);

                // Data
                adaptationTypeRequiredEN = adaptationTypeRequiredCEN.ReadOID (idAdaptationTypeRequired);

                // Convert return
                if (adaptationTypeRequiredEN != null) {
                        returnValue = AdaptationTypeRequiredAssembler.Convert (adaptationTypeRequiredEN, session);
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


[Route ("~/api/AdaptationTypeRequired/New_")]




public HttpResponseMessage New_ ( [FromBody] AdaptationTypeRequiredDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        AdaptationTypeRequiredRESTCAD adaptationTypeRequiredRESTCAD = null;
        AdaptationTypeRequiredCEN adaptationTypeRequiredCEN = null;
        AdaptationTypeRequiredDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                adaptationTypeRequiredRESTCAD = new AdaptationTypeRequiredRESTCAD (session);
                adaptationTypeRequiredCEN = new AdaptationTypeRequiredCEN (adaptationTypeRequiredRESTCAD);

                // Create
                returnOID = adaptationTypeRequiredCEN.New_ (
                        dto.AdaptionRequest                                                                              //Atributo Primitivo: p_adaptionRequest
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_accessMode
                        // attr.estaRelacionado: true
                        dto.AccessMode_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = AdaptationTypeRequiredAssembler.Convert (adaptationTypeRequiredRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDAdaptationTypeRequired", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/AdaptationTypeRequired/Modify")]

public HttpResponseMessage Modify (int idAdaptationTypeRequired, [FromBody] AdaptationTypeRequiredDTO dto)
{
        // CAD, CEN, returnValue
        AdaptationTypeRequiredRESTCAD adaptationTypeRequiredRESTCAD = null;
        AdaptationTypeRequiredCEN adaptationTypeRequiredCEN = null;
        AdaptationTypeRequiredDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                adaptationTypeRequiredRESTCAD = new AdaptationTypeRequiredRESTCAD (session);
                adaptationTypeRequiredCEN = new AdaptationTypeRequiredCEN (adaptationTypeRequiredRESTCAD);

                // Modify
                adaptationTypeRequiredCEN.Modify (idAdaptationTypeRequired,
                        dto.AdaptionRequest
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = AdaptationTypeRequiredAssembler.Convert (adaptationTypeRequiredRESTCAD.ReadOIDDefault (idAdaptationTypeRequired), session);

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


[Route ("~/api/AdaptationTypeRequired/Destroy")]

public HttpResponseMessage Destroy (int p_adaptationtyperequired_oid)
{
        // CAD, CEN
        AdaptationTypeRequiredRESTCAD adaptationTypeRequiredRESTCAD = null;
        AdaptationTypeRequiredCEN adaptationTypeRequiredCEN = null;

        try
        {
                SessionInitializeTransaction ();


                adaptationTypeRequiredRESTCAD = new AdaptationTypeRequiredRESTCAD (session);
                adaptationTypeRequiredCEN = new AdaptationTypeRequiredCEN (adaptationTypeRequiredRESTCAD);

                adaptationTypeRequiredCEN.Destroy (p_adaptationtyperequired_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_AdaptationTypeRequiredControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
