
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


/*PROTECTED REGION ID(usingMoSIoTGenNHibernate.CEN.MosIoT_User_login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MoSIoTGenNHibernate.CEN.MosIoT
{
public partial class UserCEN
{
public string Login (string p_email, string p_pass)
{
        /*PROTECTED REGION ID(MoSIoTGenNHibernate.CEN.MosIoT_User_login) ENABLED START*/
        string result = null;

        IList<UserEN> en = _IUserCAD.DamePorEmail (p_email);

        if (en.Count > 0 && en [0].Pass.Equals (Utils.Util.GetEncondeMD5 (p_pass)))
                result = this.GetToken (en [0].Id);

        return result;
        /*PROTECTED REGION END*/
}
}
}
