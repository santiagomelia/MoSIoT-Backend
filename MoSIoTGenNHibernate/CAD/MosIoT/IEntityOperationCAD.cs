
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IEntityOperationCAD
{
EntityOperationEN ReadOIDDefault (int id
                                  );

void ModifyDefault (EntityOperationEN entityOperation);

System.Collections.Generic.IList<EntityOperationEN> ReadAllDefault (int first, int size);



void Modify (EntityOperationEN entityOperation);


void Destroy (int id
              );


int New_ (EntityOperationEN entityOperation);

EntityOperationEN ReadOID (int id
                           );


System.Collections.Generic.IList<EntityOperationEN> ReadAll (int first, int size);
}
}
