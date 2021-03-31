
package MoSIoTGenMosIoTRESTAzure.uiModels.DTO.enumerations;

/**
 * Code autogenerated. Do not modify this file.
 */
public enum ClinicalStatus
{
	// region - Literals

	Active (1)
	,	Recurrence (2)
	,	Relapse (3)
	,	Inactive (4)
	,	Remission (5)
	,	Resolved (6)
;

	// endregion


	// region - Members and constructor

	private final int rawValue;

	public int getRawValue ()
	{
		return this.rawValue;
	}

	ClinicalStatus (int rawValue)
	{
		this.rawValue = rawValue;
	}

	// endregion


	// region - Public methods

	public static ClinicalStatus fromRawValue (int rawValue)
	{
		ClinicalStatus[] enumValues = ClinicalStatus.values();

		for (int i = 0; i < enumValues.length; i++)
		{
			if (enumValues[i].Compare(rawValue))
			{
				return enumValues[i];
			}
		}

		return null;
	}

	public boolean Compare (int rawValue)
	{
		return this.rawValue == rawValue;
	}

	// endregion
	
}
