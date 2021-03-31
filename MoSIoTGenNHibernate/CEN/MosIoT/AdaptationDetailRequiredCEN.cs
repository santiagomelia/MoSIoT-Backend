

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
 *      Definition of the class AdaptationDetailRequiredCEN
 *
 */
public partial class AdaptationDetailRequiredCEN
{
private IAdaptationDetailRequiredCAD _IAdaptationDetailRequiredCAD;

public AdaptationDetailRequiredCEN()
{
        this._IAdaptationDetailRequiredCAD = new AdaptationDetailRequiredCAD ();
}

public AdaptationDetailRequiredCEN(IAdaptationDetailRequiredCAD _IAdaptationDetailRequiredCAD)
{
        this._IAdaptationDetailRequiredCAD = _IAdaptationDetailRequiredCAD;
}

public IAdaptationDetailRequiredCAD get_IAdaptationDetailRequiredCAD ()
{
        return this._IAdaptationDetailRequiredCAD;
}

public int New_ (MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationDetailValueEnum p_adaptationRequest, int p_accessMode, string p_description)
{
        AdaptationDetailRequiredEN adaptationDetailRequiredEN = null;
        int oid;

        //Initialized AdaptationDetailRequiredEN
        adaptationDetailRequiredEN = new AdaptationDetailRequiredEN ();
        adaptationDetailRequiredEN.AdaptationRequest = p_adaptationRequest;


        if (p_accessMode != -1) {
                // El argumento p_accessMode -> Property accessMode es oid = false
                // Lista de oids id
                adaptationDetailRequiredEN.AccessMode = new MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN ();
                adaptationDetailRequiredEN.AccessMode.Id = p_accessMode;
        }

        adaptationDetailRequiredEN.Description = p_description;

        //Call to AdaptationDetailRequiredCAD

        oid = _IAdaptationDetailRequiredCAD.New_ (adaptationDetailRequiredEN);
        return oid;
}

public void Modify (int p_AdaptationDetailRequired_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationDetailValueEnum p_adaptationRequest, string p_description)
{
        AdaptationDetailRequiredEN adaptationDetailRequiredEN = null;

        //Initialized AdaptationDetailRequiredEN
        adaptationDetailRequiredEN = new AdaptationDetailRequiredEN ();
        adaptationDetailRequiredEN.Id = p_AdaptationDetailRequired_OID;
        adaptationDetailRequiredEN.AdaptationRequest = p_adaptationRequest;
        adaptationDetailRequiredEN.Description = p_description;
        //Call to AdaptationDetailRequiredCAD

        _IAdaptationDetailRequiredCAD.Modify (adaptationDetailRequiredEN);
}

public void Destroy (int id
                     )
{
        _IAdaptationDetailRequiredCAD.Destroy (id);
}

public AdaptationDetailRequiredEN ReadOID (int id
                                           )
{
        AdaptationDetailRequiredEN adaptationDetailRequiredEN = null;

        adaptationDetailRequiredEN = _IAdaptationDetailRequiredCAD.ReadOID (id);
        return adaptationDetailRequiredEN;
}

public System.Collections.Generic.IList<AdaptationDetailRequiredEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdaptationDetailRequiredEN> list = null;

        list = _IAdaptationDetailRequiredCAD.ReadAll (first, size);
        return list;
}
}
}
