	
		//
		// PatientAccessDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class PatientAccessDTO :    		EntityDTO
	    {
		 
				var accessMode_oid: Int?;
				    	 
	   	   
			// MARK: - Constructor
			
			
			override init ()
			{
				super.init();
			}
			override func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
				dictionary = super.toDictionary();
			


					dictionary["accessMode_oid"] = self.accessMode_oid;
			
						
				return dictionary;
			}
		}
		
	