
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
using APIExterna;


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
                int idUserShahab = userCEN.New_ ("shahabsur", true, GenderTypeEnum.male, false, "1234", "shahab", "Shahab", "shahab@ua.es");


                int idUser = userCEN.New_ ("Lucas Grijander", true, GenderTypeEnum.male, true, "1234", "Chiquito", "Paciente Alzheimer", "lucas@ua.es");


                DeviceTemplateCEN deviceTCEN = new DeviceTemplateCEN ();
                int deviceT1 = deviceTCEN.New_ ("Smartring", DeviceTypeEnum.sensor, false);
                int deviceT2 = deviceTCEN.New_ ("Smartphone", DeviceTypeEnum.actuator, false);
                int deviceT3 = deviceTCEN.New_ ("Voice Assistance", DeviceTypeEnum.actuator, false);


                CommandCEN commandCEN = new CommandCEN ();
                commandCEN.New_ (deviceT1, "Command 1", true, OperationTypeEnum.GetByID, "get device by id");

                PropertyCEN propertyCEN = new PropertyCEN ();
                propertyCEN.New_ (deviceT1, "property 1", true, true);

                TelemetryCEN telemetryCEN = new TelemetryCEN ();
                int idTelemetry = telemetryCEN.New_ (deviceT1, 2, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum.Integer, TypeUnitEnum.steps, "Heart beats", TelemetryTypeEnum.event_);


                EventTelemetryCEN eventTelemetry = new EventTelemetryCEN ();
                int eventTel1 = eventTelemetry.New_ (idTelemetry, "evento", MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum.info);


                PatientProfileCEN patientProfile = new PatientProfileCEN ();
                int idPatientProfile = patientProfile.New_ (LanguageCodeEnum.es, "Espana", HazardValueEnum.olfactoryHazard, "patient with Alzheimer", "patient with a mild Alzheimer with a cognitive disability");

                ConditionCEN conditionCEN = new ConditionCEN ();
                int idCondition = conditionCEN.New_ (idPatientProfile, "Alzheimer", ClinicalStatusEnum.active, DiseaseEnum.Alzheimer, "Alzheimer");

                DisabilityCEN disabilityCEN = new DisabilityCEN ();
                int idDisability = disabilityCEN.New_ (idPatientProfile, "cognitive", DisabilityTypeEnum.cognitive, SeverityEnum.mild, "Cognitive Disability");

                AccessModeCEN accessMode = new AccessModeCEN ();
                int idAccessMode = accessMode.New_ (idPatientProfile, AccessModeValueEnum.textual, "Acceso al Smartphone", idDisability, "accessMode Smartphone");

                AdaptationRequestCEN adaptRequest = new AdaptationRequestCEN ();
                adaptRequest.New_ (AccessModeValueEnum.auditory, idAccessMode, LanguageCodeEnum.es, "adaptation auditive");

                AdaptationTypeRequiredCEN adapTypeReq = new AdaptationTypeRequiredCEN ();
                adapTypeReq.New_ (AdaptationTypeValueEnum.audioDescription, "Describe el contenido con voz", idAccessMode);

                AdaptationDetailRequiredCEN adaptationDetail = new AdaptationDetailRequiredCEN ();
                adaptationDetail.New_ (AdaptationDetailValueEnum.record, idAccessMode, "Se graba el la voz generada");


                CarePlanTemplateCEN carePlan = new CarePlanTemplateCEN ();
                int idCarePlanT = carePlan.New_ (CareStatusEnum.active, CarePlanIntentEnum.proposal, "Plan de cuidados para persona con Alzheimer", DateTime.Now, 100, "cuidadosAlzheimer", "Se describen todos los objetivos y actividades necesarias para que se cuide a una persona que presenta Alzheimer");


                carePlan.AddCondition (idCarePlanT, new List<int> { idCondition });


                CareActivityCEN careActivity = new CareActivityCEN ();
                careActivity.New_ (idCarePlanT, TypePeriodicityEnum.daily, "Realizar un paseo", 40, "parque", "", TypeActivityEnum.sportActivity, " ", "Paseo");

                int idActivityMed = careActivity.New_ (idCarePlanT, TypePeriodicityEnum.perHour, "Tomar Ceregumil", 0, "en casa", "", TypeActivityEnum.medication, "", "Tomar medicamento mente activa");
                int idActivityCom = careActivity.New_(idCarePlanT, TypePeriodicityEnum.daily, "Notificacion", 0, "en casa", "", TypeActivityEnum.comunication, "", "Notificacion paraa que tome Ceregumil");
                int idActivityNut = careActivity.New_(idCarePlanT, TypePeriodicityEnum.daily, "Comer nueces", 0, "en casa", "", TypeActivityEnum.nutritionOrder, "", "Comer  50 gr. de nueces");
                int idActivityApp = careActivity.New_(idCarePlanT, TypePeriodicityEnum.monthly, "Cita con el Neurologo", 0, "clinica", "", TypeActivityEnum.appointment, "", "Revision con el neurologo");


                MedicationCEN medicationCEN = new MedicationCEN ();
                int idMedication  =  medicationCEN.New_ (idActivityMed, 346864, "Ceregumil Original 500 ml", " ", "Tomar una cucharada 3 veces al dia", "cucharada", FormTypeEnum.powder, "346864");
                
                ComunicationCEN comunicationCEN = new ComunicationCEN();
                int idComuncation = comunicationCEN.New_(SeverityEventEnum.info, "Recuerde tomar Ceregumil en el desayuno", DateTime.Now);
                
                NutritionOrderCEN nutricionCEN = new NutritionOrderCEN();
                int idNutricion = nutricionCEN.New_("Comer 50gr de nueces al dia", "", idActivityNut, "comeNueces");

                AppointmentCEN appCEN = new AppointmentCEN();
                int idAppoint = appCEN.New_(true, "Cita por google meet", "http://google.meet/34", "", idActivityApp);

                GoalCEN goal = new GoalCEN ();
                int idGoal = goal.New_ (idCarePlanT, PriorityTypeEnum.high, CareStatusEnum.active, idCondition, "Mejorar los indicadores cognitivos", CategoryGoalEnum.behavioral, " ", "Mejora cognitiva");

                TargetCEN target = new TargetCEN ();

                int idTarget = target.New_ (idGoal, "70", "Reducir las pulsaciones a 70", DateTime.Today.AddDays (60));


                MeasureCEN measureCEN = new MeasureCEN ();
                int idMeasure = measureCEN.New_ ("Pulsaciones_minuto", "Pulsaciones por minuto", " ");

                target.AddMeasure (idTarget, idMeasure);

                measureCEN.AddTelemetries (idMeasure, new List<int> { idTelemetry });



                // SCENARIO

                IoTScenarioCEN scenarioCEN = new IoTScenarioCEN ();
                int idScenarioIoT = scenarioCEN.New_ ("Escenario Paciente con Alzheimer", "Se reproducen los elementos de un enfermo de alzheimer con discapacidad cognitiva");


                PatientCEN patientCEN = new PatientCEN ();
                int idPAtient = patientCEN.New_ ("Juan Lucas", idScenarioIoT, "Es un paciente nuevo", idUser);
                patientCEN.AssignPatientProfile (idPAtient, idPatientProfile);

                PatientAccessCEN patientAccessCEN = new PatientAccessCEN ();
                int idPatientAccess = patientAccessCEN.New_ ("PatientAccessSmartphone", idScenarioIoT, "patient Access Smartphone");
                patientAccessCEN.AssignAccessMode (idPatientAccess, idAccessMode);

                DeviceCEN deviceCEN = new DeviceCEN ();
                int idDevice = deviceCEN.New_ ("Iphone 12", idScenarioIoT, "Iphone 12 120 Gb", false, "1212", true, "1818181818181", "firm1", "Apple");
                deviceCEN.AssignDeviceTemplate (idDevice, deviceT2);

                CarePlanCEN carePlanCEN = new CarePlanCEN ();
                int idCarePlan = carePlanCEN.New_ ("Care Plan Alzheimer", idScenarioIoT, "El carePlan adecuado para el alzheimer");
                carePlanCEN.AssignCarePlan (idCarePlan, idCarePlanT);


                VitalSignCEN vitalCEN = new VitalSignCEN ();
                int idVitalSign = vitalCEN.New_ ("Pulsaciones por minuto", idScenarioIoT, "Recoge las pulsaciones por minuto del paciente");
                vitalCEN.AssignMeasure (idVitalSign, idMeasure);

                int idUserRelated = userCEN.New_ ("Berna", true, GenderTypeEnum.female, false, "1234", "Juana", "Madre de Lucas", "juana@gmail.com");

                PractitionerCEN practitionerCEN = new PractitionerCEN ();
                practitionerCEN.New_ ("Medico Shahab", idScenarioIoT, "Medico Shahab", idUserShahab);

                RelatedPersonCEN relatedPersonCEN = new RelatedPersonCEN ();
                relatedPersonCEN.New_ ("Juana Berna", idScenarioIoT, "Madre de Berna", idUserRelated);

                IMCareActivityCEN imcareAct = new IMCareActivityCEN ();
                int idCareActivity = imcareAct.New_ ("revision1", idScenarioIoT, "");

                IMAppointmentCEN imAppoin = new IMAppointmentCEN ();
                int  idIMAppoint =  imAppoin.New_ ("citaRevision", "cita para la revision", idCareActivity, new DateTime (2021, 8, 1));
                imAppoin.AssignAppoint(idIMAppoint, idAppoint);

                int idCareActivity2 = imcareAct.New_ ("comunicacion1", idScenarioIoT, "");
              
                IMCommunicationCEN imCom = new IMCommunicationCEN ();
                int idImCom = imCom.New_ ("MensajeRev", "Mensaje de aviso para la revision", idCareActivity2);
                imCom.AssignCommunication(idImCom, idComuncation);


                int idCareActivity3 = imcareAct.New_ ("medicacion1", idScenarioIoT, "");

                IMMedicationCEN imMed = new IMMedicationCEN ();
                int idImMed = imMed.New_ ("MedicacionMemoria", "Medicamento para la memoria", idCareActivity3);

                imMed.AssignMedication(idImMed, idMedication);

                /// IMAppointment , IMCareActivity, IMVitalSign, IMCommunication, IMDisability, IMMedication
                // IMCommunicationCEN


                // Invocamos a la fachada REST de Azure IoT Central
                //IoTCentralAdapterREST iotAdapter = new IoTCentralAdapterREST();
                ////  iotAdapter.ListarDeviceTemplate();
                //iotAdapter.GetToken();
                //iotAdapter.ListarDeviceTemplates();


                // Invocamos a la fachada MQTT de Azure IoT Central
                // IoTCentralAdapterMQTT ioTMQTTAdapter = new IoTCentralAdapterMQTT();

                //ioTMQTTAdapter.initializeAzureDeviceClient();



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
