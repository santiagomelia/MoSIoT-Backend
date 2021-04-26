//
// Condition_CarePlanDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class Condition_CarePlanDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var description: String?;
	var clinicalStatus: ClinicalStatus?;
	var disease: Disease?;
	var name: String?;
	
	
	
	
	
	// MARK: - Constructor
	
	init ()
	{
		// Empty constructor
	}
	
	
	
	// MARK: - JSON <-> DTOA
	
	required init (fromJSONObject json: JSON)
	{
		self.id = json["Id"].object as? Int
		
	
		self.description = json["Description"].object as? String;
		if let enumValue = json["ClinicalStatus"].object as? Int
		{
			self.clinicalStatus = ClinicalStatus(rawValue: enumValue);
		}
		if let enumValue = json["Disease"].object as? Int
		{
			self.disease = Disease(rawValue: enumValue);
		}
		self.name = json["Name"].object as? String;
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Description"] = self.description;
	
	

	
		dictionary["ClinicalStatus"] = self.clinicalStatus?.rawValue;
	
	

	
		dictionary["Disease"] = self.disease?.rawValue;
	
	

	
		dictionary["Name"] = self.name;
	
	
		
		
		
		return dictionary;
	}
}

	