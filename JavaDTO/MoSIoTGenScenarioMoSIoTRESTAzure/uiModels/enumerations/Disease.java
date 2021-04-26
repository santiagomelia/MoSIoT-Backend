
package MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO.enumerations;

/**
 * Code autogenerated. Do not modify this file.
 */
public enum Disease
{
	// region - Literals

	Alzheimer (1)
	,	Parkinson (2)
	,	Cancer (3)
	,	Heart_Disease (4)
	,	Obesity (5)
	,	Diabetes (6)
	,	Epilepsy (7)
	,	Apnea_Sleep (8)
	,	Narcolepsy (9)
	,	Eating_disorders (10)
	,	Osteoporosis (11)
	,	Asthma (12)
	,	Fibrosis (13)
	,	Oral_Health (14)
;

	// endregion


	// region - Members and constructor

	private final int rawValue;

	public int getRawValue ()
	{
		return this.rawValue;
	}

	Disease (int rawValue)
	{
		this.rawValue = rawValue;
	}

	// endregion


	// region - Public methods

	public static Disease fromRawValue (int rawValue)
	{
		Disease[] enumValues = Disease.values();

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
