
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IAdaptationRequestCAD
{
AdaptationRequestEN ReadOIDDefault (int id
                                    );

void ModifyDefault (AdaptationRequestEN adaptationRequest);

System.Collections.Generic.IList<AdaptationRequestEN> ReadAllDefault (int first, int size);



int New_ (AdaptationRequestEN adaptationRequest);

void Modify (AdaptationRequestEN adaptationRequest);


void Destroy (int id
              );


AdaptationRequestEN ReadOID (int id
                             );


System.Collections.Generic.IList<AdaptationRequestEN> ReadAll (int first, int size);
}
}
