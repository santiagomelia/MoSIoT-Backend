
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
public class IMTelemetryValuesDTOA extends DTOA
{
	// region - Members, getters and setters

	private Integer id;
	public Integer getId () { return id; }
	public void setId (Integer id) { this.id = id; }

	
	private java.util.Date timeStamp;
	public java.util.Date getTimeStamp () { return timeStamp; }
	public void setTimeStamp (java.util.Date timeStamp) { this.timeStamp = timeStamp; }
	
	private String valu;
	public String getValu () { return valu; }
	public void setValu (String valu) { this.valu = valu; }
	
	
	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public IMTelemetryValuesDTOA ()
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
			

			if (!JSONObject.NULL.equals(json.opt("TimeStamp")))
			{
			 
			 	String stringDate = (String) json.opt("TimeStamp");
				this.timeStamp = DateUtils.stringToDateFormat(stringDate);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Valu")))
			{
			 
				this.valu = (String) json.opt("Valu");
			 
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
			
		
		  if (this.timeStamp != null)
			json.put("TimeStamp", DateUtils.dateToFormatString(this.timeStamp));
		
		
		  if (this.valu != null)
			json.put("Valu", this.valu);
		
			
			
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
		IMTelemetryValuesDTO dto = new IMTelemetryValuesDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
	dto.setTimeStamp (this.getTimeStamp());

	dto.setValu (this.getValu());

		
		
		// Roles
		
		
		return dto;
	}

	// endregion
}

	