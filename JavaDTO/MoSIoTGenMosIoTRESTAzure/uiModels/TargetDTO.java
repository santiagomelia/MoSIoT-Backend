	
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
		
		
		public class TargetDTO 	    implements IDTO
	    {
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private Integer goal_oid;
				public Integer  getGoal_oid () { return goal_oid; } 
				public void setGoal_oid (Integer value) { goal_oid = value;  } 
				    	 
				private String desiredValue;
				public String getDesiredValue () { return desiredValue; } 
				public void setDesiredValue  (String value) { desiredValue = value;  } 
				    	 
				private Integer measure_oid;
				public Integer  getMeasure_oid () { return measure_oid; } 
				public void setMeasure_oid (Integer value) { measure_oid = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
				private java.util.Date dueDate;
				public java.util.Date getDueDate () { return dueDate; } 
				public void setDueDate  (java.util.Date value) { dueDate = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{
				
						  json.put("Id", this.id.intValue());
				

						if (this.goal_oid != null)
						{
							json.put("Goal_oid", this.goal_oid.intValue());
						}
				
						  json.put("DesiredValue", this.desiredValue);
				

						if (this.measure_oid != null)
						{
							json.put("Measure_oid", this.measure_oid.intValue());
						}
				
						  json.put("Description", this.description);
				
				
						  json.put("DueDate", DateUtils.dateToFormatString(this.dueDate));
				
						
					}
					catch (JSONException e)
					{
						e.printStackTrace();
					}
				
				return json;
			}
		
			// endregion
		}
	   
	   
	   
		
	