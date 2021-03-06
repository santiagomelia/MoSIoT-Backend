//
// UserDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class UserDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var surnames: String?;
	var isActive: Bool?;
	
	
	
	
	
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
		self.surnames = json["Surnames"].object as? String;
		self.isActive = json["IsActive"].object as? Bool;
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Surnames"] = self.surnames;
	
	

	
		dictionary["IsActive"] = self.isActive;
	
	
		
		
		
		return dictionary;
	}
}

	