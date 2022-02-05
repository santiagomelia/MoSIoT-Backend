
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IUserCAD
{
UserEN ReadOIDDefault (int id
                       );

void ModifyDefault (UserEN user);

System.Collections.Generic.IList<UserEN> ReadAllDefault (int first, int size);



void Destroy (int id
              );


UserEN ReadOID (int id
                );


System.Collections.Generic.IList<UserEN> ReadAll (int first, int size);



int New_ (UserEN user);

void Modify (UserEN user);


System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.UserEN> DamePorEmail (string p_email);
}
}
