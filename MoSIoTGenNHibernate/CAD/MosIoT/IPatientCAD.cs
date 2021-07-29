
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IPatientCAD
{
PatientEN ReadOIDDefault (int id
                          );

void ModifyDefault (PatientEN patient);

System.Collections.Generic.IList<PatientEN> ReadAllDefault (int first, int size);



int New_ (PatientEN patient);

void Modify (PatientEN patient);


void Destroy (int id
              );


PatientEN ReadOID (int id
                   );


System.Collections.Generic.IList<PatientEN> ReadAll (int first, int size);


void AssignPatientProfile (int p_Patient_OID, int p_patientProfile_OID);
}
}
