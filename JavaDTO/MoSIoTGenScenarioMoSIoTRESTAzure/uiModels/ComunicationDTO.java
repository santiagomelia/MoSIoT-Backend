	
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
		
		
		public class ComunicationDTO 	    implements IDTO
	    {
				private SeverityEvent severity;
				public SeverityEvent getSeverity () { return severity; } 
				public void setSeverity  (SeverityEvent value) { severity = value;  } 
				    	 
				private String message;
				public String getMessage () { return message; } 
				public void setMessage  (String value) { message = value;  } 
				    	 
				private java.util.Date sendDate;
				public java.util.Date getSendDate () { return sendDate; } 
				public void setSendDate  (java.util.Date value) { sendDate = value;  } 
				    	 
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private ArrayList<Integer> eventTelemetry_oid;
				public ArrayList<Integer>  getEventTelemetry_oid () { return eventTelemetry_oid; } 
				public void setEventTelemetry_oid (ArrayList<Integer> value) { eventTelemetry_oid = value;  } 
				    	 
				private Integer careActivity_oid;
				public Integer  getCareActivity_oid () { return careActivity_oid; } 
				public void setCareActivity_oid (Integer value) { careActivity_oid = value;  } 
				    	 
				private Integer carePlanTemplate_oid;
				public Integer  getCarePlanTemplate_oid () { return carePlanTemplate_oid; } 
				public void setCarePlanTemplate_oid (Integer value) { carePlanTemplate_oid = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{
				
						  json.put("Severity", this.severity.getRawValue());
				
				
						  json.put("Message", this.message);
				
				
						  json.put("SendDate", DateUtils.dateToFormatString(this.sendDate));
				
				
						  json.put("Id", this.id.intValue());
				

						if (this.eventTelemetry_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.eventTelemetry_oid.size(); ++i)
							{
								jsonArray.put(this.eventTelemetry_oid.get(i));
							}
							json.put("EventTelemetry_oid", jsonArray);
						}
		

						if (this.careActivity_oid != null)
						{
							json.put("CareActivity_oid", this.careActivity_oid.intValue());
						}

						if (this.carePlanTemplate_oid != null)
						{
							json.put("CarePlanTemplate_oid", this.carePlanTemplate_oid.intValue());
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
	   
	   
	   
		
	