	
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
		
		
		public class MedicationDTO 	    implements IDTO
	    {
				private Integer careActivity_oid;
				public Integer  getCareActivity_oid () { return careActivity_oid; } 
				public void setCareActivity_oid (Integer value) { careActivity_oid = value;  } 
				    	 
				private Integer productReference;
				public Integer getProductReference () { return productReference; } 
				public void setProductReference  (Integer value) { productReference = value;  } 
				    	 
				private String name;
				public String getName () { return name; } 
				public void setName  (String value) { name = value;  } 
				    	 
				private String manufacturer;
				public String getManufacturer () { return manufacturer; } 
				public void setManufacturer  (String value) { manufacturer = value;  } 
				    	 
				private String description;
				public String getDescription () { return description; } 
				public void setDescription  (String value) { description = value;  } 
				    	 
				private String dosage;
				public String getDosage () { return dosage; } 
				public void setDosage  (String value) { dosage = value;  } 
				    	 
				private FormType form;
				public FormType getForm () { return form; } 
				public void setForm  (FormType value) { form = value;  } 
				    	 
				private String medicationCode;
				public String getMedicationCode () { return medicationCode; } 
				public void setMedicationCode  (String value) { medicationCode = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{

						if (this.careActivity_oid != null)
						{
							json.put("CareActivity_oid", this.careActivity_oid.intValue());
						}
				
						  json.put("ProductReference", this.productReference.intValue());
				
				
						  json.put("Name", this.name);
				
				
						  json.put("Manufacturer", this.manufacturer);
				
				
						  json.put("Description", this.description);
				
				
						  json.put("Dosage", this.dosage);
				
				
						  json.put("Form", this.form.getRawValue());
				
				
						  json.put("MedicationCode", this.medicationCode);
				
						
					}
					catch (JSONException e)
					{
						e.printStackTrace();
					}
				
				return json;
			}
		
			// endregion
		}
	   
	   
	   
		
	