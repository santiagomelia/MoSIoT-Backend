

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
 *      Definition of the class AdaptationRequestCEN
 *
 */
public partial class AdaptationRequestCEN
{
private IAdaptationRequestCAD _IAdaptationRequestCAD;

public AdaptationRequestCEN()
{
        this._IAdaptationRequestCAD = new AdaptationRequestCAD ();
}

public AdaptationRequestCEN(IAdaptationRequestCAD _IAdaptationRequestCAD)
{
        this._IAdaptationRequestCAD = _IAdaptationRequestCAD;
}

public IAdaptationRequestCAD get_IAdaptationRequestCAD ()
{
        return this._IAdaptationRequestCAD;
}

public int New_ (MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum p_AccessModeTarget, int p_accessMode, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum p_languageOfAdaptation, string p_description)
{
        AdaptationRequestEN adaptationRequestEN = null;
        int oid;

        //Initialized AdaptationRequestEN
        adaptationRequestEN = new AdaptationRequestEN ();
        adaptationRequestEN.AccessModeTarget = p_AccessModeTarget;


        if (p_accessMode != -1) {
                // El argumento p_accessMode -> Property accessMode es oid = false
                // Lista de oids id
                adaptationRequestEN.AccessMode = new MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN ();
                adaptationRequestEN.AccessMode.Id = p_accessMode;
        }

        adaptationRequestEN.LanguageOfAdaptation = p_languageOfAdaptation;

        adaptationRequestEN.Description = p_description;

        //Call to AdaptationRequestCAD

        oid = _IAdaptationRequestCAD.New_ (adaptationRequestEN);
        return oid;
}

public void Modify (int p_AdaptationRequest_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum p_AccessModeTarget, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum p_languageOfAdaptation, string p_description)
{
        AdaptationRequestEN adaptationRequestEN = null;

        //Initialized AdaptationRequestEN
        adaptationRequestEN = new AdaptationRequestEN ();
        adaptationRequestEN.Id = p_AdaptationRequest_OID;
        adaptationRequestEN.AccessModeTarget = p_AccessModeTarget;
        adaptationRequestEN.LanguageOfAdaptation = p_languageOfAdaptation;
        adaptationRequestEN.Description = p_description;
        //Call to AdaptationRequestCAD

        _IAdaptationRequestCAD.Modify (adaptationRequestEN);
}

public void Destroy (int id
                     )
{
        _IAdaptationRequestCAD.Destroy (id);
}

public AdaptationRequestEN ReadOID (int id
                                    )
{
        AdaptationRequestEN adaptationRequestEN = null;

        adaptationRequestEN = _IAdaptationRequestCAD.ReadOID (id);
        return adaptationRequestEN;
}

public System.Collections.Generic.IList<AdaptationRequestEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdaptationRequestEN> list = null;

        list = _IAdaptationRequestCAD.ReadAll (first, size);
        return list;
}
}
}
