//
// TargetDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class TargetDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var desiredValue: String?;
	var description: String?;
	var dueDate: NSDate?;
	
	
	
	
	
	// MARK: - Constructor
	
	init ()
	{
		// Empty constructor
	}
	
	
	
	// MARK: - JSON <-> DTOA
	
	required init (fromJSONObject json: JSON)
	{
		self.id = json["Id"].object as? Int
		
	
		self.desiredValue = json["DesiredValue"].object as? String;
		self.description = json["Description"].object as? String;
	
		self.dueDate = NSDate.initFromString(json["DueDate"].object as? String);
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["DesiredValue"] = self.desiredValue;
	
	

	
		dictionary["Description"] = self.description;
	
	

	
		dictionary["DueDate"] = self.dueDate?.toString();
	
	
		
		
		
		return dictionary;
	}
}

	