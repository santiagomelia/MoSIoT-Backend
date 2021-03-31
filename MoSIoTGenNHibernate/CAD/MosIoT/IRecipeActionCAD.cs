
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IRecipeActionCAD
{
RecipeActionEN ReadOIDDefault (int id
                               );

void ModifyDefault (RecipeActionEN recipeAction);

System.Collections.Generic.IList<RecipeActionEN> ReadAllDefault (int first, int size);



int New_ (RecipeActionEN recipeAction);

void Modify (RecipeActionEN recipeAction);


void Destroy (int id
              );


RecipeActionEN ReadOID (int id
                        );


System.Collections.Generic.IList<RecipeActionEN> ReadAll (int first, int size);
}
}
