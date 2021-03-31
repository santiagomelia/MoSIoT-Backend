using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

using MoSIoTGenMosIoTRESTAzure.DTOA;
using MoSIoTGenMosIoTRESTAzure.CAD;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.CP.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.Assemblers
{
public static class MedicationAssembler
{
public static MedicationDTOA Convert (MedicationEN en, NHibernate.ISession session = null)
{
        MedicationDTOA dto = null;
        MedicationRESTCAD medicationRESTCAD = null;
        MedicationCEN medicationCEN = null;
        MedicationCP medicationCP = null;

        if (en != null) {
                dto = new MedicationDTOA ();
                medicationRESTCAD = new MedicationRESTCAD (session);
                medicationCEN = new MedicationCEN (medicationRESTCAD);
                medicationCP = new MedicationCP (session);





                //
                // Attributes

                dto.ProductReference = en.ProductReference;

                dto.Name = en.Name;


                dto.Manufacturer = en.Manufacturer;


                dto.Description = en.Description;


                dto.Dosage = en.Dosage;


                dto.Form = en.Form;


                dto.MedicationCode = en.MedicationCode;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
