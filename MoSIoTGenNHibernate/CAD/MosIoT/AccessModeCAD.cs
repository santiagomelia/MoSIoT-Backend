
using System;
using System.Text;
using MoSIoTGenNHibernate.CEN.MosIoT;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Exceptions;


/*
 * Clase AccessMode:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class AccessModeCAD : BasicCAD, IAccessModeCAD
{
public AccessModeCAD() : base ()
{
}

public AccessModeCAD(ISession sessionAux) : base (sessionAux)
{
}



public AccessModeEN ReadOIDDefault (int id
                                    )
{
        AccessModeEN accessModeEN = null;

        try
        {
                SessionInitializeTransaction ();
                accessModeEN = (AccessModeEN)session.Get (typeof(AccessModeEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return accessModeEN;
}

public System.Collections.Generic.IList<AccessModeEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AccessModeEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AccessModeEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AccessModeEN>();
                        else
                                result = session.CreateCriteria (typeof(AccessModeEN)).List<AccessModeEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AccessModeEN accessMode)
{
        try
        {
                SessionInitializeTransaction ();
                AccessModeEN accessModeEN = (AccessModeEN)session.Load (typeof(AccessModeEN), accessMode.Id);


                accessModeEN.TypeAccessMode = accessMode.TypeAccessMode;




                accessModeEN.Description = accessMode.Description;





                accessModeEN.Name = accessMode.Name;

                session.Update (accessModeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AccessModeEN accessMode)
{
        try
        {
                SessionInitializeTransaction ();
                if (accessMode.Patient != null) {
                        // Argumento OID y no colección.
                        accessMode.Patient = (MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN), accessMode.Patient.Id);

                        accessMode.Patient.AccessMode
                        .Add (accessMode);
                }
                if (accessMode.Disability != null) {
                        // Argumento OID y no colección.
                        accessMode.Disability = (MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN), accessMode.Disability.Id);

                        accessMode.Disability.AccessMode
                        .Add (accessMode);
                }

                session.Save (accessMode);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return accessMode.Id;
}

public void Modify (AccessModeEN accessMode)
{
        try
        {
                SessionInitializeTransaction ();
                AccessModeEN accessModeEN = (AccessModeEN)session.Load (typeof(AccessModeEN), accessMode.Id);

                accessModeEN.TypeAccessMode = accessMode.TypeAccessMode;


                accessModeEN.Description = accessMode.Description;


                accessModeEN.Name = accessMode.Name;

                session.Update (accessModeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                AccessModeEN accessModeEN = (AccessModeEN)session.Load (typeof(AccessModeEN), id);
                session.Delete (accessModeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AccessModeEN
public AccessModeEN ReadOID (int id
                             )
{
        AccessModeEN accessModeEN = null;

        try
        {
                SessionInitializeTransaction ();
                accessModeEN = (AccessModeEN)session.Get (typeof(AccessModeEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return accessModeEN;
}

public System.Collections.Generic.IList<AccessModeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AccessModeEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AccessModeEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AccessModeEN>();
                else
                        result = session.CreateCriteria (typeof(AccessModeEN)).List<AccessModeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AsignarDevice (int p_AccessMode_OID, System.Collections.Generic.IList<int> p_deviceTemplate_OIDs)
{
        MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessModeEN = null;
        try
        {
                SessionInitializeTransaction ();
                accessModeEN = (AccessModeEN)session.Load (typeof(AccessModeEN), p_AccessMode_OID);
                MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplateENAux = null;
                if (accessModeEN.DeviceTemplate == null) {
                        accessModeEN.DeviceTemplate = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN>();
                }

                foreach (int item in p_deviceTemplate_OIDs) {
                        deviceTemplateENAux = new MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN ();
                        deviceTemplateENAux = (MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN), item);

                        accessModeEN.DeviceTemplate.Add (deviceTemplateENAux);
                }


                session.Update (accessModeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
