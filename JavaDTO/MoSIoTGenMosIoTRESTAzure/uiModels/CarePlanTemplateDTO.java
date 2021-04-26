	
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
		
		
		public class CarePlanTemplateDTO 	    implements IDTO
	    {
				private ArrayList<CareActivityDTO> careActivity;
				public ArrayList<CareActivityDTO> getCareActivity () { return careActivity; } 
				public void setCareActivity (ArrayList<CareActivityDTO> value) { careActivity = value;  } 
				    	 
				private Integer patientProfile_oid;
				public Integer  getPatientProfile_oid () { return patientProfile_oid; } 
				public void setPatientProfile_oid (Integer value) { patientProfile_oid = value;  } 
				    	 
				private CareStatus status;
				public CareStatus getStatus () { return status; } 
				public void setStatus  (CareStatus value) { status = value;  } 
				    	 
				private CarePlanIntent intent;
				public CarePlanIntent getIntent () { return intent; } 
				public void setIntent  (CarePlanIntent value) { intent = value;  } 
				    	 
				private String title;
				public String getTitle () { return title; } 
				public void setTitle  (String value) { title = value;  } 
				    	 
				private java.util.Date modified;
				public java.util.Date getModified () { return modified; } 
				public void setModified  (java.util.Date value) { modified = value;  } 
				    	 
				private ArrayList<GoalDTO> goals;
				public ArrayList<GoalDTO> getGoals () { return goals; } 
				public void setGoals (ArrayList<GoalDTO> value) { goals = value;  } 
				    	 
				private ArrayList<Integer> addressConditions_oid;
				public ArrayList<Integer>  getAddressConditions_oid () { return addressConditions_oid; } 
				public void setAddressConditions_oid (ArrayList<Integer> value) { addressConditions_oid = value;  } 
				    	 
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private Integer durationDays;
				public Integer getDurationDays () { return durationDays; } 
				public void setDurationDays  (Integer value) { durationDays = value;  } 
				    	 
				private String name;
				public String getName () { return name; } 
				public void setName  (String value) { name = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
				private ArrayList<ComunicationDTO> comunication;
				public ArrayList<ComunicationDTO> getComunication () { return comunication; } 
				public void setComunication (ArrayList<ComunicationDTO> value) { comunication = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{

						if (this.careActivity != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.careActivity.size(); ++i)
							{
								jsonArray.put(this.careActivity.get(i).toJSON());
							}
							json.put("CareActivity", jsonArray);
						}

						if (this.patientProfile_oid != null)
						{
							json.put("PatientProfile_oid", this.patientProfile_oid.intValue());
						}
				
						  json.put("Status", this.status.getRawValue());
				
				
						  json.put("Intent", this.intent.getRawValue());
				
				
						  json.put("Title", this.title);
				
				
						  json.put("Modified", DateUtils.dateToFormatString(this.modified));
				

						if (this.goals != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.goals.size(); ++i)
							{
								jsonArray.put(this.goals.get(i).toJSON());
							}
							json.put("Goals", jsonArray);
						}

						if (this.addressConditions_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.addressConditions_oid.size(); ++i)
							{
								jsonArray.put(this.addressConditions_oid.get(i));
							}
							json.put("AddressConditions_oid", jsonArray);
						}
		
				
						  json.put("Id", this.id.intValue());
				
				
						  json.put("DurationDays", this.durationDays.intValue());
				
				
						  json.put("Name", this.name);
				
				
						  json.put("Description", this.description);
				

						if (this.comunication != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.comunication.size(); ++i)
							{
								jsonArray.put(this.comunication.get(i).toJSON());
							}
							json.put("Comunication", jsonArray);
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
	   
	   
	   
		
	