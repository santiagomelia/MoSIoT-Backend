
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
public class ConditionDTOA extends DTOA
{
	// region - Members, getters and setters

	private Integer id;
	public Integer getId () { return id; }
	public void setId (Integer id) { this.id = id; }

	
	private String description;
	public String getDescription () { return description; }
	public void setDescription (String description) { this.description = description; }
	
	private ClinicalStatus clinicalStatus;
	public ClinicalStatus getClinicalStatus () { return clinicalStatus; }
	public void setClinicalStatus (ClinicalStatus clinicalStatus) { this.clinicalStatus = clinicalStatus; }
	
	private Disease disease;
	public Disease getDisease () { return disease; }
	public void setDisease (Disease disease) { this.disease = disease; }
	
	private String name;
	public String getName () { return name; }
	public void setName (String name) { this.name = name; }
	
	
	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public ConditionDTOA ()
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
			

			if (!JSONObject.NULL.equals(json.opt("Description")))
			{
			 
				this.description = (String) json.opt("Description");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("ClinicalStatus")))
			{
				int enumRawValue = (int) json.opt("ClinicalStatus");
				this.clinicalStatus = ClinicalStatus.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Disease")))
			{
				int enumRawValue = (int) json.opt("Disease");
				this.disease = Disease.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Name")))
			{
			 
				this.name = (String) json.opt("Name");
			 
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
			
		
		  if (this.description != null)
			json.put("Description", this.description);
		
		
		  if (this.clinicalStatus != null)
			json.put("ClinicalStatus", this.clinicalStatus.getRawValue());
		
		
		  if (this.disease != null)
			json.put("Disease", this.disease.getRawValue());
		
		
		  if (this.name != null)
			json.put("Name", this.name);
		
			
			
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
		ConditionDTO dto = new ConditionDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
	dto.setDescription (this.getDescription());

	dto.setClinicalStatus (this.getClinicalStatus());

	dto.setDisease (this.getDisease());

	dto.setName (this.getName());

		
		
		// Roles
		
		
		return dto;
	}

	// endregion
}

	