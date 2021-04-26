	
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
		
		
		public class EntityOperationDTO 	    implements IDTO
	    {
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private String name;
				public String getName () { return name; } 
				public void setName  (String value) { name = value;  } 
				    	 
				private DataType type;
				public DataType getType () { return type; } 
				public void setType  (DataType value) { type = value;  } 
				    	 
				private ServiceType serviceType;
				public ServiceType getServiceType () { return serviceType; } 
				public void setServiceType  (ServiceType value) { serviceType = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
				private ArrayList<EntityArgumentDTO> entityArgument;
				public ArrayList<EntityArgumentDTO> getEntityArgument () { return entityArgument; } 
				public void setEntityArgument (ArrayList<EntityArgumentDTO> value) { entityArgument = value;  } 
				    	 
				private Integer entity_oid;
				public Integer  getEntity_oid () { return entity_oid; } 
				public void setEntity_oid (Integer value) { entity_oid = value;  } 
				    	 
				private ArrayList<Integer> ruleAction_oid;
				public ArrayList<Integer>  getRuleAction_oid () { return ruleAction_oid; } 
				public void setRuleAction_oid (ArrayList<Integer> value) { ruleAction_oid = value;  } 
				    	 
				private Integer originState_oid;
				public Integer  getOriginState_oid () { return originState_oid; } 
				public void setOriginState_oid (Integer value) { originState_oid = value;  } 
				    	 
				private Integer targetState_oid;
				public Integer  getTargetState_oid () { return targetState_oid; } 
				public void setTargetState_oid (Integer value) { targetState_oid = value;  } 
				    	 
				private ArrayList<Integer> triggers_oid;
				public ArrayList<Integer>  getTriggers_oid () { return triggers_oid; } 
				public void setTriggers_oid (ArrayList<Integer> value) { triggers_oid = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{
				
						  json.put("Id", this.id.intValue());
				
				
						  json.put("Name", this.name);
				
				
						  json.put("Type", this.type.getRawValue());
				
				
						  json.put("ServiceType", this.serviceType.getRawValue());
				
				
						  json.put("Description", this.description);
				

						if (this.entityArgument != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.entityArgument.size(); ++i)
							{
								jsonArray.put(this.entityArgument.get(i).toJSON());
							}
							json.put("EntityArgument", jsonArray);
						}

						if (this.entity_oid != null)
						{
							json.put("Entity_oid", this.entity_oid.intValue());
						}

						if (this.ruleAction_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.ruleAction_oid.size(); ++i)
							{
								jsonArray.put(this.ruleAction_oid.get(i));
							}
							json.put("RuleAction_oid", jsonArray);
						}
		

						if (this.originState_oid != null)
						{
							json.put("OriginState_oid", this.originState_oid.intValue());
						}

						if (this.targetState_oid != null)
						{
							json.put("TargetState_oid", this.targetState_oid.intValue());
						}

						if (this.triggers_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.triggers_oid.size(); ++i)
							{
								jsonArray.put(this.triggers_oid.get(i));
							}
							json.put("Triggers_oid", jsonArray);
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
	   
	   
	   
		
	