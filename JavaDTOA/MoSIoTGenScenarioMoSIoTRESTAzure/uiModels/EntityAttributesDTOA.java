
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
public class EntityAttributesDTOA extends DTOA
{
	// region - Members, getters and setters

	private Integer id;
	public Integer getId () { return id; }
	public void setId (Integer id) { this.id = id; }

	
	private String name;
	public String getName () { return name; }
	public void setName (String name) { this.name = name; }
	
	private DataType type;
	public DataType getType () { return type; }
	public void setType (DataType type) { this.type = type; }
	
	private Boolean isOID;
	public Boolean getIsOID () { return isOID; }
	public void setIsOID (Boolean isOID) { this.isOID = isOID; }
	
	private AssociationType associationType;
	public AssociationType getAssociationType () { return associationType; }
	public void setAssociationType (AssociationType associationType) { this.associationType = associationType; }
	
	private Boolean isWritable;
	public Boolean getIsWritable () { return isWritable; }
	public void setIsWritable (Boolean isWritable) { this.isWritable = isWritable; }
	
	private String description;
	public String getDescription () { return description; }
	public void setDescription (String description) { this.description = description; }
	
	
	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public EntityAttributesDTOA ()
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
			

			if (!JSONObject.NULL.equals(json.opt("Name")))
			{
			 
				this.name = (String) json.opt("Name");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Type")))
			{
				int enumRawValue = (int) json.opt("Type");
				this.type = DataType.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("IsOID")))
			{
			 
				this.isOID = (Boolean) json.opt("IsOID");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("AssociationType")))
			{
				int enumRawValue = (int) json.opt("AssociationType");
				this.associationType = AssociationType.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("IsWritable")))
			{
			 
				this.isWritable = (Boolean) json.opt("IsWritable");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Description")))
			{
			 
				this.description = (String) json.opt("Description");
			 
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
			
		
		  if (this.name != null)
			json.put("Name", this.name);
		
		
		  if (this.type != null)
			json.put("Type", this.type.getRawValue());
		
		
		  if (this.isOID != null)
			json.put("IsOID", this.isOID);
		
		
		  if (this.associationType != null)
			json.put("AssociationType", this.associationType.getRawValue());
		
		
		  if (this.isWritable != null)
			json.put("IsWritable", this.isWritable);
		
		
		  if (this.description != null)
			json.put("Description", this.description);
		
			
			
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
		EntityAttributesDTO dto = new EntityAttributesDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
	dto.setName (this.getName());

	dto.setType (this.getType());

	dto.setIsOID (this.getIsOID());

	dto.setAssociationType (this.getAssociationType());

	dto.setIsWritable (this.getIsWritable());

	dto.setDescription (this.getDescription());

		
		
		// Roles
		
		
		return dto;
	}

	// endregion
}

	