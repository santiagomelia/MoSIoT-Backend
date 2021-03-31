
package MoSIoTGenMosIoTRESTAzure.uiModels.DTO.enumerations;

/**
 * Code autogenerated. Do not modify this file.
 */
public enum CategoryGoal
{
	// region - Literals

	Dietary (1)
	,	Safety (2)
	,	Behavioral (3)
	,	Physiotherapy (4)
;

	// endregion


	// region - Members and constructor

	private final int rawValue;

	public int getRawValue ()
	{
		return this.rawValue;
	}

	CategoryGoal (int rawValue)
	{
		this.rawValue = rawValue;
	}

	// endregion


	// region - Public methods

	public static CategoryGoal fromRawValue (int rawValue)
	{
		CategoryGoal[] enumValues = CategoryGoal.values();

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
