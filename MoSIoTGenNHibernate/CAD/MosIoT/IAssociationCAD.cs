
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IAssociationCAD
{
AssociationEN ReadOIDDefault (int id
                              );

void ModifyDefault (AssociationEN association);

System.Collections.Generic.IList<AssociationEN> ReadAllDefault (int first, int size);



int New_ (AssociationEN association);

void Modify (AssociationEN association);


void Destroy (int id
              );


AssociationEN ReadOID (int id
                       );


System.Collections.Generic.IList<AssociationEN> ReadAll (int first, int size);
}
}
