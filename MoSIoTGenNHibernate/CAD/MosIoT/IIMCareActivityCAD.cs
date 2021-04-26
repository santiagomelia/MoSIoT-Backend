
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMCareActivityCAD
{
IMCareActivityEN ReadOIDDefault (int id
                                 );

void ModifyDefault (IMCareActivityEN iMCareActivity);

System.Collections.Generic.IList<IMCareActivityEN> ReadAllDefault (int first, int size);



int New_ (IMCareActivityEN iMCareActivity);

void Modify (IMCareActivityEN iMCareActivity);


void Destroy (int id
              );


IMCareActivityEN ReadOID (int id
                          );


System.Collections.Generic.IList<IMCareActivityEN> ReadAll (int first, int size);
}
}
