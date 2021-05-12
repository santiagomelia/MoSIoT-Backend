
package MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO.enumerations;

/**
 * Code autogenerated. Do not modify this file.
 */
public enum AdaptationTypeValue
{
	// region - Literals

	AlternativeText (1)
	,	AudioDescription (2)
	,	Captions (3)
	,	E_book (4)
	,	Haptic (5)
	,	HighContrast (6)
	,	LongDescription (7)
	,	SignLanguage (8)
	,	Transcript (9)
;

	// endregion


	// region - Members and constructor

	private final int rawValue;

	public int getRawValue ()
	{
		return this.rawValue;
	}

	AdaptationTypeValue (int rawValue)
	{
		this.rawValue = rawValue;
	}

	// endregion


	// region - Public methods

	public static AdaptationTypeValue fromRawValue (int rawValue)
	{
		AdaptationTypeValue[] enumValues = AdaptationTypeValue.values();

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