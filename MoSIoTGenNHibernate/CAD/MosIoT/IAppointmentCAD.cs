
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IAppointmentCAD
{
AppointmentEN ReadOIDDefault (int id
                              );

void ModifyDefault (AppointmentEN appointment);

System.Collections.Generic.IList<AppointmentEN> ReadAllDefault (int first, int size);



int New_ (AppointmentEN appointment);

void Modify (AppointmentEN appointment);


void Destroy (int id
              );


AppointmentEN ReadOID (int id
                       );


System.Collections.Generic.IList<AppointmentEN> ReadAll (int first, int size);
}
}
