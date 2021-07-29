
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMDisabilityCAD
{
IMDisabilityEN ReadOIDDefault (int id
                               );

void ModifyDefault (IMDisabilityEN iMDisability);

System.Collections.Generic.IList<IMDisabilityEN> ReadAllDefault (int first, int size);



int New_ (IMDisabilityEN iMDisability);

void Modify (IMDisabilityEN iMDisability);


void Destroy (int id
              );


IMDisabilityEN ReadOID (int id
                        );


System.Collections.Generic.IList<IMDisabilityEN> ReadAll (int first, int size);


void AssignDisability (int p_IMDisability_OID, int p_disability_OID);
}
}
