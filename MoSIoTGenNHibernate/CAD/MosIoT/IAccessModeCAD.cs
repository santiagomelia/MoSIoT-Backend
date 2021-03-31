
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IAccessModeCAD
{
AccessModeEN ReadOIDDefault (int id
                             );

void ModifyDefault (AccessModeEN accessMode);

System.Collections.Generic.IList<AccessModeEN> ReadAllDefault (int first, int size);



int New_ (AccessModeEN accessMode);

void Modify (AccessModeEN accessMode);


void Destroy (int id
              );


AccessModeEN ReadOID (int id
                      );


System.Collections.Generic.IList<AccessModeEN> ReadAll (int first, int size);


void AsignarDevice (int p_AccessMode_OID, System.Collections.Generic.IList<int> p_deviceTemplate_OIDs);
}
}
