	
		//
		// AdaptationRequestDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class AdaptationRequestDTO 	    {
		 
				var accessModeTarget: AccessModeValue?;
				    	 
		 
				var id: Int?;
				    	 
		 
				var accessMode_oid: Int?;
				    	 
		 
				var languageOfAdaptation: LanguageCode?;
				    	 
		 
				var description: String?;
				    	 
	   	   
			// MARK: - Constructor
			
			
		
			init ()
			{
				// Empty constructor
			}
			 func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
			


				
					dictionary["accessModeTarget"] = self.accessModeTarget?.rawValue;
				

				
					dictionary["id"] = self.id;
				

					dictionary["accessMode_oid"] = self.accessMode_oid;
			

				
					dictionary["languageOfAdaptation"] = self.languageOfAdaptation?.rawValue;
				

				
					dictionary["description"] = self.description;
				
						
				return dictionary;
			}
		}
		
	