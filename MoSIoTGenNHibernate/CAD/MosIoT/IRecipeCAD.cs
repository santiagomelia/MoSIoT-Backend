
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IRecipeCAD
{
RecipeEN ReadOIDDefault (int id
                         );

void ModifyDefault (RecipeEN recipe);

System.Collections.Generic.IList<RecipeEN> ReadAllDefault (int first, int size);



int New_ (RecipeEN recipe);

void Modify (RecipeEN recipe);


void Destroy (int id
              );


RecipeEN ReadOID (int id
                  );


System.Collections.Generic.IList<RecipeEN> ReadAll (int first, int size);
}
}
