
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface ICarePlanCAD
{
CarePlanEN ReadOIDDefault (int id
                           );

void ModifyDefault (CarePlanEN carePlan);

System.Collections.Generic.IList<CarePlanEN> ReadAllDefault (int first, int size);



int New_ (CarePlanEN carePlan);

void Modify (CarePlanEN carePlan);


void Destroy (int id
              );


CarePlanEN ReadOID (int id
                    );


System.Collections.Generic.IList<CarePlanEN> ReadAll (int first, int size);
}
}
