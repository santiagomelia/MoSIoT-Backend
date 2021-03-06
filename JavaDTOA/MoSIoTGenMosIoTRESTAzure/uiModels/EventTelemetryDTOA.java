
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
public class EventTelemetryDTOA extends DTOA
{
	// region - Members, getters and setters

	private Integer id;
	public Integer getId () { return id; }
	public void setId (Integer id) { this.id = id; }

	
	private SeverityEvent severity;
	public SeverityEvent getSeverity () { return severity; }
	public void setSeverity (SeverityEvent severity) { this.severity = severity; }
	
	
	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public EventTelemetryDTOA ()
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
			

			if (!JSONObject.NULL.equals(json.opt("Severity")))
			{
				int enumRawValue = (int) json.opt("Severity");
				this.severity = SeverityEvent.fromRawValue(enumRawValue);
			 
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
			
		
		  if (this.severity != null)
			json.put("Severity", this.severity.getRawValue());
		
			
			
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
		EventTelemetryDTO dto = new EventTelemetryDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
	dto.setSeverity (this.getSeverity());

		
		
		// Roles
		
		
		return dto;
	}

	// endregion
}

	