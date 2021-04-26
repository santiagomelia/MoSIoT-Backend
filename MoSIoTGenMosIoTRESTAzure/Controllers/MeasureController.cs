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


/*PROTECTED REGION ID(usingMoSIoTGenMosIoTRESTAzure_MeasureControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace MoSIoTGenMosIoTRESTAzure.Controllers
{
[RoutePrefix ("~/api/Measure")]
public class MeasureController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Measure/ReadAll")]
public HttpResponseMessage ReadAll ()
{
        // CAD, CEN, EN, returnValue
        MeasureRESTCAD measureRESTCAD = null;
        MeasureCEN measureCEN = null;

        List<MeasureEN> measureEN = null;
        List<MeasureDTOA> returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                measureRESTCAD = new MeasureRESTCAD (session);
                measureCEN = new MeasureCEN (measureRESTCAD);

                // Data
                // TODO: paginación

                measureEN = measureCEN.ReadAll (0, -1).ToList ();

                // Convert return
                if (measureEN != null) {
                        returnValue = new List<MeasureDTOA>();
                        foreach (MeasureEN entry in measureEN)
                                returnValue.Add (MeasureAssembler.Convert (entry, session));
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
// [Route("{idMeasure}", Name="GetOIDMeasure")]

[Route ("~/api/Measure/{idMeasure}")]

public HttpResponseMessage ReadOID (int idMeasure)
{
        // CAD, CEN, EN, returnValue
        MeasureRESTCAD measureRESTCAD = null;
        MeasureCEN measureCEN = null;
        MeasureEN measureEN = null;
        MeasureDTOA returnValue = null;

        try
        {
                SessionInitializeWithoutTransaction ();


                measureRESTCAD = new MeasureRESTCAD (session);
                measureCEN = new MeasureCEN (measureRESTCAD);

                // Data
                measureEN = measureCEN.ReadOID (idMeasure);

                // Convert return
                if (measureEN != null) {
                        returnValue = MeasureAssembler.Convert (measureEN, session);
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


[Route ("~/api/Measure/New_")]




public HttpResponseMessage New_ ( [FromBody] MeasureDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        MeasureRESTCAD measureRESTCAD = null;
        MeasureCEN measureCEN = null;
        MeasureDTOA returnValue = null;
        int returnOID = -1;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                measureRESTCAD = new MeasureRESTCAD (session);
                measureCEN = new MeasureCEN (measureRESTCAD);

                // Create
                returnOID = measureCEN.New_ (
                        dto.Name                                                                                 //Atributo Primitivo: p_name
                        , dto.Description                                                                                                                                                //Atributo Primitivo: p_description
                        , dto.LOINCcode                                                                                                                                                  //Atributo Primitivo: p_LOINCcode
                        );
                SessionCommit ();

                // Convert return
                returnValue = MeasureAssembler.Convert (measureRESTCAD.ReadOIDDefault (returnOID), session);
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
         * uri = Url.Link("GetOIDMeasure", routeValues);
         * response.Headers.Location = new Uri(uri);
         */

        return response;
}






[HttpPut]


[Route ("~/api/Measure/Modify")]

public HttpResponseMessage Modify (int idMeasure, [FromBody] MeasureDTO dto)
{
        // CAD, CEN, returnValue
        MeasureRESTCAD measureRESTCAD = null;
        MeasureCEN measureCEN = null;
        MeasureDTOA returnValue = null;

        // HTTP response
        HttpResponseMessage response = null;
        string uri = null;

        try
        {
                SessionInitializeTransaction ();


                measureRESTCAD = new MeasureRESTCAD (session);
                measureCEN = new MeasureCEN (measureRESTCAD);

                // Modify
                measureCEN.Modify (idMeasure,
                        dto.Name
                        ,
                        dto.Description
                        ,
                        dto.LOINCcode
                        );

                // Return modified object
                returnValue = MeasureAssembler.Convert (measureRESTCAD.ReadOIDDefault (idMeasure), session);

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


[Route ("~/api/Measure/Destroy")]

public HttpResponseMessage Destroy (int p_measure_oid)
{
        // CAD, CEN
        MeasureRESTCAD measureRESTCAD = null;
        MeasureCEN measureCEN = null;

        try
        {
                SessionInitializeTransaction ();


                measureRESTCAD = new MeasureRESTCAD (session);
                measureCEN = new MeasureCEN (measureRESTCAD);

                measureCEN.Destroy (p_measure_oid);
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





[HttpPut]


[Route ("~/api/Measure/AddTelemetries")]

public HttpResponseMessage AddTelemetries (int p_measure_oid, System.Collections.Generic.IList<int> p_telemetry_oids)
{
        // CAD, CEN, returnValue
        MeasureRESTCAD measureRESTCAD = null;
        MeasureCEN measureCEN = null;

        try
        {
                SessionInitializeTransaction ();


                measureRESTCAD = new MeasureRESTCAD (session);
                measureCEN = new MeasureCEN (measureRESTCAD);

                // Relationer
                measureCEN.AddTelemetries (p_measure_oid, p_telemetry_oids);
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

        // Return 200 - OK
        return this.Request.CreateResponse (HttpStatusCode.OK);
}







/*PROTECTED REGION ID(MoSIoTGenMosIoTRESTAzure_MeasureControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
