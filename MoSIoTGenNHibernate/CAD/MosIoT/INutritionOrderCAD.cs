
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface INutritionOrderCAD
{
NutritionOrderEN ReadOIDDefault (int id
                                 );

void ModifyDefault (NutritionOrderEN nutritionOrder);

System.Collections.Generic.IList<NutritionOrderEN> ReadAllDefault (int first, int size);



int New_ (NutritionOrderEN nutritionOrder);

void Modify (NutritionOrderEN nutritionOrder);


void Destroy (int id
              );


NutritionOrderEN ReadOID (int id
                          );


System.Collections.Generic.IList<NutritionOrderEN> ReadAll (int first, int size);
}
}
