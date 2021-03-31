
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IAdaptationTypeRequiredCAD
{
AdaptationTypeRequiredEN ReadOIDDefault (int id
                                         );

void ModifyDefault (AdaptationTypeRequiredEN adaptationTypeRequired);

System.Collections.Generic.IList<AdaptationTypeRequiredEN> ReadAllDefault (int first, int size);



int New_ (AdaptationTypeRequiredEN adaptationTypeRequired);

void Modify (AdaptationTypeRequiredEN adaptationTypeRequired);


void Destroy (int id
              );


AdaptationTypeRequiredEN ReadOID (int id
                                  );


System.Collections.Generic.IList<AdaptationTypeRequiredEN> ReadAll (int first, int size);
}
}
