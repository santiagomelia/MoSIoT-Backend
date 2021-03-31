
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
public class StateTelemetryDTOA extends DTOA
{
	// region - Members, getters and setters

	private Integer id;
	public Integer getId () { return id; }
	public void setId (Integer id) { this.id = id; }

	
	
	/* Rol: StateTelemetry o--> StateDevice */
	private ArrayList<StateDeviceDTOA> states;
	public ArrayList<StateDeviceDTOA> getStates () { return states; }
	public void setStates (ArrayList<StateDeviceDTOA> states) { this.states = states; }

	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public StateTelemetryDTOA ()
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
			
			

			JSONObject jsonStates = json.optJSONObject("States");
			if (jsonStates != null)
			{
				StateDeviceDTOA tmp = new StateDeviceDTOA();
				tmp.setFromJSON(jsonStates);
				this.states = tmp;
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
			
			

			if (this.states != null)
			{
				json.put("States", this.states.toJSON());
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
		StateTelemetryDTO dto = new StateTelemetryDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
		
		
		// Roles
					// TODO: from DTOA [ States ] (dataType : ArrayList<StateDeviceDTOA>) to DTO [ RangeStates ]
		
		
		return dto;
	}

	// endregion
}

	