
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IComunicationCAD
{
ComunicationEN ReadOIDDefault (int id
                               );

void ModifyDefault (ComunicationEN comunication);

System.Collections.Generic.IList<ComunicationEN> ReadAllDefault (int first, int size);



int New_ (ComunicationEN comunication);

void Modify (ComunicationEN comunication);


void Destroy (int id
              );
}
}
