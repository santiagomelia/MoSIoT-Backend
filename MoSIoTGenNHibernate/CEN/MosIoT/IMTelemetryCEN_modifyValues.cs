
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


/*PROTECTED REGION ID(usingMoSIoTGenNHibernate.CEN.MosIoT_IMTelemetry_modifyValues) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MoSIoTGenNHibernate.CEN.MosIoT
{
public partial class IMTelemetryCEN
{
public void ModifyValues (int p_IMTelemetry_OID, Nullable<DateTime> p_timeStamp, string p_value)
{
        /*PROTECTED REGION ID(MoSIoTGenNHibernate.CEN.MosIoT_IMTelemetry_modifyValues_customized) START*/

        IMTelemetryEN iMTelemetryEN = null;

        //Initialized IMTelemetryEN
        iMTelemetryEN = new IMTelemetryEN ();
        iMTelemetryEN.Id = p_IMTelemetry_OID;
        iMTelemetryEN.TimeStamp = p_timeStamp;
        iMTelemetryEN.Value = p_value;
        //Call to IMTelemetryCAD

        _IIMTelemetryCAD.ModifyValues (iMTelemetryEN);

        /*PROTECTED REGION END*/
}
}
}
