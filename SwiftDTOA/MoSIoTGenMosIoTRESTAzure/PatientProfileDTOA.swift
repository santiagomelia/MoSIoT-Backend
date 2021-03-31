//
// PatientProfileDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class PatientProfileDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var preferredLanguage: LanguageCode?;
	var region: String?;
	var hazardAvoidance: HazardValue?;
	var name: String?;
	var description: String?;
	
	/* Rol: PatientProfile o--> AccessMode */
	var accessMode: [AccessModeDTOA]?;

	/* Rol: PatientProfile o--> Condition */
	var condition: [ConditionDTOA]?;

	/* Rol: PatientProfile o--> Disability */
	var disabilities: [DisabilityDTOA]?;

	
	
	
	
	// MARK: - Constructor
	
	init ()
	{
		// Empty constructor
	}
	
	
	
	// MARK: - JSON <-> DTOA
	
	required init (fromJSONObject json: JSON)
	{
		self.id = json["Id"].object as? Int
		
	
		if let enumValue = json["PreferredLanguage"].object as? Int
		{
			self.preferredLanguage = LanguageCode(rawValue: enumValue);
		}
		self.region = json["Region"].object as? String;
		if let enumValue = json["HazardAvoidance"].object as? Int
		{
			self.hazardAvoidance = HazardValue(rawValue: enumValue);
		}
		self.name = json["Name"].object as? String;
		self.description = json["Description"].object as? String;
		
		if (json["AccessMode"] != JSON.null)
		{
			self.accessMode = AccessModeDTOA(fromJSONObject: json["AccessMode"]);
		}

		if (json["Condition"] != JSON.null)
		{
			self.condition = ConditionDTOA(fromJSONObject: json["Condition"]);
		}

		if (json["Disabilities"] != JSON.null)
		{
			self.disabilities = DisabilityDTOA(fromJSONObject: json["Disabilities"]);
		}

		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["PreferredLanguage"] = self.preferredLanguage?.rawValue;
	
	

	
		dictionary["Region"] = self.region;
	
	

	
		dictionary["HazardAvoidance"] = self.hazardAvoidance?.rawValue;
	
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Description"] = self.description;
	
	
		
		dictionary["AccessMode"] = self.accessMode?.toDictionary() ?? NSNull();

		dictionary["Condition"] = self.condition?.toDictionary() ?? NSNull();

		dictionary["Disabilities"] = self.disabilities?.toDictionary() ?? NSNull();

		
		
		return dictionary;
	}
}

	