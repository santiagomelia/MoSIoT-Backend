
package MoSIoTGenMosIoTRESTAzure.uiModels.DTOA;

import MoSIoTGenMosIoTRESTAzure.uiModels.DTO.*;
import MoSIoTGenMosIoTRESTAzure.uiModels.DTO.utils.*;
import MoSIoTGenMosIoTRESTAzure.uiModels.DTO.enumerations.*;

import java.util.ArrayList;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/**
 * Code autogenerated. Do not modify this file.
 */
public class PatientProfileDTOA extends DTOA
{
	// region - Members, getters and setters

	private Integer id;
	public Integer getId () { return id; }
	public void setId (Integer id) { this.id = id; }

	
	private LanguageCode preferredLanguage;
	public LanguageCode getPreferredLanguage () { return preferredLanguage; }
	public void setPreferredLanguage (LanguageCode preferredLanguage) { this.preferredLanguage = preferredLanguage; }
	
	private String region;
	public String getRegion () { return region; }
	public void setRegion (String region) { this.region = region; }
	
	private HazardValue hazardAvoidance;
	public HazardValue getHazardAvoidance () { return hazardAvoidance; }
	public void setHazardAvoidance (HazardValue hazardAvoidance) { this.hazardAvoidance = hazardAvoidance; }
	
	private String name;
	public String getName () { return name; }
	public void setName (String name) { this.name = name; }
	
	private String description;
	public String getDescription () { return description; }
	public void setDescription (String description) { this.description = description; }
	
	
	/* Rol: PatientProfile o--> AccessMode */
	private ArrayList<AccessModeDTOA> accessMode;
	public ArrayList<AccessModeDTOA> getAccessMode () { return accessMode; }
	public void setAccessMode (ArrayList<AccessModeDTOA> accessMode) { this.accessMode = accessMode; }

	/* Rol: PatientProfile o--> Condition */
	private ArrayList<ConditionDTOA> condition;
	public ArrayList<ConditionDTOA> getCondition () { return condition; }
	public void setCondition (ArrayList<ConditionDTOA> condition) { this.condition = condition; }

	/* Rol: PatientProfile o--> Disability */
	private ArrayList<DisabilityDTOA> disabilities;
	public ArrayList<DisabilityDTOA> getDisabilities () { return disabilities; }
	public void setDisabilities (ArrayList<DisabilityDTOA> disabilities) { this.disabilities = disabilities; }

	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public PatientProfileDTOA ()
	{
		// Empty constructor
	}
	
	@Override
	public void setFromJSON (JSONObject json)
	{
		try
		{
			if (!JSONObject.NULL.equals(json.opt("Id")))
			{
				this.id = (Integer) json.opt("Id");
			}
			

			if (!JSONObject.NULL.equals(json.opt("PreferredLanguage")))
			{
				int enumRawValue = (int) json.opt("PreferredLanguage");
				this.preferredLanguage = LanguageCode.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Region")))
			{
			 
				this.region = (String) json.opt("Region");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("HazardAvoidance")))
			{
				int enumRawValue = (int) json.opt("HazardAvoidance");
				this.hazardAvoidance = HazardValue.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Name")))
			{
			 
				this.name = (String) json.opt("Name");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Description")))
			{
			 
				this.description = (String) json.opt("Description");
			 
			}
			

			JSONObject jsonAccessMode = json.optJSONObject("AccessMode");
			if (jsonAccessMode != null)
			{
				AccessModeDTOA tmp = new AccessModeDTOA();
				tmp.setFromJSON(jsonAccessMode);
				this.accessMode = tmp;
			}


			JSONObject jsonCondition = json.optJSONObject("Condition");
			if (jsonCondition != null)
			{
				ConditionDTOA tmp = new ConditionDTOA();
				tmp.setFromJSON(jsonCondition);
				this.condition = tmp;
			}


			JSONObject jsonDisabilities = json.optJSONObject("Disabilities");
			if (jsonDisabilities != null)
			{
				DisabilityDTOA tmp = new DisabilityDTOA();
				tmp.setFromJSON(jsonDisabilities);
				this.disabilities = tmp;
			}

			
		}
		catch (Exception e)
		{
			e.printStackTrace();
		}
	}
	
	public JSONObject toJSON ()
	{
		JSONObject json = new JSONObject();
		
		try
		{
			if (this.id != null){
				json.put("Id", this.id);
			}
			
		
		  if (this.preferredLanguage != null)
			json.put("PreferredLanguage", this.preferredLanguage.getRawValue());
		
		
		  if (this.region != null)
			json.put("Region", this.region);
		
		
		  if (this.hazardAvoidance != null)
			json.put("HazardAvoidance", this.hazardAvoidance.getRawValue());
		
		
		  if (this.name != null)
			json.put("Name", this.name);
		
		
		  if (this.description != null)
			json.put("Description", this.description);
		
			

			if (this.accessMode != null)
			{
				json.put("AccessMode", this.accessMode.toJSON());
			}


			if (this.condition != null)
			{
				json.put("Condition", this.condition.toJSON());
			}


			if (this.disabilities != null)
			{
				json.put("Disabilities", this.disabilities.toJSON());
			}

			
		}
		catch (JSONException e)
		{
			e.printStackTrace();
		}
		
		return json;
	}
	
	@Override 
	public IDTO toDTO ()
	{
		PatientProfileDTO dto = new PatientProfileDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
	dto.setPreferredLanguage (this.getPreferredLanguage());

	dto.setRegion (this.getRegion());

	dto.setHazardAvoidance (this.getHazardAvoidance());

	dto.setName (this.getName());

	dto.setDescription (this.getDescription());

		
		
		// Roles
					// TODO: from DTOA [ AccessMode ] (dataType : ArrayList<AccessModeDTOA>) to DTO [ AccessMode ]
					// TODO: from DTOA [ Condition ] (dataType : ArrayList<ConditionDTOA>) to DTO [ Diseases ]
					// TODO: from DTOA [ Disabilities ] (dataType : ArrayList<DisabilityDTOA>) to DTO [ Disability ]
		
		
		return dto;
	}

	// endregion
}

	