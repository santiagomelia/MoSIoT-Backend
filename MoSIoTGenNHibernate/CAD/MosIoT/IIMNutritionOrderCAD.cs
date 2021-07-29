
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMNutritionOrderCAD
{
IMNutritionOrderEN ReadOIDDefault (int id
                                   );

void ModifyDefault (IMNutritionOrderEN iMNutritionOrder);

System.Collections.Generic.IList<IMNutritionOrderEN> ReadAllDefault (int first, int size);



int New_ (IMNutritionOrderEN iMNutritionOrder);

void Modify (IMNutritionOrderEN iMNutritionOrder);


void Destroy (int id
              );


IMNutritionOrderEN ReadOID (int id
                            );


System.Collections.Generic.IList<IMNutritionOrderEN> ReadAll (int first, int size);


void AssignNutrition (int p_IMNutritionOrder_OID, int p_nutritionOrder_OID);
}
}
