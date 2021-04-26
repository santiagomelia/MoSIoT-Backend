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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_IoTScenarioControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/IoTScenario")]
public class IoTScenarioController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/IoTScenario/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioCEN ioTScenarioCEN = null;

        List<IoTScenarioEN> ioTScenarioEN = null;
        List<IoTScenarioDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);
                ioTScenarioCEN = new IoTScenarioCEN (ioTScenarioRESTCAD);

                // Data
                // TODO: paginación

                ioTScenarioEN = ioTScenarioCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (ioTScenarioEN != null) {
                        returnValue = new List<IoTScenarioDTOA>();
                        foreach (IoTScenarioEN entry in ioTScenarioEN)
                                returnValue.Add (IoTScenarioAssembler.Convert (entry, session));
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
// [Route("{idIoTScenario}", Name="GetOIDIoTScenario")]

[Route ("~/api/IoTScenario/{idIoTScenario}")]

public HttpResponseMessage ReadOID (int idIoTScenario)
{
        // CAD, CEN, EN, returnValue
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioCEN ioTScenarioCEN = null;
        IoTScenarioEN ioTScenarioEN = null;
        IoTScenarioDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);
                ioTScenarioCEN = new IoTScenarioCEN (ioTScenarioRESTCAD);

                // Data
                ioTScenarioEN = ioTScenarioCEN.ReadOID (idIoTScenario);

                // Convert return
                if (ioTScenarioEN != null) {
                        returnValue = IoTScenarioAssembler.Convert (ioTScenarioEN, session);
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


[Route ("~/api/IoTScenario/New_")]




public HttpResponseMessage New_ ( [FromBody] IoTScenarioDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioCEN ioTScenarioCEN = null;
        IoTScenarioDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);
                ioTScenarioCEN = new IoTScenarioCEN (ioTScenarioRESTCAD);

                // Create
                returnOID = ioTScenarioCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = IoTScenarioAssembler.Convert (ioTScenarioRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDIoTScenario", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/IoTScenario/Modify")]

public HttpResponseMessage Modify (int idIoTScenario, [FromBody] IoTScenarioDTO dto)
{
        // CAD, CEN, returnValue
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioCEN ioTScenarioCEN = null;
        IoTScenarioDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);
                ioTScenarioCEN = new IoTScenarioCEN (ioTScenarioRESTCAD);

                // Modify
                ioTScenarioCEN.Modify (idIoTScenario,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = IoTScenarioAssembler.Convert (ioTScenarioRESTCAD.ReadOIDDefault (idIoTScenario), session);

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


[Route ("~/api/IoTScenario/Destroy")]

public HttpResponseMessage Destroy (int p_iotscenario_oid)
{
        // CAD, CEN
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioCEN ioTScenarioCEN = null;

        try
        {
                SessionInitializeTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);
                ioTScenarioCEN = new IoTScenarioCEN (ioTScenarioRESTCAD);

                ioTScenarioCEN.Destroy (p_iotscenario_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_IoTScenarioControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
