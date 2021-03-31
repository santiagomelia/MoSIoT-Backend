	
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
		
		
		public class CommandDTO 	    implements IDTO
	    {
				private Integer deviceTemplate_oid;
				public Integer  getDeviceTemplate_oid () { return deviceTemplate_oid; } 
				public void setDeviceTemplate_oid (Integer value) { deviceTemplate_oid = value;  } 
				    	 
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private String name;
				public String getName () { return name; } 
				public void setName  (String value) { name = value;  } 
				    	 
				private Boolean isSynchronous;
				public Boolean getIsSynchronous () { return isSynchronous; } 
				public void setIsSynchronous  (Boolean value) { isSynchronous = value;  } 
				    	 
				private ArrayList<Integer> telemetries_oid;
				public ArrayList<Integer>  getTelemetries_oid () { return telemetries_oid; } 
				public void setTelemetries_oid (ArrayList<Integer> value) { telemetries_oid = value;  } 
				    	 
				private OperationType type;
				public OperationType getType () { return type; } 
				public void setType  (OperationType value) { type = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{

						if (this.deviceTemplate_oid != null)
						{
							json.put("DeviceTemplate_oid", this.deviceTemplate_oid.intValue());
						}
				
						  json.put("Id", this.id.intValue());
				
				
						  json.put("Name", this.name);
				
				
						  json.put("IsSynchronous", this.isSynchronous);
				

						if (this.telemetries_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.telemetries_oid.size(); ++i)
							{
								jsonArray.put(this.telemetries_oid.get(i));
							}
							json.put("Telemetries_oid", jsonArray);
						}
		
				
						  json.put("Type", this.type.getRawValue());
				
				
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
	   
	   
	   
		
	