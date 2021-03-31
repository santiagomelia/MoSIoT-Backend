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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_AccessModeControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/AccessMode")]
public class AccessModeController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/AccessMode/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        AccessModeRESTCAD accessModeRESTCAD = null;
        AccessModeCEN accessModeCEN = null;

        List<AccessModeEN> accessModeEN = null;
        List<AccessModeDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                accessModeRESTCAD = new AccessModeRESTCAD (session);
                accessModeCEN = new AccessModeCEN (accessModeRESTCAD);

                // Data
                // TODO: paginación

                accessModeEN = accessModeCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (accessModeEN != null) {
                        returnValue = new List<AccessModeDTOA>();
                        foreach (AccessModeEN entry in accessModeEN)
                                returnValue.Add (AccessModeAssembler.Convert (entry, session));
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
// [Route("{idAccessMode}", Name="GetOIDAccessMode")]

[Route ("~/api/AccessMode/{idAccessMode}")]

public HttpResponseMessage ReadOID (int idAccessMode)
{
        // CAD, CEN, EN, returnValue
        AccessModeRESTCAD accessModeRESTCAD = null;
        AccessModeCEN accessModeCEN = null;
        AccessModeEN accessModeEN = null;
        AccessModeDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                accessModeRESTCAD = new AccessModeRESTCAD (session);
                accessModeCEN = new AccessModeCEN (accessModeRESTCAD);

                // Data
                accessModeEN = accessModeCEN.ReadOID (idAccessMode);

                // Convert return
                if (accessModeEN != null) {
                        returnValue = AccessModeAssembler.Convert (accessModeEN, session);
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


[Route ("~/api/AccessMode/New_")]




public HttpResponseMessage New_ ( [FromBody] AccessModeDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        AccessModeRESTCAD accessModeRESTCAD = null;
        AccessModeCEN accessModeCEN = null;
        AccessModeDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                accessModeRESTCAD = new AccessModeRESTCAD (session);
                accessModeCEN = new AccessModeCEN (accessModeRESTCAD);

                // Create
                returnOID = accessModeCEN.New_ (

                        //Atributo OID: p_patient
                        // attr.estaRelacionado: true
                        dto.Patient_oid                 // association role

                        , dto.TypeAccessMode                                                                                                                                                     //Atributo Primitivo: p_typeAccessMode
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        ,
                        //Atributo OID: p_disability
                        // attr.estaRelacionado: true
                        dto.Disability_oid                 // association role

                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        );
                SessionCommit ();

                // Convert return
                returnValue = AccessModeAssembler.Convert (accessModeRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDAccessMode", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/AccessMode/Modify")]

public HttpResponseMessage Modify (int idAccessMode, [FromBody] AccessModeDTO dto)
{
        // CAD, CEN, returnValue
        AccessModeRESTCAD accessModeRESTCAD = null;
        AccessModeCEN accessModeCEN = null;
        AccessModeDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                accessModeRESTCAD = new AccessModeRESTCAD (session);
                accessModeCEN = new AccessModeCEN (accessModeRESTCAD);

                // Modify
                accessModeCEN.Modify (idAccessMode,
                        dto.TypeAccessMode
                        ,
                        dto.Description
                        ,
                        dto.Name
                        );

                // Return modified object
                returnValue = AccessModeAssembler.Convert (accessModeRESTCAD.ReadOIDDefault (idAccessMode), session);

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


[Route ("~/api/AccessMode/Destroy")]

public HttpResponseMessage Destroy (int p_accessmode_oid)
{
        // CAD, CEN
        AccessModeRESTCAD accessModeRESTCAD = null;
        AccessModeCEN accessModeCEN = null;

        try
        {
                SessionInitializeTransaction ();


                accessModeRESTCAD = new AccessModeRESTCAD (session);
                accessModeCEN = new AccessModeCEN (accessModeRESTCAD);

                accessModeCEN.Destroy (p_accessmode_oid);
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









/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_AccessModeControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
