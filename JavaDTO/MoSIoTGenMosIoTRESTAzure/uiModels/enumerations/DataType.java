
package MoSIoTGenMosIoTRESTAzure.uiModels.DTO.enumerations;

/**
 * Code autogenerated. Do not modify this file.
 */
public enum DataType
{
	// region - Literals

	Autogenerated (1)
	,	Enum_ (2)
	,	Integer (3)
	,	String_ (4)
	,	Double_ (5)
	,	Boolean (6)
	,	Text (7)
	,	Long_ (8)
	,	Time (9)
	,	Date (10)
	,	Object_ (11)
	,	OID (12)
;

	// endregion


	// region - Members and constructor

	private final int rawValue;

	public int getRawValue ()
	{
		return this.rawValue;
	}

	DataType (int rawValue)
	{
		this.rawValue = rawValue;
	}

	// endregion


	// region - Public methods

	public static DataType fromRawValue (int rawValue)
	{
		DataType[] enumValues = DataType.values();

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
