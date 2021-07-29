
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMTargetCAD
{
IMTargetEN ReadOIDDefault (int id
                           );

void ModifyDefault (IMTargetEN iMTarget);

System.Collections.Generic.IList<IMTargetEN> ReadAllDefault (int first, int size);



int New_ (IMTargetEN iMTarget);

void Modify (IMTargetEN iMTarget);


void Destroy (int id
              );


IMTargetEN ReadOID (int id
                    );


System.Collections.Generic.IList<IMTargetEN> ReadAll (int first, int size);


void AssignTarget (int p_IMTarget_OID, int p_target_OID);
}
}
