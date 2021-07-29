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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMCommunicationControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMCommunication")]
public class IMCommunicationController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMCommunication/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMCommunicationRESTCAD iMCommunicationRESTCAD = null;
        IMCommunicationCEN iMCommunicationCEN = null;

        List<IMCommunicationEN> iMCommunicationEN = null;
        List<IMCommunicationDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMCommunicationRESTCAD = new IMCommunicationRESTCAD (session);
                iMCommunicationCEN = new IMCommunicationCEN (iMCommunicationRESTCAD);

                // Data
                // TODO: paginación

                iMCommunicationEN = iMCommunicationCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMCommunicationEN != null) {
                        returnValue = new List<IMCommunicationDTOA>();
                        foreach (IMCommunicationEN entry in iMCommunicationEN)
                                returnValue.Add (IMCommunicationAssembler.Convert (entry, session));
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





[Route ("~/api/IMCommunication/CommunicationCareActivity")]

public HttpResponseMessage CommunicationCareActivity (int idIMCareActivity)
{
        // CAD, EN
        IMCareActivityRESTCAD iMCareActivityRESTCAD = null;
        IMCareActivityEN iMCareActivityEN = null;

        // returnValue
        List<IMCommunicationEN> en = null;
        List<IMCommunicationDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMCareActivityRESTCAD = new IMCareActivityRESTCAD (session);

                // Exists IMCareActivity
                iMCareActivityEN = iMCareActivityRESTCAD.ReadOIDDefault (idIMCareActivity);
                if (iMCareActivityEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IMCareActivity#" + idIMCareActivity + " not found"));

                // Rol
                // TODO: paginación


                en = iMCareActivityRESTCAD.CommunicationCareActivity (idIMCareActivity).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<IMCommunicationDTOA>();
                        foreach (IMCommunicationEN entry in en)
                                returnValue.Add (IMCommunicationAssembler.Convert (entry, session));
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
// [Route("{idIMCommunication}", Name="GetOIDIMCommunication")]

[Route ("~/api/IMCommunication/{idIMCommunication}")]

public HttpResponseMessage ReadOID (int idIMCommunication)
{
        // CAD, CEN, EN, returnValue
        IMCommunicationRESTCAD iMCommunicationRESTCAD = null;
        IMCommunicationCEN iMCommunicationCEN = null;
        IMCommunicationEN iMCommunicationEN = null;
        IMCommunicationDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMCommunicationRESTCAD = new IMCommunicationRESTCAD (session);
                iMCommunicationCEN = new IMCommunicationCEN (iMCommunicationRESTCAD);

                // Data
                iMCommunicationEN = iMCommunicationCEN.ReadOID (idIMCommunication);

                // Convert return
                if (iMCommunicationEN != null) {
                        returnValue = IMCommunicationAssembler.Convert (iMCommunicationEN, session);
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


[Route ("~/api/IMCommunication/New_")]




public HttpResponseMessage New_ ( [FromBody] IMCommunicationDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMCommunicationRESTCAD iMCommunicationRESTCAD = null;
        IMCommunicationCEN iMCommunicationCEN = null;
        IMCommunicationDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMCommunicationRESTCAD = new IMCommunicationRESTCAD (session);
                iMCommunicationCEN = new IMCommunicationCEN (iMCommunicationRESTCAD);

                // Create
                returnOID = iMCommunicationCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_entity
                        // attr.estaRelacionado: true
                        dto.Entity_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMCommunicationAssembler.Convert (iMCommunicationRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMCommunication", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMCommunication/Modify")]

public HttpResponseMessage Modify (int idIMCommunication, [FromBody] IMCommunicationDTO dto)
{
        // CAD, CEN, returnValue
        IMCommunicationRESTCAD iMCommunicationRESTCAD = null;
        IMCommunicationCEN iMCommunicationCEN = null;
        IMCommunicationDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMCommunicationRESTCAD = new IMCommunicationRESTCAD (session);
                iMCommunicationCEN = new IMCommunicationCEN (iMCommunicationRESTCAD);

                // Modify
                iMCommunicationCEN.Modify (idIMCommunication,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IMCommunicationAssembler.Convert (iMCommunicationRESTCAD.ReadOIDDefault (idIMCommunication), session);

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


[Route ("~/api/IMCommunication/Destroy")]

public HttpResponseMessage Destroy (int p_imcommunication_oid)
{
        // CAD, CEN
        IMCommunicationRESTCAD iMCommunicationRESTCAD = null;
        IMCommunicationCEN iMCommunicationCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMCommunicationRESTCAD = new IMCommunicationRESTCAD (session);
                iMCommunicationCEN = new IMCommunicationCEN (iMCommunicationRESTCAD);

                iMCommunicationCEN.Destroy (p_imcommunication_oid);
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


[Route ("~/api/IMCommunication/AssignCommunication")]

public HttpResponseMessage AssignCommunication (int p_imcommunication_oid, int p_comunication_oid)
{
        // CAD, CEN, returnValue
        IMCommunicationRESTCAD iMCommunicationRESTCAD = null;
        IMCommunicationCEN iMCommunicationCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMCommunicationRESTCAD = new IMCommunicationRESTCAD (session);
                iMCommunicationCEN = new IMCommunicationCEN (iMCommunicationRESTCAD);

                // Relationer
                iMCommunicationCEN.AssignCommunication (p_imcommunication_oid, p_comunication_oid);
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







/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMCommunicationControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
