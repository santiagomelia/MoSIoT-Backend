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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_DeviceControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Device")]
public class DeviceController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Device/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        DeviceRESTCAD deviceRESTCAD = null;
        DeviceCEN deviceCEN = null;

        List<DeviceEN> deviceEN = null;
        List<DeviceDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                deviceRESTCAD = new DeviceRESTCAD (session);
                deviceCEN = new DeviceCEN (deviceRESTCAD);

                // Data
                // TODO: paginación

                deviceEN = deviceCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (deviceEN != null) {
                        returnValue = new List<DeviceDTOA>();
                        foreach (DeviceEN entry in deviceEN)
                                returnValue.Add (DeviceAssembler.Convert (entry, session));
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





[Route ("~/api/Device/DevicesScenario")]

public HttpResponseMessage DevicesScenario (int idIoTScenario)
{
        // CAD, EN
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioEN ioTScenarioEN = null;

        // returnValue
        List<DeviceEN> en = null;
        List<DeviceDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);

                // Exists IoTScenario
                ioTScenarioEN = ioTScenarioRESTCAD.ReadOIDDefault (idIoTScenario);
                if (ioTScenarioEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IoTScenario#" + idIoTScenario + " not found"));

                // Rol
                // TODO: paginación


                en = ioTScenarioRESTCAD.DevicesScenario (idIoTScenario).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<DeviceDTOA>();
                        foreach (DeviceEN entry in en)
                                returnValue.Add (DeviceAssembler.Convert (entry, session));
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
// [Route("{idDevice}", Name="GetOIDDevice")]

[Route ("~/api/Device/{idDevice}")]

public HttpResponseMessage ReadOID (int idDevice)
{
        // CAD, CEN, EN, returnValue
        DeviceRESTCAD deviceRESTCAD = null;
        DeviceCEN deviceCEN = null;
        DeviceEN deviceEN = null;
        DeviceDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                deviceRESTCAD = new DeviceRESTCAD (session);
                deviceCEN = new DeviceCEN (deviceRESTCAD);

                // Data
                deviceEN = deviceCEN.ReadOID (idDevice);

                // Convert return
                if (deviceEN != null) {
                        returnValue = DeviceAssembler.Convert (deviceEN, session);
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


[Route ("~/api/Device/New_")]




public HttpResponseMessage New_ ( [FromBody] DeviceDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        DeviceRESTCAD deviceRESTCAD = null;
        DeviceCEN deviceCEN = null;
        DeviceDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                deviceRESTCAD = new DeviceRESTCAD (session);
                deviceCEN = new DeviceCEN (deviceRESTCAD);

                // Create
                returnOID = deviceCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        ,
                        //Atributo OID: p_scenario
                        // attr.estaRelacionado: true
                        dto.Scenario_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        , dto.DeviceSwitch                                                                                                                                                       //Atributo Primitivo: p_deviceSwitch
                        , dto.Tag                                                                                                                                                //Atributo Primitivo: p_tag
                        , dto.IsSimulated                                                                                                                                                //Atributo Primitivo: p_isSimulated
                        , dto.SerialNumber                                                                                                                                                       //Atributo Primitivo: p_serialNumber
                        , dto.FirmVersion                                                                                                                                                //Atributo Primitivo: p_firmVersion
                        , dto.Trademark                                                                                                                                                  //Atributo Primitivo: p_trademark
                        );
                SessionCommit ();

                // Convert return
                returnValue = DeviceAssembler.Convert (deviceRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDDevice", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Device/Modify")]

public HttpResponseMessage Modify (int idDevice, [FromBody] DeviceDTO dto)
{
        // CAD, CEN, returnValue
        DeviceRESTCAD deviceRESTCAD = null;
        DeviceCEN deviceCEN = null;
        DeviceDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                deviceRESTCAD = new DeviceRESTCAD (session);
                deviceCEN = new DeviceCEN (deviceRESTCAD);

                // Modify
                deviceCEN.Modify (idDevice,
                        dto.Name
                        ,
                        dto.Description
                        ,
                        dto.DeviceSwitch
                        ,
                        dto.Tag
                        ,
                        dto.IsSimulated
                        ,
                        dto.SerialNumber
                        ,
                        dto.FirmVersion
                        ,
                        dto.Trademark
                        );

                // Return modified object
                returnValue = DeviceAssembler.Convert (deviceRESTCAD.ReadOIDDefault (idDevice), session);

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


[Route ("~/api/Device/Destroy")]

public HttpResponseMessage Destroy (int p_device_oid)
{
        // CAD, CEN
        DeviceRESTCAD deviceRESTCAD = null;
        DeviceCEN deviceCEN = null;

        try
        {
                SessionInitializeTransaction ();


                deviceRESTCAD = new DeviceRESTCAD (session);
                deviceCEN = new DeviceCEN (deviceRESTCAD);

                deviceCEN.Destroy (p_device_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_DeviceControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
