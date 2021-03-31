using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class InheritanceAssemblerDTO {
public static IList<InheritanceEN> ConvertList (IList<InheritanceDTO> lista)
{
        IList<InheritanceEN> result = new List<InheritanceEN>();
        foreach (InheritanceDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static InheritanceEN Convert (InheritanceDTO dto)
{
        InheritanceEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new InheritanceEN ();



                        if (dto.Father_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityCAD entityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityCAD ();

                                newinstance.Father = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityEN>();
                                foreach (int entry in dto.Father_oid) {
                                        newinstance.Father.Add (entityCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Son_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityCAD entityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityCAD ();

                                newinstance.Son = entityCAD.ReadOIDDefault (dto.Son_oid);
                        }
                        newinstance.Id = dto.Id;
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
