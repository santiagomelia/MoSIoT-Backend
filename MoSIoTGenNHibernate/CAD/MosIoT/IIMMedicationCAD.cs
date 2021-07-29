
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMMedicationCAD
{
IMMedicationEN ReadOIDDefault (int id
                               );

void ModifyDefault (IMMedicationEN iMMedication);

System.Collections.Generic.IList<IMMedicationEN> ReadAllDefault (int first, int size);



int New_ (IMMedicationEN iMMedication);

void Modify (IMMedicationEN iMMedication);


void Destroy (int id
              );


IMMedicationEN ReadOID (int id
                        );


System.Collections.Generic.IList<IMMedicationEN> ReadAll (int first, int size);


void AssignMedication (int p_IMMedication_OID, int p_medication_OID);
}
}
