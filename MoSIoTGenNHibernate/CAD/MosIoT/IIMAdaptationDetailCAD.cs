
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMAdaptationDetailCAD
{
IMAdaptationDetailEN ReadOIDDefault (int id
                                     );

void ModifyDefault (IMAdaptationDetailEN iMAdaptationDetail);

System.Collections.Generic.IList<IMAdaptationDetailEN> ReadAllDefault (int first, int size);



int New_ (IMAdaptationDetailEN iMAdaptationDetail);

void Modify (IMAdaptationDetailEN iMAdaptationDetail);


void Destroy (int id
              );


IMAdaptationDetailEN ReadOID (int id
                              );


System.Collections.Generic.IList<IMAdaptationDetailEN> ReadAll (int first, int size);
}
}
