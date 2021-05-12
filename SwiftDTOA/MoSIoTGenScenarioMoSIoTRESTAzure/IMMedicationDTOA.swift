//
// IMMedicationDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class IMMedicationDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var description: String?;
	
	/* Rol: IMMedication o--> Medication */
	var valueMedication: MedicationDTOA?;

	
	
	
	
	// MARK: - Constructor
	
	init ()
	{
		// Empty constructor
	}
	
	
	
	// MARK: - JSON <-> DTOA
	
	required init (fromJSONObject json: JSON)
	{
		self.id = json["Id"].object as? Int
		
	
		self.name = json["Name"].object as? String;
		self.description = json["Description"].object as? String;
		
		if (json["ValueMedication"] != JSON.null)
		{
			self.valueMedication = MedicationDTOA(fromJSONObject: json["ValueMedication"]);
		}

		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Description"] = self.description;
	
	
		
		dictionary["ValueMedication"] = self.valueMedication?.toDictionary() ?? NSNull();

		
		
		return dictionary;
	}
}

	