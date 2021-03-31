
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IRelatedPersonCAD
{
RelatedPersonEN ReadOIDDefault (int id
                                );

void ModifyDefault (RelatedPersonEN relatedPerson);

System.Collections.Generic.IList<RelatedPersonEN> ReadAllDefault (int first, int size);



int New_ (RelatedPersonEN relatedPerson);

void Modify (RelatedPersonEN relatedPerson);


void Destroy (int id
              );


RelatedPersonEN ReadOID (int id
                         );


System.Collections.Generic.IList<RelatedPersonEN> ReadAll (int first, int size);
}
}
