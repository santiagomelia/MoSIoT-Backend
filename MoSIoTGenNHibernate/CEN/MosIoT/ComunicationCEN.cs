

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;

using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


namespace MoSIoTGenNHibernate.CEN.MosIoT
{
/*
 *      Definition of the class ComunicationCEN
 *
 */
public partial class ComunicationCEN
{
private IComunicationCAD _IComunicationCAD;

public ComunicationCEN()
{
        this._IComunicationCAD = new ComunicationCAD ();
}

public ComunicationCEN(IComunicationCAD _IComunicationCAD)
{
        this._IComunicationCAD = _IComunicationCAD;
}

public IComunicationCAD get_IComunicationCAD ()
{
        return this._IComunicationCAD;
}

public int New_ (MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum p_severity, string p_message, Nullable<DateTime> p_sendDate)
{
        ComunicationEN comunicationEN = null;
        int oid;

        //Initialized ComunicationEN
        comunicationEN = new ComunicationEN ();
        comunicationEN.Severity = p_severity;

        comunicationEN.Message = p_message;

        comunicationEN.SendDate = p_sendDate;

        //Call to ComunicationCAD

        oid = _IComunicationCAD.New_ (comunicationEN);
        return oid;
}

public void Modify (int p_Comunication_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum p_severity, string p_message, Nullable<DateTime> p_sendDate)
{
        ComunicationEN comunicationEN = null;

        //Initialized ComunicationEN
        comunicationEN = new ComunicationEN ();
        comunicationEN.Id = p_Comunication_OID;
        comunicationEN.Severity = p_severity;
        comunicationEN.Message = p_message;
        comunicationEN.SendDate = p_sendDate;
        //Call to ComunicationCAD

        _IComunicationCAD.Modify (comunicationEN);
}

public void Destroy (int id
                     )
{
        _IComunicationCAD.Destroy (id);
}
}
}
