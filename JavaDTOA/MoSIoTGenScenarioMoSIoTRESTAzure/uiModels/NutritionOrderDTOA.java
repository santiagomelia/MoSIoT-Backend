
package MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTOA;

import MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO.*;
import MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO.utils.*;
import MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO.enumerations.*;

import java.util.ArrayList;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/**
 * Code autogenerated. Do not modify this file.
 */
public class NutritionOrderDTOA extends DTOA
{
	// region - Members, getters and setters

	private Integer id;
	public Integer getId () { return id; }
	public void setId (Integer id) { this.id = id; }

	
	private String description;
	public String getDescription () { return description; }
	public void setDescription (String description) { this.description = description; }
	
	private String dietCode;
	public String getDietCode () { return dietCode; }
	public void setDietCode (String dietCode) { this.dietCode = dietCode; }
	
	private String name;
	public String getName () { return name; }
	public void setName (String name) { this.name = name; }
	
	
	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public NutritionOrderDTOA ()
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

			if (!JSONObject.NULL.equals(json.opt("DietCode")))
			{
			 
				this.dietCode = (String) json.opt("DietCode");
			 
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
		
		
		  if (this.dietCode != null)
			json.put("DietCode", this.dietCode);
		
		
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
		NutritionOrderDTO dto = new NutritionOrderDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
	dto.setDescription (this.getDescription());

	dto.setDietCode (this.getDietCode());

	dto.setName (this.getName());

		
		
		// Roles
		
		
		return dto;
	}

	// endregion
}

	