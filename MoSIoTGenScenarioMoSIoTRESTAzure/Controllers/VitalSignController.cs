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


/*PROTECTED REGION ID(usingMoSIoTGenScenarioMoSIoTRESTAzure_VitalSignControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenScenarioMoSIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/VitalSign")]
public class VitalSignController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/VitalSign/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        VitalSignRESTCAD vitalSignRESTCAD = null;
        VitalSignCEN vitalSignCEN = null;

        List<VitalSignEN> vitalSignEN = null;
        List<VitalSignDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                vitalSignRESTCAD = new VitalSignRESTCAD (session);
                vitalSignCEN = new VitalSignCEN (vitalSignRESTCAD);

                // Data
                // TODO: paginación

                vitalSignEN = vitalSignCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (vitalSignEN != null) {
                        returnValue = new List<VitalSignDTOA>();
                        foreach (VitalSignEN entry in vitalSignEN)
                                returnValue.Add (VitalSignAssembler.Convert (entry, session));
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





[Route ("~/api/VitalSign/VitalSignsScenario")]

public HttpResponseMessage VitalSignsScenario (int idIoTScenario)
{
        // CAD, EN
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioEN ioTScenarioEN = null;

        // returnValue
        List<VitalSignEN> en = null;
        List<VitalSignDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);

                // Exists IoTScenario
                ioTScenarioEN = ioTScenarioRESTCAD.ReadOIDDefault (idIoTScenario);
                if (ioTScenarioEN == null) throw new HttpResponseException (this.Request.CreateResponse (HttpStatusCode.NotFound, "IoTScenario#" + idIoTScenario + " not found"));

                // Rol
                // TODO: paginación


                en = ioTScenarioRESTCAD.VitalSignsScenario (idIoTScenario).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<VitalSignDTOA>();
                        foreach (VitalSignEN entry in en)
                                returnValue.Add (VitalSignAssembler.Convert (entry, session));
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
// [Route("{idVitalSign}", Name="GetOIDVitalSign")]

[Route ("~/api/VitalSign/{idVitalSign}")]

public HttpResponseMessage ReadOID (int idVitalSign)
{
        // CAD, CEN, EN, returnValue
        VitalSignRESTCAD vitalSignRESTCAD = null;
        VitalSignCEN vitalSignCEN = null;
        VitalSignEN vitalSignEN = null;
        VitalSignDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                vitalSignRESTCAD = new VitalSignRESTCAD (session);
                vitalSignCEN = new VitalSignCEN (vitalSignRESTCAD);

                // Data
                vitalSignEN = vitalSignCEN.ReadOID (idVitalSign);

                // Convert return
                if (vitalSignEN != null) {
                        returnValue = VitalSignAssembler.Convert (vitalSignEN, session);
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


[Route ("~/api/VitalSign/New_")]




public HttpResponseMessage New_ ( [FromBody] VitalSignDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        VitalSignRESTCAD vitalSignRESTCAD = null;
        VitalSignCEN vitalSignCEN = null;
        VitalSignDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                vitalSignRESTCAD = new VitalSignRESTCAD (session);
                vitalSignCEN = new VitalSignCEN (vitalSignRESTCAD);

                // Create
                returnOID = vitalSignCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        ,
                        //Atributo OID: p_scenario
                        // attr.estaRelacionado: true
                        dto.Scenario_oid                 // association role

                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        );
                SessionCommit ();

                // Convert return
                returnValue = VitalSignAssembler.Convert (vitalSignRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDVitalSign", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/VitalSign/Modify")]

public HttpResponseMessage Modify (int idVitalSign, [FromBody] VitalSignDTO dto)
{
        // CAD, CEN, returnValue
        VitalSignRESTCAD vitalSignRESTCAD = null;
        VitalSignCEN vitalSignCEN = null;
        VitalSignDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                vitalSignRESTCAD = new VitalSignRESTCAD (session);
                vitalSignCEN = new VitalSignCEN (vitalSignRESTCAD);

                // Modify
                vitalSignCEN.Modify (idVitalSign,
                        dto.Name
                        ,
                        dto.Description
                        );

                // Return modified object
                returnValue = VitalSignAssembler.Convert (vitalSignRESTCAD.ReadOIDDefault (idVitalSign), session);

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


[Route ("~/api/VitalSign/Destroy")]

public HttpResponseMessage Destroy (int p_vitalsign_oid)
{
        // CAD, CEN
        VitalSignRESTCAD vitalSignRESTCAD = null;
        VitalSignCEN vitalSignCEN = null;

        try
        {
                SessionInitializeTransaction ();


                vitalSignRESTCAD = new VitalSignRESTCAD (session);
                vitalSignCEN = new VitalSignCEN (vitalSignRESTCAD);

                vitalSignCEN.Destroy (p_vitalsign_oid);
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









/*PROTECTED REGION ID(MoSIoTGenScenarioMoSIoTRESTAzure_VitalSignControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
