	
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
		
		
		public class AdaptationTypeRequiredDTO 	    implements IDTO
	    {
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private AdaptationTypeValue adaptionRequest;
				public AdaptationTypeValue getAdaptionRequest () { return adaptionRequest; } 
				public void setAdaptionRequest  (AdaptationTypeValue value) { adaptionRequest = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
				private Integer accessMode_oid;
				public Integer  getAccessMode_oid () { return accessMode_oid; } 
				public void setAccessMode_oid (Integer value) { accessMode_oid = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{
				
						  json.put("Id", this.id.intValue());
				
				
						  json.put("AdaptionRequest", this.adaptionRequest.getRawValue());
				
				
						  json.put("Description", this.description);
				

						if (this.accessMode_oid != null)
						{
							json.put("AccessMode_oid", this.accessMode_oid.intValue());
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
	   
	   
	   
		
	