	
		package MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO;
		
		import java.util.ArrayList;
		
		import org.json.JSONArray;
		import org.json.JSONException;
		import org.json.JSONObject;
		import  MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO.utils.*;
		import  MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO.enumerations.*;
		
		
		/**
		 * Code autogenerated. Do not modify this file.
		 */
		
		
		public class RegisterDTO extends    		EntityOperationDTO
	    implements IDTO
	    {
				private Integer entityAttributes_oid;
				public Integer  getEntityAttributes_oid () { return entityAttributes_oid; } 
				public void setEntityAttributes_oid (Integer value) { entityAttributes_oid = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{

						if (this.entityAttributes_oid != null)
						{
							json.put("EntityAttributes_oid", this.entityAttributes_oid.intValue());
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
	   
	   
	   
		
	