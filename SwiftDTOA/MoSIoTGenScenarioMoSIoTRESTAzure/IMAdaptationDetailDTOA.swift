//
// IMAdaptationDetailDTOA.swift
// 
// Code autogenerated. Do not modify this file.
//

import Foundation
import SwiftyJSON
		
class IMAdaptationDetailDTOA : DTOA
{
	// MARK: - Properties

	var id: Int?;
	
	var name: String?;
	var description: String?;
	
	/* Rol: IMAdaptationDetail o--> AdaptationDetailRequired */
	var valueAdaptionDetail: AdaptationDetailRequiredDTOA?;

	
	
	
	
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
		
		if (json["ValueAdaptionDetail"] != JSON.null)
		{
			self.valueAdaptionDetail = AdaptationDetailRequiredDTOA(fromJSONObject: json["ValueAdaptionDetail"]);
		}

		
	}
	
	func toDictionary() -> [String : AnyObject]
	{
		var dictionary: [String : AnyObject] = [:];
		
		dictionary["Id"] = self.id;
		
	

	
		dictionary["Name"] = self.name;
	
	

	
		dictionary["Description"] = self.description;
	
	
		
		dictionary["ValueAdaptionDetail"] = self.valueAdaptionDetail?.toDictionary() ?? NSNull();

		
		
		return dictionary;
	}
}

	