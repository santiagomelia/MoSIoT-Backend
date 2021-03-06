
package MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO.enumerations;

/**
 * Code autogenerated. Do not modify this file.
 */
public enum PriorityType
{
	// region - Literals

	High (1)
	,	Medium (2)
	,	Low (3)
;

	// endregion


	// region - Members and constructor

	private final int rawValue;

	public int getRawValue ()
	{
		return this.rawValue;
	}

	PriorityType (int rawValue)
	{
		this.rawValue = rawValue;
	}

	// endregion


	// region - Public methods

	public static PriorityType fromRawValue (int rawValue)
	{
		PriorityType[] enumValues = PriorityType.values();

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
