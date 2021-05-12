//
// NutritionOrderDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class NutritionOrderDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var description: String?;
	var dietCode: String?;
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
		self.dietCode = json["DietCode"].object as? String;
		self.name = json["Name"].object as? String;
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Description"] = self.description;
	
	

	
		dictionary["DietCode"] = self.dietCode;
	
	

	
		dictionary["Name"] = self.name;
	
	
		
		
		
		return dictionary;
	}
}

	