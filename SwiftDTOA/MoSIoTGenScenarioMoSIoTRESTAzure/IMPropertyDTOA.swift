//
// IMPropertyDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class IMPropertyDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var type: DataType?;
	var value: String?;
	
	/* Rol: IMProperty o--> Property */
	var valueProperty: PropertyDTOA?;

	
	
	
	
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
		if let enumValue = json["Type"].object as? Int
		{
			self.type = DataType(rawValue: enumValue);
		}
		self.value = json["Value"].object as? String;
		
		if (json["ValueProperty"] != JSON.null)
		{
			self.valueProperty = PropertyDTOA(fromJSONObject: json["ValueProperty"]);
		}

		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Type"] = self.type?.rawValue;
	
	

	
		dictionary["Value"] = self.value;
	
	
		
		dictionary["ValueProperty"] = self.valueProperty?.toDictionary() ?? NSNull();

		
		
		return dictionary;
	}
}

	