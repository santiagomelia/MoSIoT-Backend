using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class UserAssemblerDTO {
public static IList<UserEN> ConvertList (IList<UserDTO> lista)
{
        IList<UserEN> result = new List<UserEN>();
        foreach (UserDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static UserEN Convert (UserDTO dto)
{
        UserEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new UserEN ();



                        newinstance.BirthDate = dto.BirthDate;
                        newinstance.Address = dto.Address;
                        newinstance.Surnames = dto.Surnames;
                        newinstance.Phone = dto.Phone;
                        newinstance.Photo = dto.Photo;
                        newinstance.IsActive = dto.IsActive;
                        newinstance.Type = dto.Type;
                        newinstance.IsDiseased = dto.IsDiseased;
                        newinstance.Pass = dto.Pass;
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.Description = dto.Description;
                        newinstance.Email = dto.Email;
                        if (dto.RelatedPerson_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRelatedPersonCAD relatedPersonCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RelatedPersonCAD ();

                                newinstance.RelatedPerson = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RelatedPersonEN>();
                                foreach (int entry in dto.RelatedPerson_oid) {
                                        newinstance.RelatedPerson.Add (relatedPersonCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Practitioner_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IPractitionerCAD practitionerCAD = new MoSIoTGenNHibernate.CAD.MosIoT.PractitionerCAD ();

                                newinstance.Practitioner = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.PractitionerEN>();
                                foreach (int entry in dto.Practitioner_oid) {
                                        newinstance.Practitioner.Add (practitionerCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Patient_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IPatientCAD patientCAD = new MoSIoTGenNHibernate.CAD.MosIoT.PatientCAD ();

                                newinstance.Patient = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.PatientEN>();
                                foreach (int entry in dto.Patient_oid) {
                                        newinstance.Patient.Add (patientCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Notifications_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.INotifyCAD notifyCAD = new MoSIoTGenNHibernate.CAD.MosIoT.NotifyCAD ();

                                newinstance.Notifications = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.NotifyEN>();
                                foreach (int entry in dto.Notifications_oid) {
                                        newinstance.Notifications.Add (notifyCAD.ReadOIDDefault (entry));
                                }
                        }
                }
        }
        catch (Exception ex)
        {
                throw ex;
        }
        return newinstance;
}
}
}
