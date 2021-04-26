using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class MedicationAssemblerDTO {
public static IList<MedicationEN> ConvertList (IList<MedicationDTO> lista)
{
        IList<MedicationEN> result = new List<MedicationEN>();
        foreach (MedicationDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static MedicationEN Convert (MedicationDTO dto)
{
        MedicationEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new MedicationEN ();



                        if (dto.CareActivity_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICareActivityCAD careActivityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CareActivityCAD ();

                                newinstance.CareActivity = careActivityCAD.ReadOIDDefault (dto.CareActivity_oid);
                        }
                        newinstance.ProductReference = dto.ProductReference;
                        newinstance.Name = dto.Name;
                        newinstance.Manufacturer = dto.Manufacturer;
                        newinstance.Description = dto.Description;
                        newinstance.Dosage = dto.Dosage;
                        newinstance.Form = dto.Form;
                        newinstance.MedicationCode = dto.MedicationCode;
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
