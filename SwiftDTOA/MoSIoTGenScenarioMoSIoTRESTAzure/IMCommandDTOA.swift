//
// IMCommandDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class IMCommandDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var description: String?;
	var type: DataType?;
	var serviceType: ServiceType?;
	
	/* Rol: IMCommand o--> Command */
	var valueCommand: CommandDTOA?;

	
	
	
	
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
		if let enumValue = json["Type"].object as? Int
		{
			self.type = DataType(rawValue: enumValue);
		}
		if let enumValue = json["ServiceType"].object as? Int
		{
			self.serviceType = ServiceType(rawValue: enumValue);
		}
		
		if (json["ValueCommand"] != JSON.null)
		{
			self.valueCommand = CommandDTOA(fromJSONObject: json["ValueCommand"]);
		}

		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Description"] = self.description;
	
	

	
		dictionary["Type"] = self.type?.rawValue;
	
	

	
		dictionary["ServiceType"] = self.serviceType?.rawValue;
	
	
		
		dictionary["ValueCommand"] = self.valueCommand?.toDictionary() ?? NSNull();

		
		
		return dictionary;
	}
}

	