//
// MedicationDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class MedicationDTOA : DTOA
{
	// MARK: - Properties

	
	var name: String?;
	var description: String?;
	var productReference: Int?;
	var manufacturer: String?;
	var dosage: String?;
	var form: FormType?;
	var medicationCode: String?;
	
	
	
	
	
	// MARK: - Constructor
	
	init ()
	{
		// Empty constructor
	}
	
	
	
	// MARK: - JSON <-> DTOA
	
	required init (fromJSONObject json: JSON)
	{
		
	
		self.name = json["Name"].object as? String;
		self.description = json["Description"].object as? String;
		self.productReference = json["ProductReference"].object as? Int;
		self.manufacturer = json["Manufacturer"].object as? String;
		self.dosage = json["Dosage"].object as? String;
		if let enumValue = json["Form"].object as? Int
		{
			self.form = FormType(rawValue: enumValue);
		}
		self.medicationCode = json["MedicationCode"].object as? String;
		
		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Description"] = self.description;
	
	

	
		dictionary["ProductReference"] = self.productReference;
	
	

	
		dictionary["Manufacturer"] = self.manufacturer;
	
	

	
		dictionary["Dosage"] = self.dosage;
	
	

	
		dictionary["Form"] = self.form?.rawValue;
	
	

	
		dictionary["MedicationCode"] = self.medicationCode;
	
	
		
		
		
		return dictionary;
	}
}

	