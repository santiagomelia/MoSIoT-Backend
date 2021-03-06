//
// EntityOperationDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class EntityOperationDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var type: DataType?;
	var serviceType: ServiceType?;
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
			self.type = DataType(rawValue: enumValue);
		}
		if let enumValue = json["ServiceType"].object as? Int
		{
			self.serviceType = ServiceType(rawValue: enumValue);
		}
		self.description = json["Description"].object as? String;
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Type"] = self.type?.rawValue;
	
	

	
		dictionary["ServiceType"] = self.serviceType?.rawValue;
	
	

	
		dictionary["Description"] = self.description;
	
	
		
		
		
		return dictionary;
	}
}

	