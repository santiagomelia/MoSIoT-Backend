
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


/*PROTECTED REGION ID(usingMoSIoTGenNHibernate.CEN.MosIoT_IMTelemetry_readTelemetry) ENABLED START*/
//  references to other libraries
//using System.Threading.Tasks;
//using Newtonsoft.Json.Linq;
//using Newtonsoft.Json;
/*PROTECTED REGION END*/

namespace MoSIoTGenNHibernate.CEN.MosIoT
{
public partial class IMTelemetryCEN
{
public string ReadTelemetry (int p_oid)
{
        /*PROTECTED REGION ID(MoSIoTGenNHibernate.CEN.MosIoT_IMTelemetry_readTelemetry) ENABLED START*/

        IMTelemetryEN tel = _IIMTelemetryCAD.ReadOIDDefault (p_oid);

        //IoTCentralAdapterREST iotAdapter = new IoTCentralAdapterREST ();


        //    Task<JObject> task = iotAdapter.ListarDeviceTelemetry("1qsi9p8t5l2", tel.Name);

        //    string resultado = JsonConvert.SerializeObject(task.Result, Formatting.None);

        //    Console.WriteLine("Resultado: " +resultado);


        return "";

        /*PROTECTED REGION END*/
}
}
}
