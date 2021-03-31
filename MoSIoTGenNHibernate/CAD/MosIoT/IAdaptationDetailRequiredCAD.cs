
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IAdaptationDetailRequiredCAD
{
AdaptationDetailRequiredEN ReadOIDDefault (int id
                                           );

void ModifyDefault (AdaptationDetailRequiredEN adaptationDetailRequired);

System.Collections.Generic.IList<AdaptationDetailRequiredEN> ReadAllDefault (int first, int size);



int New_ (AdaptationDetailRequiredEN adaptationDetailRequired);

void Modify (AdaptationDetailRequiredEN adaptationDetailRequired);


void Destroy (int id
              );


AdaptationDetailRequiredEN ReadOID (int id
                                    );


System.Collections.Generic.IList<AdaptationDetailRequiredEN> ReadAll (int first, int size);
}
}
