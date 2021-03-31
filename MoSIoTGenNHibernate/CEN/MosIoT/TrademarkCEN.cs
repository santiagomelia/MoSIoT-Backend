

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
 *      Definition of the class TrademarkCEN
 *
 */
public partial class TrademarkCEN
{
private ITrademarkCAD _ITrademarkCAD;

public TrademarkCEN()
{
        this._ITrademarkCAD = new TrademarkCAD ();
}

public TrademarkCEN(ITrademarkCAD _ITrademarkCAD)
{
        this._ITrademarkCAD = _ITrademarkCAD;
}

public ITrademarkCAD get_ITrademarkCAD ()
{
        return this._ITrademarkCAD;
}

public int New_ (string p_name)
{
        TrademarkEN trademarkEN = null;
        int oid;

        //Initialized TrademarkEN
        trademarkEN = new TrademarkEN ();
        trademarkEN.Name = p_name;

        //Call to TrademarkCAD

        oid = _ITrademarkCAD.New_ (trademarkEN);
        return oid;
}

public void Modify (int p_Trademark_OID, string p_name)
{
        TrademarkEN trademarkEN = null;

        //Initialized TrademarkEN
        trademarkEN = new TrademarkEN ();
        trademarkEN.Id = p_Trademark_OID;
        trademarkEN.Name = p_name;
        //Call to TrademarkCAD

        _ITrademarkCAD.Modify (trademarkEN);
}

public void Destroy (int id
                     )
{
        _ITrademarkCAD.Destroy (id);
}

public TrademarkEN ReadOID (int id
                            )
{
        TrademarkEN trademarkEN = null;

        trademarkEN = _ITrademarkCAD.ReadOID (id);
        return trademarkEN;
}

public System.Collections.Generic.IList<TrademarkEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TrademarkEN> list = null;

        list = _ITrademarkCAD.ReadAll (first, size);
        return list;
}
}
}
