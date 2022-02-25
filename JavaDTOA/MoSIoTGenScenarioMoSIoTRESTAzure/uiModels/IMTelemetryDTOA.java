
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
public class IMTelemetryDTOA extends DTOA
{
	// region - Members, getters and setters

	private Integer id;
	public Integer getId () { return id; }
	public void setId (Integer id) { this.id = id; }

	
	private String name;
	public String getName () { return name; }
	public void setName (String name) { this.name = name; }
	
	private String description;
	public String getDescription () { return description; }
	public void setDescription (String description) { this.description = description; }
	
	
	/* Rol: IMTelemetry o--> Telemetry */
	private TelemetryDTOA telemetry;
	public TelemetryDTOA getTelemetry () { return telemetry; }
	public void setTelemetry (TelemetryDTOA telemetry) { this.telemetry = telemetry; }

	/* Rol: IMTelemetry o--> IMTelemetryValues */
	private ArrayList<IMTelemetryValuesDTOA> teleValues;
	public ArrayList<IMTelemetryValuesDTOA> getTeleValues () { return teleValues; }
	public void setTeleValues (ArrayList<IMTelemetryValuesDTOA> teleValues) { this.teleValues = teleValues; }

	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public IMTelemetryDTOA ()
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

			if (!JSONObject.NULL.equals(json.opt("Description")))
			{
			 
				this.description = (String) json.opt("Description");
			 
			}
			

			JSONObject jsonTelemetry = json.optJSONObject("Telemetry");
			if (jsonTelemetry != null)
			{
				TelemetryDTOA tmp = new TelemetryDTOA();
				tmp.setFromJSON(jsonTelemetry);
				this.telemetry = tmp;
			}


			JSONObject jsonTeleValues = json.optJSONObject("TeleValues");
			if (jsonTeleValues != null)
			{
				IMTelemetryValuesDTOA tmp = new IMTelemetryValuesDTOA();
				tmp.setFromJSON(jsonTeleValues);
				this.teleValues = tmp;
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
		
		
		  if (this.description != null)
			json.put("Description", this.description);
		
			

			if (this.telemetry != null)
			{
				json.put("Telemetry", this.telemetry.toJSON());
			}


			if (this.teleValues != null)
			{
				json.put("TeleValues", this.teleValues.toJSON());
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
		IMTelemetryDTO dto = new IMTelemetryDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
	dto.setName (this.getName());

	dto.setDescription (this.getDescription());

		
		
		// Roles
					// TODO: from DTOA [ Telemetry ] (dataType : TelemetryDTOA) to DTO [ Telemetry ]
					// TODO: from DTOA [ TeleValues ] (dataType : ArrayList<IMTelemetryValuesDTOA>) to DTO [ IMTelemetryValues ]
		
		
		return dto;
	}

	// endregion
}

	