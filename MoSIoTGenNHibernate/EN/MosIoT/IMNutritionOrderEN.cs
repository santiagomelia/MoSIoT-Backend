
using System;
// Definición clase IMNutritionOrderEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMNutritionOrderEN                                                                     : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo nutritionOrder
 */
private MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN nutritionOrder;






public virtual MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN NutritionOrder {
        get { return nutritionOrder; } set { nutritionOrder = value;  }
}





public IMNutritionOrderEN() : base ()
{
}



public IMNutritionOrderEN(int id, MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN nutritionOrder
                          , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                          )
{
        this.init (Id, nutritionOrder, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMNutritionOrderEN(IMNutritionOrderEN iMNutritionOrder)
{
        this.init (Id, iMNutritionOrder.NutritionOrder, iMNutritionOrder.Name, iMNutritionOrder.Type, iMNutritionOrder.IsOID, iMNutritionOrder.TargetAssociation, iMNutritionOrder.OriginAsociation, iMNutritionOrder.AssociationType, iMNutritionOrder.IsWritable, iMNutritionOrder.Description, iMNutritionOrder.Entity, iMNutritionOrder.Trigger, iMNutritionOrder.Register, iMNutritionOrder.Value);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN nutritionOrder, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.NutritionOrder = nutritionOrder;

        this.Name = name;

        this.Type = type;

        this.IsOID = isOID;

        this.TargetAssociation = targetAssociation;

        this.OriginAsociation = originAsociation;

        this.AssociationType = associationType;

        this.IsWritable = isWritable;

        this.Description = description;

        this.Entity = entity;

        this.Trigger = trigger;

        this.Register = register;

        this.Value = value;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IMNutritionOrderEN t = obj as IMNutritionOrderEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
