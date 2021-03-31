
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
public class CarePlanDTOA extends DTOA
{
	// region - Members, getters and setters

	private Integer id;
	public Integer getId () { return id; }
	public void setId (Integer id) { this.id = id; }

	
	private java.util.Date startDate;
	public java.util.Date getStartDate () { return startDate; }
	public void setStartDate (java.util.Date startDate) { this.startDate = startDate; }
	
	private java.util.Date endDate;
	public java.util.Date getEndDate () { return endDate; }
	public void setEndDate (java.util.Date endDate) { this.endDate = endDate; }
	
	private CareStatus status;
	public CareStatus getStatus () { return status; }
	public void setStatus (CareStatus status) { this.status = status; }
	
	private CarePlanInent intent;
	public CarePlanInent getIntent () { return intent; }
	public void setIntent (CarePlanInent intent) { this.intent = intent; }
	
	private String title;
	public String getTitle () { return title; }
	public void setTitle (String title) { this.title = title; }
	
	private java.util.Date modified;
	public java.util.Date getModified () { return modified; }
	public void setModified (java.util.Date modified) { this.modified = modified; }
	
	
	/* Rol: CarePlan o--> CareActivity */
	private ArrayList<CareActivityDTOA> careActivities;
	public ArrayList<CareActivityDTOA> getCareActivities () { return careActivities; }
	public void setCareActivities (ArrayList<CareActivityDTOA> careActivities) { this.careActivities = careActivities; }

	/* Rol: CarePlan o--> VitalSign */
	private ArrayList<VitalSignDTOA> vitalSigns;
	public ArrayList<VitalSignDTOA> getVitalSigns () { return vitalSigns; }
	public void setVitalSigns (ArrayList<VitalSignDTOA> vitalSigns) { this.vitalSigns = vitalSigns; }

	/* Rol: CarePlan o--> Goal */
	private ArrayList<GoalDTOA> goals;
	public ArrayList<GoalDTOA> getGoals () { return goals; }
	public void setGoals (ArrayList<GoalDTOA> goals) { this.goals = goals; }

	/* Rol: CarePlan o--> PatientProfileCare */
	private PatientProfileCareDTOA patient;
	public PatientProfileCareDTOA getPatient () { return patient; }
	public void setPatient (PatientProfileCareDTOA patient) { this.patient = patient; }

	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public CarePlanDTOA ()
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
			

			if (!JSONObject.NULL.equals(json.opt("StartDate")))
			{
			 
			 	String stringDate = (String) json.opt("StartDate");
				this.startDate = DateUtils.stringToDateFormat(stringDate);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("EndDate")))
			{
			 
			 	String stringDate = (String) json.opt("EndDate");
				this.endDate = DateUtils.stringToDateFormat(stringDate);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Status")))
			{
				int enumRawValue = (int) json.opt("Status");
				this.status = CareStatus.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Intent")))
			{
				int enumRawValue = (int) json.opt("Intent");
				this.intent = CarePlanInent.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Title")))
			{
			 
				this.title = (String) json.opt("Title");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Modified")))
			{
			 
			 	String stringDate = (String) json.opt("Modified");
				this.modified = DateUtils.stringToDateFormat(stringDate);
			 
			}
			

			JSONObject jsonCareActivities = json.optJSONObject("CareActivities");
			if (jsonCareActivities != null)
			{
				CareActivityDTOA tmp = new CareActivityDTOA();
				tmp.setFromJSON(jsonCareActivities);
				this.careActivities = tmp;
			}


			JSONObject jsonVitalSigns = json.optJSONObject("VitalSigns");
			if (jsonVitalSigns != null)
			{
				VitalSignDTOA tmp = new VitalSignDTOA();
				tmp.setFromJSON(jsonVitalSigns);
				this.vitalSigns = tmp;
			}


			JSONObject jsonGoals = json.optJSONObject("Goals");
			if (jsonGoals != null)
			{
				GoalDTOA tmp = new GoalDTOA();
				tmp.setFromJSON(jsonGoals);
				this.goals = tmp;
			}


			JSONObject jsonPatient = json.optJSONObject("Patient");
			if (jsonPatient != null)
			{
				PatientProfileCareDTOA tmp = new PatientProfileCareDTOA();
				tmp.setFromJSON(jsonPatient);
				this.patient = tmp;
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
			
		
		  if (this.startDate != null)
			json.put("StartDate", DateUtils.dateToFormatString(this.startDate));
		
		
		  if (this.endDate != null)
			json.put("EndDate", DateUtils.dateToFormatString(this.endDate));
		
		
		  if (this.status != null)
			json.put("Status", this.status.getRawValue());
		
		
		  if (this.intent != null)
			json.put("Intent", this.intent.getRawValue());
		
		
		  if (this.title != null)
			json.put("Title", this.title);
		
		
		  if (this.modified != null)
			json.put("Modified", DateUtils.dateToFormatString(this.modified));
		
			

			if (this.careActivities != null)
			{
				json.put("CareActivities", this.careActivities.toJSON());
			}


			if (this.vitalSigns != null)
			{
				json.put("VitalSigns", this.vitalSigns.toJSON());
			}


			if (this.goals != null)
			{
				json.put("Goals", this.goals.toJSON());
			}


			if (this.patient != null)
			{
				json.put("Patient", this.patient.toJSON());
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
		CarePlanDTO dto = new CarePlanDTO ();
		
		// Attributes
		
	dto.setId (this.getId());

		
	dto.setStartDate (this.getStartDate());

	dto.setEndDate (this.getEndDate());

	dto.setStatus (this.getStatus());

	dto.setIntent (this.getIntent());

	dto.setTitle (this.getTitle());

	dto.setModified (this.getModified());

		
		
		// Roles
					// TODO: from DTOA [ CareActivities ] (dataType : ArrayList<CareActivityDTOA>) to DTO [ CareActivity ]
					// TODO: from DTOA [ VitalSigns ] (dataType : ArrayList<VitalSignDTOA>) to DTO [ VitalSign ]
					// TODO: from DTOA [ Goals ] (dataType : ArrayList<GoalDTOA>) to DTO [ Goals ]
					// TODO: from DTOA [ Patient ] (dataType : PatientProfileCareDTOA) to DTO [ PatientProfile ]
		
		
		return dto;
	}

	// endregion
}

	