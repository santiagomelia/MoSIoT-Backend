//
// EntityAttributesDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class EntityAttributesDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var type: DataType?;
	var isOID: Bool?;
	var associationType: AssociationType?;
	var isWritable: Bool?;
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
		self.isOID = json["IsOID"].object as? Bool;
		if let enumValue = json["AssociationType"].object as? Int
		{
			self.associationType = AssociationType(rawValue: enumValue);
		}
		self.isWritable = json["IsWritable"].object as? Bool;
		self.description = json["Description"].object as? String;
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Type"] = self.type?.rawValue;
	
	

	
		dictionary["IsOID"] = self.isOID;
	
	

	
		dictionary["AssociationType"] = self.associationType?.rawValue;
	
	

	
		dictionary["IsWritable"] = self.isWritable;
	
	

	
		dictionary["Description"] = self.description;
	
	
		
		
		
		return dictionary;
	}
}

	