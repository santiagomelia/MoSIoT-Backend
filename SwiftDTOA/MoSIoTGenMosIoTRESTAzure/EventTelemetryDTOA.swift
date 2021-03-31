//
// EventTelemetryDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class EventTelemetryDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var severity: SeverityEvent?;
	
	
	
	
	
	// MARK: - Constructor
	
	init ()
	{
		// Empty constructor
	}
	
	
	
	// MARK: - JSON <-> DTOA
	
	required init (fromJSONObject json: JSON)
	{
		self.id = json["Id"].object as? Int
		
	
		if let enumValue = json["Severity"].object as? Int
		{
			self.severity = SeverityEvent(rawValue: enumValue);
		}
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Severity"] = self.severity?.rawValue;
	
	
		
		
		
		return dictionary;
	}
}

	