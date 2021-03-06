
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
public class PatientDTOA extends DTOA
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
	
	
	/* Rol: Patient o--> PatientProfile */
	private PatientProfileDTOA patientProfile;
	public PatientProfileDTOA getPatientProfile () { return patientProfile; }
	public void setPatientProfile (PatientProfileDTOA patientProfile) { this.patientProfile = patientProfile; }

	/* Rol: Patient o--> User */
	private UserDTOA userData;
	public UserDTOA getUserData () { return userData; }
	public void setUserData (UserDTOA userData) { this.userData = userData; }

	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public PatientDTOA ()
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
			

			JSONObject jsonPatientProfile = json.optJSONObject("PatientProfile");
			if (jsonPatientProfile != null)
			{
				PatientProfileDTOA tmp = new PatientProfileDTOA();
				tmp.setFromJSON(jsonPatientProfile);
				this.patientProfile = tmp;
			}


			JSONObject jsonUserData = json.optJSONObject("UserData");
			if (jsonUserData != null)
			{
				UserDTOA tmp = new UserDTOA();
				tmp.setFromJSON(jsonUserData);
				this.userData = tmp;
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
		
			

			if (this.patientProfile != null)
			{
				json.put("PatientProfile", this.patientProfile.toJSON());
			}


			if (this.userData != null)
			{
				json.put("UserData", this.userData.toJSON());
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
		PatientDTO dto = new PatientDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
	dto.setName (this.getName());

	dto.setDescription (this.getDescription());

		
		
		// Roles
					// TODO: from DTOA [ PatientProfile ] (dataType : PatientProfileDTOA) to DTO [ PatientProfile ]
					// TODO: from DTOA [ UserData ] (dataType : UserDTOA) to DTO [ UserPatient ]
		
		
		return dto;
	}

	// endregion
}

	