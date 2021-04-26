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
public static class PatientAssembler
{
public static PatientDTOA Convert (EntityEN en, NHibernate.ISession session = null)
{
        PatientDTOA dto = null;
        PatientRESTCAD patientRESTCAD = null;
        PatientCEN patientCEN = null;
        PatientCP patientCP = null;

        if (en != null) {
                dto = new PatientDTOA ();
                patientRESTCAD = new PatientRESTCAD (session);
                patientCEN = new PatientCEN (patientRESTCAD);
                patientCP = new PatientCP (session);


                PatientEN enHijo = patientRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: Patient o--> PatientProfile */
                dto.PatientProfile = PatientProfileAssembler.Convert ((PatientProfileEN)enHijo.PatientProfile, session);

                /* Rol: Patient o--> User */
                dto.UserData = UserAssembler.Convert ((UserEN)enHijo.UserPatient, session);


                //
                // Service
        }

        return dto;
}
}
}
