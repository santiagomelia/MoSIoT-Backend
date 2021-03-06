//
// StateDeviceDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class StateDeviceDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var value: String?;
	
	
	
	
	
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
		self.value = json["Value"].object as? String;
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Value"] = self.value;
	
	
		
		
		
		return dictionary;
	}
}

	