	
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
		
		
		public class DisabilityDTO 	    implements IDTO
	    {
				private Integer patient_oid;
				public Integer  getPatient_oid () { return patient_oid; } 
				public void setPatient_oid (Integer value) { patient_oid = value;  } 
				    	 
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private String name;
				public String getName () { return name; } 
				public void setName  (String value) { name = value;  } 
				    	 
				private DisabilityType type;
				public DisabilityType getType () { return type; } 
				public void setType  (DisabilityType value) { type = value;  } 
				    	 
				private Severity severity;
				public Severity getSeverity () { return severity; } 
				public void setSeverity  (Severity value) { severity = value;  } 
				    	 
				private Integer origin_oid;
				public Integer  getOrigin_oid () { return origin_oid; } 
				public void setOrigin_oid (Integer value) { origin_oid = value;  } 
				    	 
				private ArrayList<Integer> accessMode_oid;
				public ArrayList<Integer>  getAccessMode_oid () { return accessMode_oid; } 
				public void setAccessMode_oid (ArrayList<Integer> value) { accessMode_oid = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{

						if (this.patient_oid != null)
						{
							json.put("Patient_oid", this.patient_oid.intValue());
						}
				
						  json.put("Id", this.id.intValue());
				
				
						  json.put("Name", this.name);
				
				
						  json.put("Type", this.type.getRawValue());
				
				
						  json.put("Severity", this.severity.getRawValue());
				

						if (this.origin_oid != null)
						{
							json.put("Origin_oid", this.origin_oid.intValue());
						}

						if (this.accessMode_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.accessMode_oid.size(); ++i)
							{
								jsonArray.put(this.accessMode_oid.get(i));
							}
							json.put("AccessMode_oid", jsonArray);
						}
		
				
						  json.put("Description", this.description);
				
						
					}
					catch (JSONException e)
					{
						e.printStackTrace();
					}
				
				return json;
			}
		
			// endregion
		}
	   
	   
	   
		
	