using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class IMTelemetryAssemblerDTO {
public static IList<IMTelemetryEN> ConvertList (IList<IMTelemetryDTO> lista)
{
        IList<IMTelemetryEN> result = new List<IMTelemetryEN>();
        foreach (IMTelemetryDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static IMTelemetryEN Convert (IMTelemetryDTO dto)
{
        IMTelemetryEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new IMTelemetryEN ();



                        if (dto.Telemetry_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ITelemetryCAD telemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.TelemetryCAD ();

                                newinstance.Telemetry = telemetryCAD.ReadOIDDefault (dto.Telemetry_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        if (dto.OriginAssociation_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAssociationCAD associationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AssociationCAD ();

                                newinstance.OriginAssociation = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN>();
                                foreach (int entry in dto.OriginAssociation_oid) {
                                        newinstance.OriginAssociation.Add (associationCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.TargetAssociation_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAssociationCAD associationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AssociationCAD ();

                                newinstance.TargetAssociation = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN>();
                                foreach (int entry in dto.TargetAssociation_oid) {
                                        newinstance.TargetAssociation.Add (associationCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Scenario_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IIoTScenarioCAD ioTScenarioCAD = new MoSIoTGenNHibernate.CAD.MosIoT.IoTScenarioCAD ();

                                newinstance.Scenario = ioTScenarioCAD.ReadOIDDefault (dto.Scenario_oid);
                        }
                        newinstance.Description = dto.Description;

                        if (dto.Operations != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityOperationCAD entityOperationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityOperationCAD ();

                                newinstance.Operations = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN>();
                                foreach (EntityOperationDTO entry in dto.Operations) {
                                        newinstance.Operations.Add (EntityOperationAssemblerDTO.Convert (entry));
                                }
                        }

                        if (dto.Attributes != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityAttributesCAD entityAttributesCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityAttributesCAD ();

                                newinstance.Attributes = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN>();
                                foreach (EntityAttributesDTO entry in dto.Attributes) {
                                        newinstance.Attributes.Add (EntityAttributesAssemblerDTO.Convert (entry));
                                }
                        }

                        if (dto.States != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityStateCAD entityStateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityStateCAD ();

                                newinstance.States = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN>();
                                foreach (EntityStateDTO entry in dto.States) {
                                        newinstance.States.Add (EntityStateAssemblerDTO.Convert (entry));
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
