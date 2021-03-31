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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_UserControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/User")]
public class UserController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/User/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        UserRESTCAD userRESTCAD = null;
        UserCEN userCEN = null;

        List<UserEN> userEN = null;
        List<UserDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                userRESTCAD = new UserRESTCAD (session);
                userCEN = new UserCEN (userRESTCAD);

                // Data
                // TODO: paginación

                userEN = userCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (userEN != null) {
                        returnValue = new List<UserDTOA>();
                        foreach (UserEN entry in userEN)
                                returnValue.Add (UserAssembler.Convert (entry, session));
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
// [Route("{idUser}", Name="GetOIDUser")]

[Route ("~/api/User/{idUser}")]

public HttpResponseMessage ReadOID (int idUser)
{
        // CAD, CEN, EN, returnValue
        UserRESTCAD userRESTCAD = null;
        UserCEN userCEN = null;
        UserEN userEN = null;
        UserDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                userRESTCAD = new UserRESTCAD (session);
                userCEN = new UserCEN (userRESTCAD);

                // Data
                userEN = userCEN.ReadOID (idUser);

                // Convert return
                if (userEN != null) {
                        returnValue = UserAssembler.Convert (userEN, session);
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


[Route ("~/api/User/New_")]




public HttpResponseMessage New_ ( [FromBody] UserDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        UserRESTCAD userRESTCAD = null;
        UserCEN userCEN = null;
        UserDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                userRESTCAD = new UserRESTCAD (session);
                userCEN = new UserCEN (userRESTCAD);

                // Create
                returnOID = userCEN.New_ (
                        dto.Surnames                                                                             //Atributo Primitivo: p_surnames
                        , dto.IsActive                                                                                                                                                   //Atributo Primitivo: p_isActive
                        , dto.IsDiseased                                                                                                                                                 //Atributo Primitivo: p_isDiseased
                        , dto.Pass                                                                                                                                                       //Atributo Primitivo: p_pass
                        , dto.Name                                                                                                                                                       //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        , dto.Email                                                                                                                                                      //Atributo Primitivo: p_email
                        );
                SessionCommit ();

                // Convert return
                returnValue = UserAssembler.Convert (userRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDUser", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}


















/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_UserControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
