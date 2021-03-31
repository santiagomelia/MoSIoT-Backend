
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
 * Clase Command:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class CommandCAD : BasicCAD, ICommandCAD
{
public CommandCAD() : base ()
{
}

public CommandCAD(ISession sessionAux) : base (sessionAux)
{
}



public CommandEN ReadOIDDefault (int id
                                 )
{
        CommandEN commandEN = null;

        try
        {
                SessionInitializeTransaction ();
                commandEN = (CommandEN)session.Get (typeof(CommandEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return commandEN;
}

public System.Collections.Generic.IList<CommandEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CommandEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CommandEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CommandEN>();
                        else
                                result = session.CreateCriteria (typeof(CommandEN)).List<CommandEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CommandCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CommandEN command)
{
        try
        {
                SessionInitializeTransaction ();
                CommandEN commandEN = (CommandEN)session.Load (typeof(CommandEN), command.Id);


                commandEN.Name = command.Name;


                commandEN.IsSynchronous = command.IsSynchronous;



                commandEN.Type = command.Type;


                commandEN.Description = command.Description;

                session.Update (commandEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CommandEN command)
{
        try
        {
                SessionInitializeTransaction ();
                if (command.DeviceTemplate != null) {
                        // Argumento OID y no colección.
                        command.DeviceTemplate = (MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN), command.DeviceTemplate.Id);

                        command.DeviceTemplate.Command
                        .Add (command);
                }

                session.Save (command);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return command.Id;
}

public void Modify (CommandEN command)
{
        try
        {
                SessionInitializeTransaction ();
                CommandEN commandEN = (CommandEN)session.Load (typeof(CommandEN), command.Id);

                commandEN.Name = command.Name;


                commandEN.IsSynchronous = command.IsSynchronous;


                commandEN.Type = command.Type;


                commandEN.Description = command.Description;

                session.Update (commandEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CommandCAD.", ex);
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
                CommandEN commandEN = (CommandEN)session.Load (typeof(CommandEN), id);
                session.Delete (commandEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: CommandEN
public CommandEN ReadOID (int id
                          )
{
        CommandEN commandEN = null;

        try
        {
                SessionInitializeTransaction ();
                commandEN = (CommandEN)session.Get (typeof(CommandEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return commandEN;
}

public System.Collections.Generic.IList<CommandEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CommandEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CommandEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CommandEN>();
                else
                        result = session.CreateCriteria (typeof(CommandEN)).List<CommandEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
