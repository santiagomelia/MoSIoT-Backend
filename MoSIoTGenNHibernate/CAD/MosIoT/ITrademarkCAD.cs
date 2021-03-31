
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface ITrademarkCAD
{
TrademarkEN ReadOIDDefault (int id
                            );

void ModifyDefault (TrademarkEN trademark);

System.Collections.Generic.IList<TrademarkEN> ReadAllDefault (int first, int size);



int New_ (TrademarkEN trademark);

void Modify (TrademarkEN trademark);


void Destroy (int id
              );


TrademarkEN ReadOID (int id
                     );


System.Collections.Generic.IList<TrademarkEN> ReadAll (int first, int size);
}
}
