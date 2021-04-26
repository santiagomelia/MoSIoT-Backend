
package MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO.enumerations;

/**
 * Code autogenerated. Do not modify this file.
 */
public enum ServiceType
{
	// region - Literals

	Notify (1)
	,	Actuation (2)
	,	Register (3)
;

	// endregion


	// region - Members and constructor

	private final int rawValue;

	public int getRawValue ()
	{
		return this.rawValue;
	}

	ServiceType (int rawValue)
	{
		this.rawValue = rawValue;
	}

	// endregion


	// region - Public methods

	public static ServiceType fromRawValue (int rawValue)
	{
		ServiceType[] enumValues = ServiceType.values();

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
