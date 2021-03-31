
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes


                UserCEN userCEN = new UserCEN ();
                userCEN.New_ ("shahabsur", true, false, "1234", "shahab", "Shahab", "shahab@ua.es");


                DeviceTemplateCEN deviceTCEN = new DeviceTemplateCEN ();
                int deviceT1 = deviceTCEN.New_ ("Smartring", DeviceTypeEnum.sensor, false);
                int deviceT2 = deviceTCEN.New_ ("Smartphone", DeviceTypeEnum.actuator, false);
                int deviceT3 = deviceTCEN.New_ ("Voice Assistance", DeviceTypeEnum.actuator, false);


                CommandCEN commandCEN = new CommandCEN ();
                commandCEN.New_ (deviceT1, "Command 1", true, OperationTypeEnum.GetByID, "get device by id");

                PropertyCEN propertyCEN = new PropertyCEN ();
                propertyCEN.New_ (deviceT1, "property 1", true, true);


                EventTelemetryCEN eventTelemetry = new EventTelemetryCEN ();
                int eventTel1 = eventTelemetry.New_ ("evento", MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum.info);

                TelemetryCEN telemetryCEN = new TelemetryCEN ();
                telemetryCEN.New_ (deviceT1, 2, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum.Integer, TypeUnitEnum.steps, "Heart beats", TelemetryTypeEnum.event_);


                PatientProfileCEN patientProfile = new PatientProfileCEN ();
                int idPatient = patientProfile.New_ (LanguageCodeEnum.es, "Espana", "patient with Alzheimer", "patient with a mild Alzheimer with a cognitive disability");

                ConditionCEN conditionCEN = new ConditionCEN ();
                conditionCEN.New_ (idPatient, DateTime.Today, "Alzheimer", ClinicalStatusEnum.active, DiseaseEnum.Alzheimer, "Alzheimer");

                DisabilityCEN disabilityCEN = new DisabilityCEN ();
                int idDisability = disabilityCEN.New_ (idPatient, "cognitive", DisabilityTypeEnum.cognitive, SeverityEnum.mild, "Cognitive Disability");

                AccessModeCEN accessMode = new AccessModeCEN ();
                int idAccessMode = accessMode.New_ (idPatient, AccessModeValueEnum.textual, "Acceso al Smartphone", idDisability, "accessMode Smartphone");

                AdaptationRequestCEN adaptRequest = new AdaptationRequestCEN ();
                adaptRequest.New_ (AccessModeValueEnum.auditory, idAccessMode, LanguageCodeEnum.es, "adaptation auditive");

                AdaptationTypeRequiredCEN adapTypeReq = new AdaptationTypeRequiredCEN ();
                adapTypeReq.New_ (AdaptationTypeValueEnum.audioDescription, "Describe el contenido con voz", idAccessMode);

                AdaptationDetailRequiredCEN adaptationDetail = new AdaptationDetailRequiredCEN ();
                adaptationDetail.New_ (AdaptationDetailValueEnum.record, idAccessMode, "Se graba el la voz generada");








                // p.e. CustomerCEN customer = new CustomerCEN();
                // customer.New_ (p_user:"user", p_password:"1234");



                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
