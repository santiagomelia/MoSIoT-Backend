
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMCommunicationCAD
{
IMCommunicationEN ReadOIDDefault (int id
                                  );

void ModifyDefault (IMCommunicationEN iMCommunication);

System.Collections.Generic.IList<IMCommunicationEN> ReadAllDefault (int first, int size);



int New_ (IMCommunicationEN iMCommunication);

void Modify (IMCommunicationEN iMCommunication);


void Destroy (int id
              );


IMCommunicationEN ReadOID (int id
                           );


System.Collections.Generic.IList<IMCommunicationEN> ReadAll (int first, int size);


void AssignCommunication (int p_IMCommunication_OID, int p_comunication_OID);
}
}
