
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMAppointmentCAD
{
IMAppointmentEN ReadOIDDefault (int id
                                );

void ModifyDefault (IMAppointmentEN iMAppointment);

System.Collections.Generic.IList<IMAppointmentEN> ReadAllDefault (int first, int size);



int New_ (IMAppointmentEN iMAppointment);

void Modify (IMAppointmentEN iMAppointment);


void Destroy (int id
              );


IMAppointmentEN ReadOID (int id
                         );


System.Collections.Generic.IList<IMAppointmentEN> ReadAll (int first, int size);
}
}
