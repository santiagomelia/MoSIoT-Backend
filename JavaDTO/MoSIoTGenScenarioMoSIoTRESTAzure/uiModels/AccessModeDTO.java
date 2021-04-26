	
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
		
		
		public class AccessModeDTO 	    implements IDTO
	    {
				private Integer patient_oid;
				public Integer  getPatient_oid () { return patient_oid; } 
				public void setPatient_oid (Integer value) { patient_oid = value;  } 
				    	 
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
				private AccessModeValue typeAccessMode;
				public AccessModeValue getTypeAccessMode () { return typeAccessMode; } 
				public void setTypeAccessMode  (AccessModeValue value) { typeAccessMode = value;  } 
				    	 
				private ArrayList<AdaptationDetailRequiredDTO> adaptationDetailRequired;
				public ArrayList<AdaptationDetailRequiredDTO> getAdaptationDetailRequired () { return adaptationDetailRequired; } 
				public void setAdaptationDetailRequired (ArrayList<AdaptationDetailRequiredDTO> value) { adaptationDetailRequired = value;  } 
				    	 
				private ArrayList<Integer> deviceTemplate_oid;
				public ArrayList<Integer>  getDeviceTemplate_oid () { return deviceTemplate_oid; } 
				public void setDeviceTemplate_oid (ArrayList<Integer> value) { deviceTemplate_oid = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
				private ArrayList<AdaptationTypeRequiredDTO> adaptationTypeRequired;
				public ArrayList<AdaptationTypeRequiredDTO> getAdaptationTypeRequired () { return adaptationTypeRequired; } 
				public void setAdaptationTypeRequired (ArrayList<AdaptationTypeRequiredDTO> value) { adaptationTypeRequired = value;  } 
				    	 
				private ArrayList<AdaptationRequestDTO> adaptationRequest;
				public ArrayList<AdaptationRequestDTO> getAdaptationRequest () { return adaptationRequest; } 
				public void setAdaptationRequest (ArrayList<AdaptationRequestDTO> value) { adaptationRequest = value;  } 
				    	 
				private Integer disability_oid;
				public Integer  getDisability_oid () { return disability_oid; } 
				public void setDisability_oid (Integer value) { disability_oid = value;  } 
				    	 
				private String name;
				public String getName () { return name; } 
				public void setName  (String value) { name = value;  } 
				    	 
	   
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
				
				
						  json.put("TypeAccessMode", this.typeAccessMode.getRawValue());
				

						if (this.adaptationDetailRequired != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.adaptationDetailRequired.size(); ++i)
							{
								jsonArray.put(this.adaptationDetailRequired.get(i).toJSON());
							}
							json.put("AdaptationDetailRequired", jsonArray);
						}

						if (this.deviceTemplate_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.deviceTemplate_oid.size(); ++i)
							{
								jsonArray.put(this.deviceTemplate_oid.get(i));
							}
							json.put("DeviceTemplate_oid", jsonArray);
						}
		
				
						  json.put("Description", this.description);
				

						if (this.adaptationTypeRequired != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.adaptationTypeRequired.size(); ++i)
							{
								jsonArray.put(this.adaptationTypeRequired.get(i).toJSON());
							}
							json.put("AdaptationTypeRequired", jsonArray);
						}

						if (this.adaptationRequest != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.adaptationRequest.size(); ++i)
							{
								jsonArray.put(this.adaptationRequest.get(i).toJSON());
							}
							json.put("AdaptationRequest", jsonArray);
						}

						if (this.disability_oid != null)
						{
							json.put("Disability_oid", this.disability_oid.intValue());
						}
				
						  json.put("Name", this.name);
				
						
					}
					catch (JSONException e)
					{
						e.printStackTrace();
					}
				
				return json;
			}
		
			// endregion
		}
	   
	   
	   
		
	