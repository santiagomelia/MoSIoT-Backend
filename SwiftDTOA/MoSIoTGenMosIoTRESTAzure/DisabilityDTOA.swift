//
// DisabilityDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class DisabilityDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var type: DisabilityType?;
	var severity: Severity?;
	var description: String?;
	
	
	
	
	
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
		if let enumValue = json["Type"].object as? Int
		{
			self.type = DisabilityType(rawValue: enumValue);
		}
		if let enumValue = json["Severity"].object as? Int
		{
			self.severity = Severity(rawValue: enumValue);
		}
		self.description = json["Description"].object as? String;
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Type"] = self.type?.rawValue;
	
	

	
		dictionary["Severity"] = self.severity?.rawValue;
	
	

	
		dictionary["Description"] = self.description;
	
	
		
		
		
		return dictionary;
	}
}

	