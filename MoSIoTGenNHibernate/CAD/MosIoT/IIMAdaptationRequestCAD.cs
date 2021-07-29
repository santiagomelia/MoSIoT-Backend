
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMAdaptationRequestCAD
{
IMAdaptationRequestEN ReadOIDDefault (int id
                                      );

void ModifyDefault (IMAdaptationRequestEN iMAdaptationRequest);

System.Collections.Generic.IList<IMAdaptationRequestEN> ReadAllDefault (int first, int size);



int New_ (IMAdaptationRequestEN iMAdaptationRequest);

void Modify (IMAdaptationRequestEN iMAdaptationRequest);


void Destroy (int id
              );


IMAdaptationRequestEN ReadOID (int id
                               );


System.Collections.Generic.IList<IMAdaptationRequestEN> ReadAll (int first, int size);


void AssignAdaptationR (int p_IMAdaptationRequest_OID, int p_adaptationRequest_OID);
}
}
