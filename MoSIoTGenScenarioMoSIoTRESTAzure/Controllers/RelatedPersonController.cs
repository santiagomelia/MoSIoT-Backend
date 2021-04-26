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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_RelatedPersonControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/RelatedPerson")]
public class RelatedPersonController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/RelatedPerson/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        RelatedPersonRESTCAD relatedPersonRESTCAD = null;
        RelatedPersonCEN relatedPersonCEN = null;

        List<RelatedPersonEN> relatedPersonEN = null;
        List<RelatedPersonDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                relatedPersonRESTCAD = new RelatedPersonRESTCAD (session);
                relatedPersonCEN = new RelatedPersonCEN (relatedPersonRESTCAD);

                // Data
                // TODO: paginación

                relatedPersonEN = relatedPersonCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (relatedPersonEN != null) {
                        returnValue = new List<RelatedPersonDTOA>();
                        foreach (RelatedPersonEN entry in relatedPersonEN)
                                returnValue.Add (RelatedPersonAssembler.Convert (entry, session));
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





[Route ("~/api/RelatedPerson/RelatedPeople")]

public HttpResponseMessage RelatedPeople (int idIoTScenario)
{
        // CAD, EN
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioEN ioTScenarioEN = null;

        // returnValue
        List<RelatedPersonEN> en = null;
        List<RelatedPersonDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);

                // Exists IoTScenario
                ioTScenarioEN = ioTScenarioRESTCAD.ReadOIDDefault (idIoTScenario);
                if (ioTScenarioEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IoTScenario#" + idIoTScenario + " not found"));

                // Rol
                // TODO: paginación


                en = ioTScenarioRESTCAD.RelatedPeople (idIoTScenario).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<RelatedPersonDTOA>();
                        foreach (RelatedPersonEN entry in en)
                                returnValue.Add (RelatedPersonAssembler.Convert (entry, session));
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
// [Route("{idRelatedPerson}", Name="GetOIDRelatedPerson")]

[Route ("~/api/RelatedPerson/{idRelatedPerson}")]

public HttpResponseMessage ReadOID (int idRelatedPerson)
{
        // CAD, CEN, EN, returnValue
        RelatedPersonRESTCAD relatedPersonRESTCAD = null;
        RelatedPersonCEN relatedPersonCEN = null;
        RelatedPersonEN relatedPersonEN = null;
        RelatedPersonDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                relatedPersonRESTCAD = new RelatedPersonRESTCAD (session);
                relatedPersonCEN = new RelatedPersonCEN (relatedPersonRESTCAD);

                // Data
                relatedPersonEN = relatedPersonCEN.ReadOID (idRelatedPerson);

                // Convert return
                if (relatedPersonEN != null) {
                        returnValue = RelatedPersonAssembler.Convert (relatedPersonEN, session);
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


[Route ("~/api/RelatedPerson/New_")]




public HttpResponseMessage New_ ( [FromBody] RelatedPersonDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        RelatedPersonRESTCAD relatedPersonRESTCAD = null;
        RelatedPersonCEN relatedPersonCEN = null;
        RelatedPersonDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                relatedPersonRESTCAD = new RelatedPersonRESTCAD (session);
                relatedPersonCEN = new RelatedPersonCEN (relatedPersonRESTCAD);

                // Create
                returnOID = relatedPersonCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        ,
                        //Atributo OID: p_scenario
                        // attr.estaRelacionado: true
                        dto.Scenario_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_userRelatedPerson
                        // attr.estaRelacionado: true
                        dto.UserRelatedPerson_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = RelatedPersonAssembler.Convert (relatedPersonRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDRelatedPerson", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/RelatedPerson/Modify")]

public HttpResponseMessage Modify (int idRelatedPerson, [FromBody] RelatedPersonDTO dto)
{
        // CAD, CEN, returnValue
        RelatedPersonRESTCAD relatedPersonRESTCAD = null;
        RelatedPersonCEN relatedPersonCEN = null;
        RelatedPersonDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                relatedPersonRESTCAD = new RelatedPersonRESTCAD (session);
                relatedPersonCEN = new RelatedPersonCEN (relatedPersonRESTCAD);

                // Modify
                relatedPersonCEN.Modify (idRelatedPerson,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = RelatedPersonAssembler.Convert (relatedPersonRESTCAD.ReadOIDDefault (idRelatedPerson), session);

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


[Route ("~/api/RelatedPerson/Destroy")]

public HttpResponseMessage Destroy (int p_relatedperson_oid)
{
        // CAD, CEN
        RelatedPersonRESTCAD relatedPersonRESTCAD = null;
        RelatedPersonCEN relatedPersonCEN = null;

        try
        {
                SessionInitializeTransaction ();


                relatedPersonRESTCAD = new RelatedPersonRESTCAD (session);
                relatedPersonCEN = new RelatedPersonCEN (relatedPersonRESTCAD);

                relatedPersonCEN.Destroy (p_relatedperson_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_RelatedPersonControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
