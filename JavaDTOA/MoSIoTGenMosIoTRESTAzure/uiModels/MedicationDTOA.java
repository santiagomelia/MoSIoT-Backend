
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
public class MedicationDTOA extends DTOA
{
	// region - Members, getters and setters

	
	private Integer productReference;
	public Integer getProductReference () { return productReference; }
	public void setProductReference (Integer productReference) { this.productReference = productReference; }
	
	private String name;
	public String getName () { return name; }
	public void setName (String name) { this.name = name; }
	
	private String manufacturer;
	public String getManufacturer () { return manufacturer; }
	public void setManufacturer (String manufacturer) { this.manufacturer = manufacturer; }
	
	private String description;
	public String getDescription () { return description; }
	public void setDescription (String description) { this.description = description; }
	
	private String dosage;
	public String getDosage () { return dosage; }
	public void setDosage (String dosage) { this.dosage = dosage; }
	
	private FormType form;
	public FormType getForm () { return form; }
	public void setForm (FormType form) { this.form = form; }
	
	private String medicationCode;
	public String getMedicationCode () { return medicationCode; }
	public void setMedicationCode (String medicationCode) { this.medicationCode = medicationCode; }
	
	
	
	
	// endregion
	
	
	
	// region - Constructor and JSON <-> DTOA <-> DTO
	
	public MedicationDTOA ()
	{
		// Empty constructor
	}
	
	@Override
	public void setFromJSON (JSONObject json)
	{
		try
		{
			

			if (!JSONObject.NULL.equals(json.opt("ProductReference")))
			{
			 
				this.productReference = (Integer) json.opt("ProductReference");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Name")))
			{
			 
				this.name = (String) json.opt("Name");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Manufacturer")))
			{
			 
				this.manufacturer = (String) json.opt("Manufacturer");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Description")))
			{
			 
				this.description = (String) json.opt("Description");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Dosage")))
			{
			 
				this.dosage = (String) json.opt("Dosage");
			 
			}

			if (!JSONObject.NULL.equals(json.opt("Form")))
			{
				int enumRawValue = (int) json.opt("Form");
				this.form = FormType.fromRawValue(enumRawValue);
			 
			}

			if (!JSONObject.NULL.equals(json.opt("MedicationCode")))
			{
			 
				this.medicationCode = (String) json.opt("MedicationCode");
			 
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
			
		
		  if (this.productReference != null)
			json.put("ProductReference", this.productReference.intValue());
		
		
		  if (this.name != null)
			json.put("Name", this.name);
		
		
		  if (this.manufacturer != null)
			json.put("Manufacturer", this.manufacturer);
		
		
		  if (this.description != null)
			json.put("Description", this.description);
		
		
		  if (this.dosage != null)
			json.put("Dosage", this.dosage);
		
		
		  if (this.form != null)
			json.put("Form", this.form.getRawValue());
		
		
		  if (this.medicationCode != null)
			json.put("MedicationCode", this.medicationCode);
		
			
			
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
		MedicationDTO dto = new MedicationDTO ();
		
		// Attributes
		
		
	dto.setProductReference (this.getProductReference());

	dto.setName (this.getName());

	dto.setManufacturer (this.getManufacturer());

	dto.setDescription (this.getDescription());

	dto.setDosage (this.getDosage());

	dto.setForm (this.getForm());

	dto.setMedicationCode (this.getMedicationCode());

		
		
		// Roles
		
		
		return dto;
	}

	// endregion
}

	