using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

using MoSIoTGenScenarioMoSIoTRESTAzure.DTOA;
using MoSIoTGenScenarioMoSIoTRESTAzure.CAD;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.CP.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.Assemblers
{
public static class IMMedicationAssembler
{
public static IMMedicationDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMMedicationDTOA dto = null;
        IMMedicationRESTCAD iMMedicationRESTCAD = null;
        IMMedicationCEN iMMedicationCEN = null;
        IMMedicationCP iMMedicationCP = null;

        if (en != null) {
                dto = new IMMedicationDTOA ();
                iMMedicationRESTCAD = new IMMedicationRESTCAD (session);
                iMMedicationCEN = new IMMedicationCEN (iMMedicationRESTCAD);
                iMMedicationCP = new IMMedicationCP (session);


                IMMedicationEN enHijo = iMMedicationRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                dto.Value = en.Value;


                //
                // TravesalLink

                /* Rol: IMMedication o--> Medication */
                dto.ValueMedication = MedicationAssembler.Convert ((MedicationEN)enHijo.Medication, session);


                //
                // Service
        }

        return dto;
}
}
}
