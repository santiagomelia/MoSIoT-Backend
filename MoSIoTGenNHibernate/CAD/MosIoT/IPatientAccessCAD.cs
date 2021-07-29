
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IPatientAccessCAD
{
PatientAccessEN ReadOIDDefault (int id
                                );

void ModifyDefault (PatientAccessEN patientAccess);

System.Collections.Generic.IList<PatientAccessEN> ReadAllDefault (int first, int size);



int New_ (PatientAccessEN patientAccess);

void Modify (PatientAccessEN patientAccess);


void Destroy (int id
              );


PatientAccessEN ReadOID (int id
                         );


System.Collections.Generic.IList<PatientAccessEN> ReadAll (int first, int size);


void AssignAccessMode (int p_PatientAccess_OID, int p_accessMode_OID);
}
}
