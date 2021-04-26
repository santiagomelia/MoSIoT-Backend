//
// IMConditionDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class IMConditionDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var description: String?;
	
	/* Rol: IMCondition o--> Condition */
	var valueCondition: ConditionDTOA?;

	
	
	
	
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
		
		if (json["ValueCondition"] != JSON.null)
		{
			self.valueCondition = ConditionDTOA(fromJSONObject: json["ValueCondition"]);
		}

		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Description"] = self.description;
	
	
		
		dictionary["ValueCondition"] = self.valueCondition?.toDictionary() ?? NSNull();

		
		
		return dictionary;
	}
}

	