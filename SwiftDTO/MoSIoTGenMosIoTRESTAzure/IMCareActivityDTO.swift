	
		//
		// IMCareActivityDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class IMCareActivityDTO :    		EntityDTO
	    {
		 
				var careActivity_oid: Int?;
				    	 
	   	   
			// MARK: - Constructor
			
			
			override init ()
			{
				super.init();
			}
			override func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
				dictionary = super.toDictionary();
			


					dictionary["careActivity_oid"] = self.careActivity_oid;
			
						
				return dictionary;
			}
		}
		
	