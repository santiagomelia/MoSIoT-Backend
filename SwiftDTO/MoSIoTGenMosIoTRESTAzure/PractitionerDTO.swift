	
		//
		// PractitionerDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class PractitionerDTO :    		EntityDTO
	    {
		 
				var userPractitioner_oid: Int?;
				    	 
	   	   
			// MARK: - Constructor
			
			
			override init ()
			{
				super.init();
			}
			override func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
				dictionary = super.toDictionary();
			


					dictionary["userPractitioner_oid"] = self.userPractitioner_oid;
			
						
				return dictionary;
			}
		}
		
	