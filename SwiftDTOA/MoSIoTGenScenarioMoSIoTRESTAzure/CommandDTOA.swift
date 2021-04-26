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
	var description: String?;
	var isSynchronous: Bool?;
	var type: OperationType?;
	
	
	
	
	
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
		self.isSynchronous = json["IsSynchronous"].object as? Bool;
		if let enumValue = json["Type"].object as? Int
		{
			self.type = OperationType(rawValue: enumValue);
		}
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Description"] = self.description;
	
	

	
		dictionary["IsSynchronous"] = self.isSynchronous;
	
	

	
		dictionary["Type"] = self.type?.rawValue;
	
	
		
		
		
		return dictionary;
	}
}

	