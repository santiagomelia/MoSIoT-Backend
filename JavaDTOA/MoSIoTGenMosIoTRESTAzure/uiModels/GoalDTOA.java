
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
public class GoalDTOA extends DTOA
{
	// region - Members, getters and setters

	private Integer id;
	public Integer getId () { return id; }
	public void setId (Integer id) { this.id = id; }

	
	private PriorityType priority;
	public PriorityType getPriority () { return priority; }
	public void setPriority (PriorityType priority) { this.priority = priority; }
	
	private CareStatus status;
	public CareStatus getStatus () { return status; }
	public void setStatus (CareStatus status) { this.status = status; }
	
	private String description;
	public String getDescription () { return description; }
	public void setDescription (String description) { this.description = description; }
	
	private CategoryGoal category;
	public CategoryGoal getCategory () { return category; }
	public void setCategory (CategoryGoal category) { this.category = category; }
	
	private String outcomeCode;
	public String getOutcomeCode () { return outcomeCode; }
	public void setOutcomeCode (String outcomeCode) { this.outcomeCode = outcomeCode; }
	
	private String name;
	public String getName () { return name; }
	public void setName (String name) { this.name = name; }
	
	
	/* Rol: Goal o--> Target */
	private ArrayList<TargetDTOA> targets;
	public ArrayList<TargetDTOA> getTargets () { return targets; }
	public void setTargets (ArrayList<TargetDTOA> targets) { this.targets = targets; }

	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public GoalDTOA ()
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
			

			if (!JSONObject.NULL.equals(json.opt("Priority")))
			{
				int enumRawValue = (int) json.opt("Priority");
				this.priority = PriorityType.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Status")))
			{
				int enumRawValue = (int) json.opt("Status");
				this.status = CareStatus.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Description")))
			{
			 
				this.description = (String) json.opt("Description");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Category")))
			{
				int enumRawValue = (int) json.opt("Category");
				this.category = CategoryGoal.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("OutcomeCode")))
			{
			 
				this.outcomeCode = (String) json.opt("OutcomeCode");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Name")))
			{
			 
				this.name = (String) json.opt("Name");
			 
			}
			

			JSONObject jsonTargets = json.optJSONObject("Targets");
			if (jsonTargets != null)
			{
				TargetDTOA tmp = new TargetDTOA();
				tmp.setFromJSON(jsonTargets);
				this.targets = tmp;
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
			
		
		  if (this.priority != null)
			json.put("Priority", this.priority.getRawValue());
		
		
		  if (this.status != null)
			json.put("Status", this.status.getRawValue());
		
		
		  if (this.description != null)
			json.put("Description", this.description);
		
		
		  if (this.category != null)
			json.put("Category", this.category.getRawValue());
		
		
		  if (this.outcomeCode != null)
			json.put("OutcomeCode", this.outcomeCode);
		
		
		  if (this.name != null)
			json.put("Name", this.name);
		
			

			if (this.targets != null)
			{
				json.put("Targets", this.targets.toJSON());
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
		GoalDTO dto = new GoalDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
	dto.setPriority (this.getPriority());

	dto.setStatus (this.getStatus());

	dto.setDescription (this.getDescription());

	dto.setCategory (this.getCategory());

	dto.setOutcomeCode (this.getOutcomeCode());

	dto.setName (this.getName());

		
		
		// Roles
					// TODO: from DTOA [ Targets ] (dataType : ArrayList<TargetDTOA>) to DTO [ Targets ]
		
		
		return dto;
	}

	// endregion
}

	