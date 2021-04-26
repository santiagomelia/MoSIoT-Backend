//
// AccessModeDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class AccessModeDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var typeAccessMode: AccessModeValue?;
	var description: String?;
	var name: String?;
	
	/* Rol: AccessMode o--> AdaptationRequest */
	var adaptationRequest: [AdaptationRequestDTOA]?;

	/* Rol: AccessMode o--> AdaptationTypeRequired */
	var adaptationType: [AdaptationTypeRequiredDTOA]?;

	/* Rol: AccessMode o--> AdaptationDetailRequired */
	var adaptationDetail: [AdaptationDetailRequiredDTOA]?;

	
	
	
	
	// MARK: - Constructor
	
	init ()
	{
		// Empty constructor
	}
	
	
	
	// MARK: - JSON <-> DTOA
	
	required init (fromJSONObject json: JSON)
	{
		self.id = json["Id"].object as? Int
		
	
		if let enumValue = json["TypeAccessMode"].object as? Int
		{
			self.typeAccessMode = AccessModeValue(rawValue: enumValue);
		}
		self.description = json["Description"].object as? String;
		self.name = json["Name"].object as? String;
		
		if (json["AdaptationRequest"] != JSON.null)
		{
			self.adaptationRequest = AdaptationRequestDTOA(fromJSONObject: json["AdaptationRequest"]);
		}

		if (json["AdaptationType"] != JSON.null)
		{
			self.adaptationType = [];
			for subJson in json["AdaptationType"].arrayValue
			{
				self.adaptationType!.append(AdaptationTypeRequiredDTOA(fromJSONObject: subJson));
			}
		}

		if (json["AdaptationDetail"] != JSON.null)
		{
			self.adaptationDetail = AdaptationDetailRequiredDTOA(fromJSONObject: json["AdaptationDetail"]);
		}

		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["TypeAccessMode"] = self.typeAccessMode?.rawValue;
	
	

	
		dictionary["Description"] = self.description;
	
	

	
		dictionary["Name"] = self.name;
	
	
		
		dictionary["AdaptationRequest"] = self.adaptationRequest?.toDictionary() ?? NSNull();

		dictionary["AdaptationType"] = NSNull();
		if (self.adaptationType != nil)
		{
			var arrayOfDictionary: [[String : AnyObject]] = [];
			for item in self.adaptationType!
			{
				arrayOfDictionary.append(item.toDictionary());
			}
			
			dictionary["AdaptationType"] = arrayOfDictionary;
		}

		dictionary["AdaptationDetail"] = self.adaptationDetail?.toDictionary() ?? NSNull();

		
		
		return dictionary;
	}
}

	