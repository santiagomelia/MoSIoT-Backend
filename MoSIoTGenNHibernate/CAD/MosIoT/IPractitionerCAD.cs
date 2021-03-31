
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IPractitionerCAD
{
PractitionerEN ReadOIDDefault (int id
                               );

void ModifyDefault (PractitionerEN practitioner);

System.Collections.Generic.IList<PractitionerEN> ReadAllDefault (int first, int size);



int New_ (PractitionerEN practitioner);

void Modify (PractitionerEN practitioner);


void Destroy (int id
              );


PractitionerEN ReadOID (int id
                        );


System.Collections.Generic.IList<PractitionerEN> ReadAll (int first, int size);
}
}
