	
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
		
		
		public class EntityStateDTO 	    implements IDTO
	    {
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private Integer virtualEntity_oid;
				public Integer  getVirtualEntity_oid () { return virtualEntity_oid; } 
				public void setVirtualEntity_oid (Integer value) { virtualEntity_oid = value;  } 
				    	 
				private ArrayList<Integer> originOperations_oid;
				public ArrayList<Integer>  getOriginOperations_oid () { return originOperations_oid; } 
				public void setOriginOperations_oid (ArrayList<Integer> value) { originOperations_oid = value;  } 
				    	 
				private ArrayList<Integer> targetOperations_oid;
				public ArrayList<Integer>  getTargetOperations_oid () { return targetOperations_oid; } 
				public void setTargetOperations_oid (ArrayList<Integer> value) { targetOperations_oid = value;  } 
				    	 
				private StateType type;
				public StateType getType () { return type; } 
				public void setType  (StateType value) { type = value;  } 
				    	 
				private String name;
				public String getName () { return name; } 
				public void setName  (String value) { name = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{
				
						  json.put("Id", this.id.intValue());
				

						if (this.virtualEntity_oid != null)
						{
							json.put("VirtualEntity_oid", this.virtualEntity_oid.intValue());
						}

						if (this.originOperations_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.originOperations_oid.size(); ++i)
							{
								jsonArray.put(this.originOperations_oid.get(i));
							}
							json.put("OriginOperations_oid", jsonArray);
						}
		

						if (this.targetOperations_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.targetOperations_oid.size(); ++i)
							{
								jsonArray.put(this.targetOperations_oid.get(i));
							}
							json.put("TargetOperations_oid", jsonArray);
						}
		
				
						  json.put("Type", this.type.getRawValue());
				
				
						  json.put("Name", this.name);
				
				
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
	   
	   
	   
		
	