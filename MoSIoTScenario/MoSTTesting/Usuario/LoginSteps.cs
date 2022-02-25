using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
namespace TestsGherkin.Usuario
{
    [Binding]
    public class LoginSteps
    {

        public static UserCEN usuarioCEN;
        public static UserCEN adminCEN = new UserCEN();
        public static string email;
        public static string contrasena;
        public static int id;
        public static string token;


        [Before(tags: "Login")]
        public static void InitializeData()
        {
            Console.WriteLine("Init");
            id = adminCEN.New_("shahabsur", true, GenderTypeEnum.male, false, "1234", "shahab", "Shahab", "shahab@ua.es");

        }

        [After(tags: "Login")]
        public static void CleanData()
        {
            adminCEN.Destroy(id);

        }


        [Given(@"Hay un usuario")]
        public void GivenHayUnUsuario(Table table)
        {

            var usuarios = table.CreateSet<UserEN>();
            usuarioCEN = new UserCEN();

            foreach (UserEN usuario in usuarios)
            {
                email = usuario.Email;
                contrasena = usuario.Pass;
            }

        }

        [When(@"Compruebo las credenciales")]
        public void WhenComprueboLasCredenciales()
        {

            token = usuarioCEN.Login(contrasena, email);
        }


        [Then(@"Devuelvo el usuario")]
        public void ThenDevuelvoElUsuario()
        {
            var jwtToken = new JwtSecurityToken(token);
            Console.WriteLine(jwtToken);
            string idtoken;
            foreach (Claim claim in jwtToken.Claims)
            {
                idtoken = claim.Value.ToString();
                Assert.AreEqual(id, Convert.ToInt32(idtoken));

            }
        }


        [Then(@"No existe el usuario")]
        public void ThenNoExisteElUsuario()
        {
            Assert.IsNull(token);
        }

    }
}
