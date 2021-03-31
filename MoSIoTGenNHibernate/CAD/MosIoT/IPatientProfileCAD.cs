
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IPatientProfileCAD
{
PatientProfileEN ReadOIDDefault (int id
                                 );

void ModifyDefault (PatientProfileEN patientProfile);

System.Collections.Generic.IList<PatientProfileEN> ReadAllDefault (int first, int size);



int New_ (PatientProfileEN patientProfile);

void Modify (PatientProfileEN patientProfile);


void Destroy (int id
              );


PatientProfileEN ReadOID (int id
                          );


System.Collections.Generic.IList<PatientProfileEN> ReadAll (int first, int size);


PatientProfileEN ReadOID2 (int id
                           );


System.Collections.Generic.IList<PatientProfileEN> ReadAll2 (int first, int size);
}
}
