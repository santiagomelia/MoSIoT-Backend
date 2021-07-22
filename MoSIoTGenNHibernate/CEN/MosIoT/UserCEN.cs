

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;

using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


namespace MoSIoTGenNHibernate.CEN.MosIoT
{
/*
 *      Definition of the class UserCEN
 *
 */
public partial class UserCEN
{
private IUserCAD _IUserCAD;

public UserCEN()
{
        this._IUserCAD = new UserCAD ();
}

public UserCEN(IUserCAD _IUserCAD)
{
        this._IUserCAD = _IUserCAD;
}

public IUserCAD get_IUserCAD ()
{
        return this._IUserCAD;
}

public void Destroy (int id
                     )
{
        _IUserCAD.Destroy (id);
}

public UserEN ReadOID (int id
                       )
{
        UserEN userEN = null;

        userEN = _IUserCAD.ReadOID (id);
        return userEN;
}

public System.Collections.Generic.IList<UserEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UserEN> list = null;

        list = _IUserCAD.ReadAll (first, size);
        return list;
}
public string Login (int p_User_OID, string p_pass)
{
        string result = null;
        UserEN en = _IUserCAD.ReadOIDDefault (p_User_OID);

        if (en != null && en.Pass.Equals (Utils.Util.GetEncondeMD5 (p_pass)))
                result = this.GetToken (en.Id);

        return result;
}

public int New_ (string p_surnames, bool p_isActive, MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum p_type, bool p_isDiseased, String p_pass, string p_name, string p_description, string p_email)
{
        UserEN userEN = null;
        int oid;

        //Initialized UserEN
        userEN = new UserEN ();
        userEN.Surnames = p_surnames;

        userEN.IsActive = p_isActive;

        userEN.Type = p_type;

        userEN.IsDiseased = p_isDiseased;

        userEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        userEN.Name = p_name;

        userEN.Description = p_description;

        userEN.Email = p_email;

        //Call to UserCAD

        oid = _IUserCAD.New_ (userEN);
        return oid;
}

public void Modify (int p_User_OID, string p_surnames, bool p_isActive, MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum p_type, bool p_isDiseased, String p_pass, string p_name, string p_description, string p_email)
{
        UserEN userEN = null;

        //Initialized UserEN
        userEN = new UserEN ();
        userEN.Id = p_User_OID;
        userEN.Surnames = p_surnames;
        userEN.IsActive = p_isActive;
        userEN.Type = p_type;
        userEN.IsDiseased = p_isDiseased;
        userEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        userEN.Name = p_name;
        userEN.Description = p_description;
        userEN.Email = p_email;
        //Call to UserCAD

        _IUserCAD.Modify (userEN);
}




private string Encode (int id)
{
        var payload = new Dictionary<string, object>(){
                { "id", id }
        };
        string token = Jose.JWT.Encode (payload, Utils.Util.getKey (), Jose.JwsAlgorithm.HS256);

        return token;
}

public string GetToken (int id)
{
        UserEN en = _IUserCAD.ReadOIDDefault (id);
        string token = Encode (en.Id);

        return token;
}
public int CheckToken (string token)
{
        int result = -1;

        try
        {
                string decodedToken = Utils.Util.Decode (token);



                int id = (int)ObtenerID (decodedToken);

                UserEN en = _IUserCAD.ReadOIDDefault (id);

                if (en != null && ((long)en.Id).Equals (ObtenerID (decodedToken))
                    ) {
                        result = id;
                }
                else throw new ModelException ("El token es incorrecto");
        } catch (Exception e)
        {
                throw new ModelException ("El token es incorrecto");
        }

        return result;
}


public long ObtenerID (string decodedToken)
{
        try
        {
                Dictionary<string, object> results = JsonConvert.DeserializeObject<Dictionary<string, object> >(decodedToken);
                long id = (long)results ["id"];
                return id;
        }
        catch
        {
                throw new Exception ("El token enviado no es correcto");
        }
}
}
}
