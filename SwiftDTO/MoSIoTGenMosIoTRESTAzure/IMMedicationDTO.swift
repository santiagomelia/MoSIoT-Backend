	
		//
		// IMMedicationDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class IMMedicationDTO :    		EntityAttributesDTO
	    {
		 
				var medication_oid: Int?;
				    	 
	   	   
			// MARK: - Constructor
			
			
			override init ()
			{
				super.init();
			}
			override func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
				dictionary = super.toDictionary();
			


					dictionary["medication_oid"] = self.medication_oid;
			
						
				return dictionary;
			}
		}
		
	