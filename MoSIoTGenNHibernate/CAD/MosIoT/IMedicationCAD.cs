
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IMedicationCAD
{
MedicationEN ReadOIDDefault (int productReference
                             );

void ModifyDefault (MedicationEN medication);

System.Collections.Generic.IList<MedicationEN> ReadAllDefault (int first, int size);



int New_ (MedicationEN medication);

void Modify (MedicationEN medication);


void Destroy (int productReference
              );


MedicationEN ReadOID (int productReference
                      );


System.Collections.Generic.IList<MedicationEN> ReadAll (int first, int size);
}
}
