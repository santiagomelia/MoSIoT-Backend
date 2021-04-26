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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMAdaptationDetailControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMAdaptationDetail")]
public class IMAdaptationDetailController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMAdaptationDetail/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMAdaptationDetailRESTCAD iMAdaptationDetailRESTCAD = null;
        IMAdaptationDetailCEN iMAdaptationDetailCEN = null;

        List<IMAdaptationDetailEN> iMAdaptationDetailEN = null;
        List<IMAdaptationDetailDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMAdaptationDetailRESTCAD = new IMAdaptationDetailRESTCAD (session);
                iMAdaptationDetailCEN = new IMAdaptationDetailCEN (iMAdaptationDetailRESTCAD);

                // Data
                // TODO: paginación

                iMAdaptationDetailEN = iMAdaptationDetailCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMAdaptationDetailEN != null) {
                        returnValue = new List<IMAdaptationDetailDTOA>();
                        foreach (IMAdaptationDetailEN entry in iMAdaptationDetailEN)
                                returnValue.Add (IMAdaptationDetailAssembler.Convert (entry, session));
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
// [Route("{idIMAdaptationDetail}", Name="GetOIDIMAdaptationDetail")]

[Route ("~/api/IMAdaptationDetail/{idIMAdaptationDetail}")]

public HttpResponseMessage ReadOID (int idIMAdaptationDetail)
{
        // CAD, CEN, EN, returnValue
        IMAdaptationDetailRESTCAD iMAdaptationDetailRESTCAD = null;
        IMAdaptationDetailCEN iMAdaptationDetailCEN = null;
        IMAdaptationDetailEN iMAdaptationDetailEN = null;
        IMAdaptationDetailDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMAdaptationDetailRESTCAD = new IMAdaptationDetailRESTCAD (session);
                iMAdaptationDetailCEN = new IMAdaptationDetailCEN (iMAdaptationDetailRESTCAD);

                // Data
                iMAdaptationDetailEN = iMAdaptationDetailCEN.ReadOID (idIMAdaptationDetail);

                // Convert return
                if (iMAdaptationDetailEN != null) {
                        returnValue = IMAdaptationDetailAssembler.Convert (iMAdaptationDetailEN, session);
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


[Route ("~/api/IMAdaptationDetail/New_")]




public HttpResponseMessage New_ ( [FromBody] IMAdaptationDetailDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMAdaptationDetailRESTCAD iMAdaptationDetailRESTCAD = null;
        IMAdaptationDetailCEN iMAdaptationDetailCEN = null;
        IMAdaptationDetailDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMAdaptationDetailRESTCAD = new IMAdaptationDetailRESTCAD (session);
                iMAdaptationDetailCEN = new IMAdaptationDetailCEN (iMAdaptationDetailRESTCAD);

                // Create
                returnOID = iMAdaptationDetailCEN.New_ (
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
                        //Atributo OID: p_adaptationDetailRequired
                        // attr.estaRelacionado: true
                        dto.AdaptationDetailRequired_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMAdaptationDetailAssembler.Convert (iMAdaptationDetailRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMAdaptationDetail", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMAdaptationDetail/Modify")]

public HttpResponseMessage Modify (int idIMAdaptationDetail, [FromBody] IMAdaptationDetailDTO dto)
{
        // CAD, CEN, returnValue
        IMAdaptationDetailRESTCAD iMAdaptationDetailRESTCAD = null;
        IMAdaptationDetailCEN iMAdaptationDetailCEN = null;
        IMAdaptationDetailDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMAdaptationDetailRESTCAD = new IMAdaptationDetailRESTCAD (session);
                iMAdaptationDetailCEN = new IMAdaptationDetailCEN (iMAdaptationDetailRESTCAD);

                // Modify
                iMAdaptationDetailCEN.Modify (idIMAdaptationDetail,
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
                returnValue = IMAdaptationDetailAssembler.Convert (iMAdaptationDetailRESTCAD.ReadOIDDefault (idIMAdaptationDetail), session);

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


[Route ("~/api/IMAdaptationDetail/Destroy")]

public HttpResponseMessage Destroy (int p_imadaptationdetail_oid)
{
        // CAD, CEN
        IMAdaptationDetailRESTCAD iMAdaptationDetailRESTCAD = null;
        IMAdaptationDetailCEN iMAdaptationDetailCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMAdaptationDetailRESTCAD = new IMAdaptationDetailRESTCAD (session);
                iMAdaptationDetailCEN = new IMAdaptationDetailCEN (iMAdaptationDetailRESTCAD);

                iMAdaptationDetailCEN.Destroy (p_imadaptationdetail_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMAdaptationDetailControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
