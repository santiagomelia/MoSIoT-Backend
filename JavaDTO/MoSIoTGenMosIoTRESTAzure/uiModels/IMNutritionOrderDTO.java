	
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
		
		
		public class IMNutritionOrderDTO extends    		EntityAttributesDTO
	    implements IDTO
	    {
				private Integer nutritionOrder_oid;
				public Integer  getNutritionOrder_oid () { return nutritionOrder_oid; } 
				public void setNutritionOrder_oid (Integer value) { nutritionOrder_oid = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{

						if (this.nutritionOrder_oid != null)
						{
							json.put("NutritionOrder_oid", this.nutritionOrder_oid.intValue());
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
	   
	   
	   
		
	