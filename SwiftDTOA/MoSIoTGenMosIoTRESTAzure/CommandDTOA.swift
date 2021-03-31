//
// CommandDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class CommandDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var isSynchronous: Bool?;
	var type: OperationType?;
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
		self.isSynchronous = json["IsSynchronous"].object as? Bool;
		if let enumValue = json["Type"].object as? Int
		{
			self.type = OperationType(rawValue: enumValue);
		}
		self.description = json["Description"].object as? String;
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["IsSynchronous"] = self.isSynchronous;
	
	

	
		dictionary["Type"] = self.type?.rawValue;
	
	

	
		dictionary["Description"] = self.description;
	
	
		
		
		
		return dictionary;
	}
}

	