
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


void AssignCarePlanTemplate (int p_PatientProfile_OID, System.Collections.Generic.IList<int> p_carePlanTemplate_OIDs);
}
}
