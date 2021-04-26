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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_AssociationControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Association")]
public class AssociationController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Association/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        AssociationRESTCAD associationRESTCAD = null;
        AssociationCEN associationCEN = null;

        List<AssociationEN> associationEN = null;
        List<AssociationDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                associationRESTCAD = new AssociationRESTCAD (session);
                associationCEN = new AssociationCEN (associationRESTCAD);

                // Data
                // TODO: paginación

                associationEN = associationCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (associationEN != null) {
                        returnValue = new List<AssociationDTOA>();
                        foreach (AssociationEN entry in associationEN)
                                returnValue.Add (AssociationAssembler.Convert (entry, session));
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
// [Route("{idAssociation}", Name="GetOIDAssociation")]

[Route ("~/api/Association/{idAssociation}")]

public HttpResponseMessage ReadOID (int idAssociation)
{
        // CAD, CEN, EN, returnValue
        AssociationRESTCAD associationRESTCAD = null;
        AssociationCEN associationCEN = null;
        AssociationEN associationEN = null;
        AssociationDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                associationRESTCAD = new AssociationRESTCAD (session);
                associationCEN = new AssociationCEN (associationRESTCAD);

                // Data
                associationEN = associationCEN.ReadOID (idAssociation);

                // Convert return
                if (associationEN != null) {
                        returnValue = AssociationAssembler.Convert (associationEN, session);
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


[Route ("~/api/Association/New_")]




public HttpResponseMessage New_ ( [FromBody] AssociationDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        AssociationRESTCAD associationRESTCAD = null;
        AssociationCEN associationCEN = null;
        AssociationDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                associationRESTCAD = new AssociationRESTCAD (session);
                associationCEN = new AssociationCEN (associationRESTCAD);

                // Create
                returnOID = associationCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        ,
                        //Atributo OID: p_rolOrigin
                        // attr.estaRelacionado: true
                        dto.RolOrigin_oid                 // association role

                        ,
                        //Atributo OID: p_rolTarget
                        // attr.estaRelacionado: true
                        dto.RolTarget_oid                 // association role

                        , dto.Type                                                                                                                                                       //Atributo Primitivo: p_type
                        , dto.CardinalityOrigin                                                                                                                                                  //Atributo Primitivo: p_cardinalityOrigin
                        , dto.CardinalityTarget                                                                                                                                                  //Atributo Primitivo: p_cardinalityTarget
                        ,
                        //Atributo OID: p_entityOrigin
                        // attr.estaRelacionado: true
                        dto.EntityOrigin_oid                 // association role

                        ,
                        //Atributo OID: p_entityTarget
                        // attr.estaRelacionado: true
                        dto.EntityTarget_oid                 // association role

                        ,
                        //Atributo OID: p_ioTScenario
                        // attr.estaRelacionado: true
                        dto.IoTScenario_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = AssociationAssembler.Convert (associationRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDAssociation", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Association/Modify")]

public HttpResponseMessage Modify (int idAssociation, [FromBody] AssociationDTO dto)
{
        // CAD, CEN, returnValue
        AssociationRESTCAD associationRESTCAD = null;
        AssociationCEN associationCEN = null;
        AssociationDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                associationRESTCAD = new AssociationRESTCAD (session);
                associationCEN = new AssociationCEN (associationRESTCAD);

                // Modify
                associationCEN.Modify (idAssociation,
                        dto.Name
                        ,
                        dto.Type
                        ,
                        dto.CardinalityOrigin
                        ,
                        dto.CardinalityTarget
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = AssociationAssembler.Convert (associationRESTCAD.ReadOIDDefault (idAssociation), session);

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


[Route ("~/api/Association/Destroy")]

public HttpResponseMessage Destroy (int p_association_oid)
{
        // CAD, CEN
        AssociationRESTCAD associationRESTCAD = null;
        AssociationCEN associationCEN = null;

        try
        {
                SessionInitializeTransaction ();


                associationRESTCAD = new AssociationRESTCAD (session);
                associationCEN = new AssociationCEN (associationRESTCAD);

                associationCEN.Destroy (p_association_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_AssociationControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
