	
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
		
		
		public class UserDTO 	    implements IDTO
	    {
				private java.util.Date birthDate;
				public java.util.Date getBirthDate () { return birthDate; } 
				public void setBirthDate  (java.util.Date value) { birthDate = value;  } 
				    	 
				private String address;
				public String getAddress () { return address; } 
				public void setAddress  (String value) { address = value;  } 
				    	 
				private String surnames;
				public String getSurnames () { return surnames; } 
				public void setSurnames  (String value) { surnames = value;  } 
				    	 
				private String phone;
				public String getPhone () { return phone; } 
				public void setPhone  (String value) { phone = value;  } 
				    	 
				private String photo;
				public String getPhoto () { return photo; } 
				public void setPhoto  (String value) { photo = value;  } 
				    	 
				private Boolean isActive;
				public Boolean getIsActive () { return isActive; } 
				public void setIsActive  (Boolean value) { isActive = value;  } 
				    	 
				private GenderType type;
				public GenderType getType () { return type; } 
				public void setType  (GenderType value) { type = value;  } 
				    	 
				private Boolean isDiseased;
				public Boolean getIsDiseased () { return isDiseased; } 
				public void setIsDiseased  (Boolean value) { isDiseased = value;  } 
				    	 
				private String pass;
				public String getPass () { return pass; } 
				public void setPass  (String value) { pass = value;  } 
				    	 
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private String name;
				public String getName () { return name; } 
				public void setName  (String value) { name = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
				private String email;
				public String getEmail () { return email; } 
				public void setEmail  (String value) { email = value;  } 
				    	 
				private ArrayList<Integer> relatedPerson_oid;
				public ArrayList<Integer>  getRelatedPerson_oid () { return relatedPerson_oid; } 
				public void setRelatedPerson_oid (ArrayList<Integer> value) { relatedPerson_oid = value;  } 
				    	 
				private ArrayList<Integer> practitioner_oid;
				public ArrayList<Integer>  getPractitioner_oid () { return practitioner_oid; } 
				public void setPractitioner_oid (ArrayList<Integer> value) { practitioner_oid = value;  } 
				    	 
				private ArrayList<Integer> patient_oid;
				public ArrayList<Integer>  getPatient_oid () { return patient_oid; } 
				public void setPatient_oid (ArrayList<Integer> value) { patient_oid = value;  } 
				    	 
				private ArrayList<Integer> notifications_oid;
				public ArrayList<Integer>  getNotifications_oid () { return notifications_oid; } 
				public void setNotifications_oid (ArrayList<Integer> value) { notifications_oid = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{
					    if (this.birthDate != null){											
						  json.put("BirthDate", DateUtils.dateToFormatString(this.birthDate));
				
						}
					    if (this.address != null){											
						  json.put("Address", this.address);
				
						}
				
						  json.put("Surnames", this.surnames);
				
					    if (this.phone != null){											
						  json.put("Phone", this.phone);
				
						}
					    if (this.photo != null){											
						  json.put("Photo", this.photo);
				
						}
				
						  json.put("IsActive", this.isActive);
				
					    if (this.type != null){											
						  json.put("Type", this.type.getRawValue());
				
						}
				
						  json.put("IsDiseased", this.isDiseased);
				
				
						  json.put("Pass", this.pass);
				
				
						  json.put("Id", this.id.intValue());
				
				
						  json.put("Name", this.name);
				
				
						  json.put("Description", this.description);
				
				
						  json.put("Email", this.email);
				

						if (this.relatedPerson_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.relatedPerson_oid.size(); ++i)
							{
								jsonArray.put(this.relatedPerson_oid.get(i));
							}
							json.put("RelatedPerson_oid", jsonArray);
						}
		

						if (this.practitioner_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.practitioner_oid.size(); ++i)
							{
								jsonArray.put(this.practitioner_oid.get(i));
							}
							json.put("Practitioner_oid", jsonArray);
						}
		

						if (this.patient_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.patient_oid.size(); ++i)
							{
								jsonArray.put(this.patient_oid.get(i));
							}
							json.put("Patient_oid", jsonArray);
						}
		

						if (this.notifications_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.notifications_oid.size(); ++i)
							{
								jsonArray.put(this.notifications_oid.get(i));
							}
							json.put("Notifications_oid", jsonArray);
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
	   
	   
	   
		
	