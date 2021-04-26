
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface ICarePlanTemplateCAD
{
CarePlanTemplateEN ReadOIDDefault (int id
                                   );

void ModifyDefault (CarePlanTemplateEN carePlanTemplate);

System.Collections.Generic.IList<CarePlanTemplateEN> ReadAllDefault (int first, int size);



int New_ (CarePlanTemplateEN carePlanTemplate);

void Modify (CarePlanTemplateEN carePlanTemplate);


void Destroy (int id
              );


void AddCondition (int p_CarePlanTemplate_OID, System.Collections.Generic.IList<int> p_addressConditions_OIDs);

CarePlanTemplateEN ReadOID (int id
                            );


System.Collections.Generic.IList<CarePlanTemplateEN> ReadAll (int first, int size);


void AddPatientProfile (int p_CarePlanTemplate_OID, int p_patientProfile_OID);
}
}
