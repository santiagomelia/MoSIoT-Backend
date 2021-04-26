//
// GoalDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class GoalDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var priority: PriorityType?;
	var status: CareStatus?;
	var description: String?;
	var category: CategoryGoal?;
	var outcomeCode: String?;
	var name: String?;
	
	/* Rol: Goal o--> Target */
	var targets: [TargetDTOA]?;

	
	
	
	
	// MARK: - Constructor
	
	init ()
	{
		// Empty constructor
	}
	
	
	
	// MARK: - JSON <-> DTOA
	
	required init (fromJSONObject json: JSON)
	{
		self.id = json["Id"].object as? Int
		
	
		if let enumValue = json["Priority"].object as? Int
		{
			self.priority = PriorityType(rawValue: enumValue);
		}
		if let enumValue = json["Status"].object as? Int
		{
			self.status = CareStatus(rawValue: enumValue);
		}
		self.description = json["Description"].object as? String;
		if let enumValue = json["Category"].object as? Int
		{
			self.category = CategoryGoal(rawValue: enumValue);
		}
		self.outcomeCode = json["OutcomeCode"].object as? String;
		self.name = json["Name"].object as? String;
		
		if (json["Targets"] != JSON.null)
		{
			self.targets = TargetDTOA(fromJSONObject: json["Targets"]);
		}

		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Priority"] = self.priority?.rawValue;
	
	

	
		dictionary["Status"] = self.status?.rawValue;
	
	

	
		dictionary["Description"] = self.description;
	
	

	
		dictionary["Category"] = self.category?.rawValue;
	
	

	
		dictionary["OutcomeCode"] = self.outcomeCode;
	
	

	
		dictionary["Name"] = self.name;
	
	
		
		dictionary["Targets"] = self.targets?.toDictionary() ?? NSNull();

		
		
		return dictionary;
	}
}

	