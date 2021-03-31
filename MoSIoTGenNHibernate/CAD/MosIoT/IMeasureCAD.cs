
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IMeasureCAD
{
MeasureEN ReadOIDDefault (int id
                          );

void ModifyDefault (MeasureEN measure);

System.Collections.Generic.IList<MeasureEN> ReadAllDefault (int first, int size);



int New_ (MeasureEN measure);

void Modify (MeasureEN measure);


void Destroy (int id
              );


MeasureEN ReadOID (int id
                   );


System.Collections.Generic.IList<MeasureEN> ReadAll (int first, int size);
}
}
