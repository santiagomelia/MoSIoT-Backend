	
		package MoSIoTGenMosIoTRESTAzure.uiModels.DTO;
		
		import java.util.ArrayList;
		
		import org.json.JSONArray;
		import org.json.JSONException;
		import org.json.JSONObject;
		import  MoSIoTGenMosIoTRESTAzure.uiModels.DTO.utils.*;
		import  MoSIoTGenMosIoTRESTAzure.uiModels.DTO.enumerations.*;
		
		
		/**
		 * Code autogenerated. Do not modify this file.
		 */
		
		
		public class CareActivityDTO 	    implements IDTO
	    {
				private Integer carePlan_oid;
				public Integer  getCarePlan_oid () { return carePlan_oid; } 
				public void setCarePlan_oid (Integer value) { carePlan_oid = value;  } 
				    	 
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private TypePeriodicity periodicity;
				public TypePeriodicity getPeriodicity () { return periodicity; } 
				public void setPeriodicity  (TypePeriodicity value) { periodicity = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
				private Integer duration;
				public Integer getDuration () { return duration; } 
				public void setDuration  (Integer value) { duration = value;  } 
				    	 
				private MedicationDTO medication;
				public MedicationDTO getMedication () { return medication; } 
				public void setMedication (MedicationDTO value) { medication = value;  } 
				    	 
				private String location;
				public String getLocation () { return location; } 
				public void setLocation  (String value) { location = value;  } 
				    	 
				private String outcomeCode;
				public String getOutcomeCode () { return outcomeCode; } 
				public void setOutcomeCode  (String value) { outcomeCode = value;  } 
				    	 
				private NutritionOrderDTO nutritionOrder;
				public NutritionOrderDTO getNutritionOrder () { return nutritionOrder; } 
				public void setNutritionOrder (NutritionOrderDTO value) { nutritionOrder = value;  } 
				    	 
				private TypeActivity typeActivity;
				public TypeActivity getTypeActivity () { return typeActivity; } 
				public void setTypeActivity  (TypeActivity value) { typeActivity = value;  } 
				    	 
				private ArrayList<ComunicationDTO> notification;
				public ArrayList<ComunicationDTO> getNotification () { return notification; } 
				public void setNotification (ArrayList<ComunicationDTO> value) { notification = value;  } 
				    	 
				private String activityCode;
				public String getActivityCode () { return activityCode; } 
				public void setActivityCode  (String value) { activityCode = value;  } 
				    	 
				private String name;
				public String getName () { return name; } 
				public void setName  (String value) { name = value;  } 
				    	 
				private ArrayList<AppointmentDTO> appointment;
				public ArrayList<AppointmentDTO> getAppointment () { return appointment; } 
				public void setAppointment (ArrayList<AppointmentDTO> value) { appointment = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{

						if (this.carePlan_oid != null)
						{
							json.put("CarePlan_oid", this.carePlan_oid.intValue());
						}
				
						  json.put("Id", this.id.intValue());
				
				
						  json.put("Periodicity", this.periodicity.getRawValue());
				
				
						  json.put("Description", this.description);
				
				
						  json.put("Duration", this.duration.intValue());
				

						if (this.medication != null)
						{
							json.put("Medication", this.medication.toJSON());
						}
				
						  json.put("Location", this.location);
				
				
						  json.put("OutcomeCode", this.outcomeCode);
				

						if (this.nutritionOrder != null)
						{
							json.put("NutritionOrder", this.nutritionOrder.toJSON());
						}
				
						  json.put("TypeActivity", this.typeActivity.getRawValue());
				

						if (this.notification != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.notification.size(); ++i)
							{
								jsonArray.put(this.notification.get(i).toJSON());
							}
							json.put("Notification", jsonArray);
						}
				
						  json.put("ActivityCode", this.activityCode);
				
				
						  json.put("Name", this.name);
				

						if (this.appointment != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.appointment.size(); ++i)
							{
								jsonArray.put(this.appointment.get(i).toJSON());
							}
							json.put("Appointment", jsonArray);
						}
						
					}
					catch (JSONException e)
					{
						e.printStackTrace();
					}
				
				return json;
			}
		
			// endregion
		}
	   
	   
	   
		
	