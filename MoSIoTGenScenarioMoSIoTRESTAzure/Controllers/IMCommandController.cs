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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IMCommandControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IMCommand")]
public class IMCommandController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IMCommand/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IMCommandRESTCAD iMCommandRESTCAD = null;
        IMCommandCEN iMCommandCEN = null;

        List<IMCommandEN> iMCommandEN = null;
        List<IMCommandDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMCommandRESTCAD = new IMCommandRESTCAD (session);
                iMCommandCEN = new IMCommandCEN (iMCommandRESTCAD);

                // Data
                // TODO: paginación

                iMCommandEN = iMCommandCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (iMCommandEN != null) {
                        returnValue = new List<IMCommandDTOA>();
                        foreach (IMCommandEN entry in iMCommandEN)
                                returnValue.Add (IMCommandAssembler.Convert (entry, session));
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
// [Route("{idIMCommand}", Name="GetOIDIMCommand")]

[Route ("~/api/IMCommand/{idIMCommand}")]

public HttpResponseMessage ReadOID (int idIMCommand)
{
        // CAD, CEN, EN, returnValue
        IMCommandRESTCAD iMCommandRESTCAD = null;
        IMCommandCEN iMCommandCEN = null;
        IMCommandEN iMCommandEN = null;
        IMCommandDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                iMCommandRESTCAD = new IMCommandRESTCAD (session);
                iMCommandCEN = new IMCommandCEN (iMCommandRESTCAD);

                // Data
                iMCommandEN = iMCommandCEN.ReadOID (idIMCommand);

                // Convert return
                if (iMCommandEN != null) {
                        returnValue = IMCommandAssembler.Convert (iMCommandEN, session);
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


[Route ("~/api/IMCommand/New_")]




public HttpResponseMessage New_ ( [FromBody] IMCommandDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IMCommandRESTCAD iMCommandRESTCAD = null;
        IMCommandCEN iMCommandCEN = null;
        IMCommandDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMCommandRESTCAD = new IMCommandRESTCAD (session);
                iMCommandCEN = new IMCommandCEN (iMCommandRESTCAD);

                // Create
                returnOID = iMCommandCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Type                                                                                                                                                       //Atributo Primitivo: p_type
                        , dto.ServiceType                                                                                                                                                //Atributo Primitivo: p_serviceType
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_entity
                        // attr.estaRelacionado: true
                        dto.Entity_oid                 // association role

                        ,
                        //Atributo OID: p_command
                        // attr.estaRelacionado: true
                        dto.Command_oid                 // association role

                        );
                SessionCommit ();

                // Convert return
                returnValue = IMCommandAssembler.Convert (iMCommandRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIMCommand", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IMCommand/Modify")]

public HttpResponseMessage Modify (int idIMCommand, [FromBody] IMCommandDTO dto)
{
        // CAD, CEN, returnValue
        IMCommandRESTCAD iMCommandRESTCAD = null;
        IMCommandCEN iMCommandCEN = null;
        IMCommandDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                iMCommandRESTCAD = new IMCommandRESTCAD (session);
                iMCommandCEN = new IMCommandCEN (iMCommandRESTCAD);

                // Modify
                iMCommandCEN.Modify (idIMCommand,
                        dto.Name
                        ,
                        dto.Type
                        ,
                        dto.ServiceType
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IMCommandAssembler.Convert (iMCommandRESTCAD.ReadOIDDefault (idIMCommand), session);

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


[Route ("~/api/IMCommand/Destroy")]

public HttpResponseMessage Destroy (int p_imcommand_oid)
{
        // CAD, CEN
        IMCommandRESTCAD iMCommandRESTCAD = null;
        IMCommandCEN iMCommandCEN = null;

        try
        {
                SessionInitializeTransaction ();


                iMCommandRESTCAD = new IMCommandRESTCAD (session);
                iMCommandCEN = new IMCommandCEN (iMCommandRESTCAD);

                iMCommandCEN.Destroy (p_imcommand_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IMCommandControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
