using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class AssociationAssemblerDTO {
public static IList<AssociationEN> ConvertList (IList<AssociationDTO> lista)
{
        IList<AssociationEN> result = new List<AssociationEN>();
        foreach (AssociationDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static AssociationEN Convert (AssociationDTO dto)
{
        AssociationEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new AssociationEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        if (dto.RolOrigin_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityAttributesCAD entityAttributesCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityAttributesCAD ();

                                newinstance.RolOrigin = entityAttributesCAD.ReadOIDDefault (dto.RolOrigin_oid);
                        }
                        if (dto.RolTarget_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityAttributesCAD entityAttributesCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityAttributesCAD ();

                                newinstance.RolTarget = entityAttributesCAD.ReadOIDDefault (dto.RolTarget_oid);
                        }
                        newinstance.Type = dto.Type;
                        newinstance.CardinalityOrigin = dto.CardinalityOrigin;
                        newinstance.CardinalityTarget = dto.CardinalityTarget;
                        if (dto.EntityOrigin_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityCAD entityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityCAD ();

                                newinstance.EntityOrigin = entityCAD.ReadOIDDefault (dto.EntityOrigin_oid);
                        }
                        if (dto.EntityTarget_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityCAD entityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityCAD ();

                                newinstance.EntityTarget = entityCAD.ReadOIDDefault (dto.EntityTarget_oid);
                        }
                        if (dto.IoTScenario_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IIoTScenarioCAD ioTScenarioCAD = new MoSIoTGenNHibernate.CAD.MosIoT.IoTScenarioCAD ();

                                newinstance.IoTScenario = ioTScenarioCAD.ReadOIDDefault (dto.IoTScenario_oid);
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
