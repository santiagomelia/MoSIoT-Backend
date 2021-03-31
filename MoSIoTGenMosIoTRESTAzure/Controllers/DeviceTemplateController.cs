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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_DeviceTemplateControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/DeviceTemplate")]
public class DeviceTemplateController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/DeviceTemplate/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        DeviceTemplateRESTCAD deviceTemplateRESTCAD = null;
        DeviceTemplateCEN deviceTemplateCEN = null;

        List<DeviceTemplateEN> deviceTemplateEN = null;
        List<DeviceTemplateDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                deviceTemplateRESTCAD = new DeviceTemplateRESTCAD (session);
                deviceTemplateCEN = new DeviceTemplateCEN (deviceTemplateRESTCAD);

                // Data
                // TODO: paginación

                deviceTemplateEN = deviceTemplateCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (deviceTemplateEN != null) {
                        returnValue = new List<DeviceTemplateDTOA>();
                        foreach (DeviceTemplateEN entry in deviceTemplateEN)
                                returnValue.Add (DeviceTemplateAssembler.Convert (entry, session));
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





[Route ("~/api/DeviceTemplate/DeviceTemplateByAccessMode")]

public HttpResponseMessage DeviceTemplateByAccessMode (int idAccessMode)
{
        // CAD, EN
        AccessModeRESTCAD accessModeRESTCAD = null;
        AccessModeEN accessModeEN = null;

        // returnValue
        List<DeviceTemplateEN> en = null;
        List<DeviceTemplateDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                accessModeRESTCAD = new AccessModeRESTCAD (session);

                // Exists AccessMode
                accessModeEN = accessModeRESTCAD.ReadOIDDefault (idAccessMode);
                if (accessModeEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "AccessMode#" + idAccessMode + " not found"));

                // Rol
                // TODO: paginación


                en = accessModeRESTCAD.DeviceTemplateByAccessMode (idAccessMode).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<DeviceTemplateDTOA>();
                        foreach (DeviceTemplateEN entry in en)
                                returnValue.Add (DeviceTemplateAssembler.Convert (entry, session));
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
// [Route("{idDeviceTemplate}", Name="GetOIDDeviceTemplate")]

[Route ("~/api/DeviceTemplate/{idDeviceTemplate}")]

public HttpResponseMessage ReadOID (int idDeviceTemplate)
{
        // CAD, CEN, EN, returnValue
        DeviceTemplateRESTCAD deviceTemplateRESTCAD = null;
        DeviceTemplateCEN deviceTemplateCEN = null;
        DeviceTemplateEN deviceTemplateEN = null;
        DeviceTemplateDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                deviceTemplateRESTCAD = new DeviceTemplateRESTCAD (session);
                deviceTemplateCEN = new DeviceTemplateCEN (deviceTemplateRESTCAD);

                // Data
                deviceTemplateEN = deviceTemplateCEN.ReadOID (idDeviceTemplate);

                // Convert return
                if (deviceTemplateEN != null) {
                        returnValue = DeviceTemplateAssembler.Convert (deviceTemplateEN, session);
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


[Route ("~/api/DeviceTemplate/New_")]




public HttpResponseMessage New_ ( [FromBody] DeviceTemplateDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        DeviceTemplateRESTCAD deviceTemplateRESTCAD = null;
        DeviceTemplateCEN deviceTemplateCEN = null;
        DeviceTemplateDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                deviceTemplateRESTCAD = new DeviceTemplateRESTCAD (session);
                deviceTemplateCEN = new DeviceTemplateCEN (deviceTemplateRESTCAD);

                // Create
                returnOID = deviceTemplateCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Type                                                                                                                                                       //Atributo Primitivo: p_type
                        , dto.IsEdge                                                                                                                                                     //Atributo Primitivo: p_isEdge
                        );
                SessionCommit ();

                // Convert return
                returnValue = DeviceTemplateAssembler.Convert (deviceTemplateRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDDeviceTemplate", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/DeviceTemplate/Modify")]

public HttpResponseMessage Modify (int idDeviceTemplate, [FromBody] DeviceTemplateDTO dto)
{
        // CAD, CEN, returnValue
        DeviceTemplateRESTCAD deviceTemplateRESTCAD = null;
        DeviceTemplateCEN deviceTemplateCEN = null;
        DeviceTemplateDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                deviceTemplateRESTCAD = new DeviceTemplateRESTCAD (session);
                deviceTemplateCEN = new DeviceTemplateCEN (deviceTemplateRESTCAD);

                // Modify
                deviceTemplateCEN.Modify (idDeviceTemplate,
                        dto.Name
                        ,
                        dto.Type
                        ,
                        dto.IsEdge
                        );

                // Return modified object
                returnValue = DeviceTemplateAssembler.Convert (deviceTemplateRESTCAD.ReadOIDDefault (idDeviceTemplate), session);

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


[Route ("~/api/DeviceTemplate/Destroy")]

public HttpResponseMessage Destroy (int p_devicetemplate_oid)
{
        // CAD, CEN
        DeviceTemplateRESTCAD deviceTemplateRESTCAD = null;
        DeviceTemplateCEN deviceTemplateCEN = null;

        try
        {
                SessionInitializeTransaction ();


                deviceTemplateRESTCAD = new DeviceTemplateRESTCAD (session);
                deviceTemplateCEN = new DeviceTemplateCEN (deviceTemplateRESTCAD);

                deviceTemplateCEN.Destroy (p_devicetemplate_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_DeviceTemplateControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
