

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
 *      Definition of the class AdaptationTypeRequiredCEN
 *
 */
public partial class AdaptationTypeRequiredCEN
{
private IAdaptationTypeRequiredCAD _IAdaptationTypeRequiredCAD;

public AdaptationTypeRequiredCEN()
{
        this._IAdaptationTypeRequiredCAD = new AdaptationTypeRequiredCAD ();
}

public AdaptationTypeRequiredCEN(IAdaptationTypeRequiredCAD _IAdaptationTypeRequiredCAD)
{
        this._IAdaptationTypeRequiredCAD = _IAdaptationTypeRequiredCAD;
}

public IAdaptationTypeRequiredCAD get_IAdaptationTypeRequiredCAD ()
{
        return this._IAdaptationTypeRequiredCAD;
}

public int New_ (MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum p_adaptionRequest, string p_description, int p_accessMode)
{
        AdaptationTypeRequiredEN adaptationTypeRequiredEN = null;
        int oid;

        //Initialized AdaptationTypeRequiredEN
        adaptationTypeRequiredEN = new AdaptationTypeRequiredEN ();
        adaptationTypeRequiredEN.AdaptionRequest = p_adaptionRequest;

        adaptationTypeRequiredEN.Description = p_description;


        if (p_accessMode != -1) {
                // El argumento p_accessMode -> Property accessMode es oid = false
                // Lista de oids id
                adaptationTypeRequiredEN.AccessMode = new MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN ();
                adaptationTypeRequiredEN.AccessMode.Id = p_accessMode;
        }

        //Call to AdaptationTypeRequiredCAD

        oid = _IAdaptationTypeRequiredCAD.New_ (adaptationTypeRequiredEN);
        return oid;
}

public void Modify (int p_AdaptationTypeRequired_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum p_adaptionRequest, string p_description)
{
        AdaptationTypeRequiredEN adaptationTypeRequiredEN = null;

        //Initialized AdaptationTypeRequiredEN
        adaptationTypeRequiredEN = new AdaptationTypeRequiredEN ();
        adaptationTypeRequiredEN.Id = p_AdaptationTypeRequired_OID;
        adaptationTypeRequiredEN.AdaptionRequest = p_adaptionRequest;
        adaptationTypeRequiredEN.Description = p_description;
        //Call to AdaptationTypeRequiredCAD

        _IAdaptationTypeRequiredCAD.Modify (adaptationTypeRequiredEN);
}

public void Destroy (int id
                     )
{
        _IAdaptationTypeRequiredCAD.Destroy (id);
}

public AdaptationTypeRequiredEN ReadOID (int id
                                         )
{
        AdaptationTypeRequiredEN adaptationTypeRequiredEN = null;

        adaptationTypeRequiredEN = _IAdaptationTypeRequiredCAD.ReadOID (id);
        return adaptationTypeRequiredEN;
}

public System.Collections.Generic.IList<AdaptationTypeRequiredEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdaptationTypeRequiredEN> list = null;

        list = _IAdaptationTypeRequiredCAD.ReadAll (first, size);
        return list;
}
}
}
