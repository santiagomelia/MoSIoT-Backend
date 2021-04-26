
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMAdaptationTypeCAD
{
IMAdaptationTypeEN ReadOIDDefault (int id
                                   );

void ModifyDefault (IMAdaptationTypeEN iMAdaptationType);

System.Collections.Generic.IList<IMAdaptationTypeEN> ReadAllDefault (int first, int size);



int New_ (IMAdaptationTypeEN iMAdaptationType);

void Modify (IMAdaptationTypeEN iMAdaptationType);


void Destroy (int id
              );


IMAdaptationTypeEN ReadOID (int id
                            );


System.Collections.Generic.IList<IMAdaptationTypeEN> ReadAll (int first, int size);
}
}
