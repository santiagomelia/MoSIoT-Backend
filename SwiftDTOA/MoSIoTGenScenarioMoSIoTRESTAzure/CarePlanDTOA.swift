//
// CarePlanDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class CarePlanDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var description: String?;
	
	/* Rol: CarePlan o--> CarePlanTemplate */
	var carePlanTemplate: CarePlanTemplateDTOA?;

	
	
	
	
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
		
		if (json["CarePlanTemplate"] != JSON.null)
		{
			self.carePlanTemplate = CarePlanTemplateDTOA(fromJSONObject: json["CarePlanTemplate"]);
		}

		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Description"] = self.description;
	
	
		
		dictionary["CarePlanTemplate"] = self.carePlanTemplate?.toDictionary() ?? NSNull();

		
		
		return dictionary;
	}
}

	