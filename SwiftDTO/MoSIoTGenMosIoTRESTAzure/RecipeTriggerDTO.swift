	
		//
		// RecipeTriggerDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class RecipeTriggerDTO 	    {
		 
				var recipe_oid: Int?;
				    	 
		 
				var id: Int?;
				    	 
		 
				var operator_: OperatorType?;
				    	 
		 
				var value: String?;
				    	 
		 
				var entityAttributes_oid: [Int]?;
				    	 
		 
				var event__oid: Int?;
				    	 
		 
				var description: String?;
				    	 
	   	   
			// MARK: - Constructor
			
			
		
			init ()
			{
				// Empty constructor
			}
			 func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
			


					dictionary["recipe_oid"] = self.recipe_oid;
			

				
					dictionary["id"] = self.id;
				

				
					dictionary["operator_"] = self.operator_?.rawValue;
				

				
					dictionary["value"] = self.value;
				

					dictionary["entityAttributes_oid"] = self.entityAttributes_oid;
			

					dictionary["event__oid"] = self.event__oid;
			

				
					dictionary["description"] = self.description;
				
						
				return dictionary;
			}
		}
		
	