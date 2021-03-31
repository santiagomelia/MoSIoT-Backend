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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_PropertyControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Property")]
public class PropertyController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Property/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        PropertyRESTCAD propertyRESTCAD = null;
        PropertyCEN propertyCEN = null;

        List<PropertyEN> propertyEN = null;
        List<PropertyDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                propertyRESTCAD = new PropertyRESTCAD (session);
                propertyCEN = new PropertyCEN (propertyRESTCAD);

                // Data
                // TODO: paginación

                propertyEN = propertyCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (propertyEN != null) {
                        returnValue = new List<PropertyDTOA>();
                        foreach (PropertyEN entry in propertyEN)
                                returnValue.Add (PropertyAssembler.Convert (entry, session));
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
// [Route("{idProperty}", Name="GetOIDProperty")]

[Route ("~/api/Property/{idProperty}")]

public HttpResponseMessage ReadOID (int idProperty)
{
        // CAD, CEN, EN, returnValue
        PropertyRESTCAD propertyRESTCAD = null;
        PropertyCEN propertyCEN = null;
        PropertyEN propertyEN = null;
        PropertyDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                propertyRESTCAD = new PropertyRESTCAD (session);
                propertyCEN = new PropertyCEN (propertyRESTCAD);

                // Data
                propertyEN = propertyCEN.ReadOID (idProperty);

                // Convert return
                if (propertyEN != null) {
                        returnValue = PropertyAssembler.Convert (propertyEN, session);
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


[Route ("~/api/Property/New_")]




public HttpResponseMessage New_ ( [FromBody] PropertyDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        PropertyRESTCAD propertyRESTCAD = null;
        PropertyCEN propertyCEN = null;
        PropertyDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                propertyRESTCAD = new PropertyRESTCAD (session);
                propertyCEN = new PropertyCEN (propertyRESTCAD);

                // Create
                returnOID = propertyCEN.New_ (

                        //Atributo OID: p_deviceTemplate
                        // attr.estaRelacionado: true
                        dto.DeviceTemplate_oid                 // association role

                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.IsWritable                                                                                                                                                 //Atributo Primitivo: p_isWritable
                        , dto.IsCloudable                                                                                                                                                //Atributo Primitivo: p_isCloudable
                        );
                SessionCommit ();

                // Convert return
                returnValue = PropertyAssembler.Convert (propertyRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDProperty", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Property/Modify")]

public HttpResponseMessage Modify (int idProperty, [FromBody] PropertyDTO dto)
{
        // CAD, CEN, returnValue
        PropertyRESTCAD propertyRESTCAD = null;
        PropertyCEN propertyCEN = null;
        PropertyDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                propertyRESTCAD = new PropertyRESTCAD (session);
                propertyCEN = new PropertyCEN (propertyRESTCAD);

                // Modify
                propertyCEN.Modify (idProperty,
                        dto.Name
                        ,
                        dto.IsWritable
                        ,
                        dto.IsCloudable
                        );

                // Return modified object
                returnValue = PropertyAssembler.Convert (propertyRESTCAD.ReadOIDDefault (idProperty), session);

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


[Route ("~/api/Property/Destroy")]

public HttpResponseMessage Destroy (int p_property_oid)
{
        // CAD, CEN
        PropertyRESTCAD propertyRESTCAD = null;
        PropertyCEN propertyCEN = null;

        try
        {
                SessionInitializeTransaction ();


                propertyRESTCAD = new PropertyRESTCAD (session);
                propertyCEN = new PropertyCEN (propertyRESTCAD);

                propertyCEN.Destroy (p_property_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_PropertyControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
