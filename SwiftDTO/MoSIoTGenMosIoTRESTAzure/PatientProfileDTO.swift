	
		//
		// PatientProfileDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class PatientProfileDTO 	    {
		 
				var accessMode: [AccessModeDTO]?;
				    	 
		 
				var preferredLanguage: LanguageCode?;
				    	 
		 
				var region: String?;
				    	 
		 
				var hazardAvoidance: HazardValue?;
				    	 
		 
				var disability: [DisabilityDTO]?;
				    	 
		 
				var id: Int?;
				    	 
		 
				var carePlanTemplate_oid: [Int]?;
				    	 
		 
				var diseases: [ConditionDTO]?;
				    	 
		 
				var name: String?;
				    	 
		 
				var description: String?;
				    	 
	   	   
			// MARK: - Constructor
			
			
		
			init ()
			{
				// Empty constructor
			}
			 func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
			


					dictionary["accessMode"] = NSNull();
					if (self.accessMode != nil)
					{
						var arrayOfDictionary: [[String : AnyObject]] = [];
						for item in self.accessMode!
						{
							arrayOfDictionary.append(item.toDictionary());
						}
						
						dictionary["accessMode"] = arrayOfDictionary;
					}
			

				
					dictionary["preferredLanguage"] = self.preferredLanguage?.rawValue;
				

				
					dictionary["region"] = self.region;
				

				
					dictionary["hazardAvoidance"] = self.hazardAvoidance?.rawValue;
				

					dictionary["disability"] = NSNull();
					if (self.disability != nil)
					{
						var arrayOfDictionary: [[String : AnyObject]] = [];
						for item in self.disability!
						{
							arrayOfDictionary.append(item.toDictionary());
						}
						
						dictionary["disability"] = arrayOfDictionary;
					}
			

				
					dictionary["id"] = self.id;
				

					dictionary["carePlanTemplate_oid"] = self.carePlanTemplate_oid;
			

					dictionary["diseases"] = NSNull();
					if (self.diseases != nil)
					{
						var arrayOfDictionary: [[String : AnyObject]] = [];
						for item in self.diseases!
						{
							arrayOfDictionary.append(item.toDictionary());
						}
						
						dictionary["diseases"] = arrayOfDictionary;
					}
			

				
					dictionary["name"] = self.name;
				

				
					dictionary["description"] = self.description;
				
						
				return dictionary;
			}
		}
		
	