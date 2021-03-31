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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_CommandControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Command")]
public class CommandController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Command/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        CommandRESTCAD commandRESTCAD = null;
        CommandCEN commandCEN = null;

        List<CommandEN> commandEN = null;
        List<CommandDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                commandRESTCAD = new CommandRESTCAD (session);
                commandCEN = new CommandCEN (commandRESTCAD);

                // Data
                // TODO: paginación

                commandEN = commandCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (commandEN != null) {
                        returnValue = new List<CommandDTOA>();
                        foreach (CommandEN entry in commandEN)
                                returnValue.Add (CommandAssembler.Convert (entry, session));
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
// [Route("{idCommand}", Name="GetOIDCommand")]

[Route ("~/api/Command/{idCommand}")]

public HttpResponseMessage ReadOID (int idCommand)
{
        // CAD, CEN, EN, returnValue
        CommandRESTCAD commandRESTCAD = null;
        CommandCEN commandCEN = null;
        CommandEN commandEN = null;
        CommandDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                commandRESTCAD = new CommandRESTCAD (session);
                commandCEN = new CommandCEN (commandRESTCAD);

                // Data
                commandEN = commandCEN.ReadOID (idCommand);

                // Convert return
                if (commandEN != null) {
                        returnValue = CommandAssembler.Convert (commandEN, session);
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


[Route ("~/api/Command/New_")]




public HttpResponseMessage New_ ( [FromBody] CommandDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        CommandRESTCAD commandRESTCAD = null;
        CommandCEN commandCEN = null;
        CommandDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                commandRESTCAD = new CommandRESTCAD (session);
                commandCEN = new CommandCEN (commandRESTCAD);

                // Create
                returnOID = commandCEN.New_ (

                        //Atributo OID: p_deviceTemplate
                        // attr.estaRelacionado: true
                        dto.DeviceTemplate_oid                 // association role

                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.IsSynchronous                                                                                                                                                      //Atributo Primitivo: p_isSynchronous
                        , dto.Type                                                                                                                                                       //Atributo Primitivo: p_type
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = CommandAssembler.Convert (commandRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDCommand", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Command/Modify")]

public HttpResponseMessage Modify (int idCommand, [FromBody] CommandDTO dto)
{
        // CAD, CEN, returnValue
        CommandRESTCAD commandRESTCAD = null;
        CommandCEN commandCEN = null;
        CommandDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                commandRESTCAD = new CommandRESTCAD (session);
                commandCEN = new CommandCEN (commandRESTCAD);

                // Modify
                commandCEN.Modify (idCommand,
                        dto.Name
                        ,
                        dto.IsSynchronous
                        ,
                        dto.Type
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = CommandAssembler.Convert (commandRESTCAD.ReadOIDDefault (idCommand), session);

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


[Route ("~/api/Command/Destroy")]

public HttpResponseMessage Destroy (int p_command_oid)
{
        // CAD, CEN
        CommandRESTCAD commandRESTCAD = null;
        CommandCEN commandCEN = null;

        try
        {
                SessionInitializeTransaction ();


                commandRESTCAD = new CommandRESTCAD (session);
                commandCEN = new CommandCEN (commandRESTCAD);

                commandCEN.Destroy (p_command_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_CommandControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
