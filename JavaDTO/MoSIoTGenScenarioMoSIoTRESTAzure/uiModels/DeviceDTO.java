	
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
		
		
		public class DeviceDTO extends    		EntityDTO
	    implements IDTO
	    {
				private Boolean deviceSwitch;
				public Boolean getDeviceSwitch () { return deviceSwitch; } 
				public void setDeviceSwitch  (Boolean value) { deviceSwitch = value;  } 
				    	 
				private String tag;
				public String getTag () { return tag; } 
				public void setTag  (String value) { tag = value;  } 
				    	 
				private Boolean isSimulated;
				public Boolean getIsSimulated () { return isSimulated; } 
				public void setIsSimulated  (Boolean value) { isSimulated = value;  } 
				    	 
				private String serialNumber;
				public String getSerialNumber () { return serialNumber; } 
				public void setSerialNumber  (String value) { serialNumber = value;  } 
				    	 
				private String firmVersion;
				public String getFirmVersion () { return firmVersion; } 
				public void setFirmVersion  (String value) { firmVersion = value;  } 
				    	 
				private String trademark;
				public String getTrademark () { return trademark; } 
				public void setTrademark  (String value) { trademark = value;  } 
				    	 
				private Integer deviceTemplate_oid;
				public Integer  getDeviceTemplate_oid () { return deviceTemplate_oid; } 
				public void setDeviceTemplate_oid (Integer value) { deviceTemplate_oid = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{
				
						  json.put("DeviceSwitch", this.deviceSwitch);
				
				
						  json.put("Tag", this.tag);
				
				
						  json.put("IsSimulated", this.isSimulated);
				
				
						  json.put("SerialNumber", this.serialNumber);
				
				
						  json.put("FirmVersion", this.firmVersion);
				
				
						  json.put("Trademark", this.trademark);
				

						if (this.deviceTemplate_oid != null)
						{
							json.put("DeviceTemplate_oid", this.deviceTemplate_oid.intValue());
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
	   
	   
	   
		
	