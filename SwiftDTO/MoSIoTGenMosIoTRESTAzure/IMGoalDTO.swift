	
		//
		// IMGoalDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class IMGoalDTO :    		EntityAttributesDTO
	    {
		 
				var goal_oid: Int?;
				    	 
	   	   
			// MARK: - Constructor
			
			
			override init ()
			{
				super.init();
			}
			override func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
				dictionary = super.toDictionary();
			


					dictionary["goal_oid"] = self.goal_oid;
			
						
				return dictionary;
			}
		}
		
	