	
		//
		// GoalDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class GoalDTO 	    {
		 
				var carePlanTemplate_oid: Int?;
				    	 
		 
				var id: Int?;
				    	 
		 
				var priority: PriorityType?;
				    	 
		 
				var targets: [TargetDTO]?;
				    	 
		 
				var status: CareStatus?;
				    	 
		 
				var condition_oid: Int?;
				    	 
		 
				var description: String?;
				    	 
		 
				var category: CategoryGoal?;
				    	 
		 
				var outcomeCode: String?;
				    	 
		 
				var name: String?;
				    	 
	   	   
			// MARK: - Constructor
			
			
		
			init ()
			{
				// Empty constructor
			}
			 func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
			


					dictionary["carePlanTemplate_oid"] = self.carePlanTemplate_oid;
			

				
					dictionary["id"] = self.id;
				

				
					dictionary["priority"] = self.priority?.rawValue;
				

					dictionary["targets"] = NSNull();
					if (self.targets != nil)
					{
						var arrayOfDictionary: [[String : AnyObject]] = [];
						for item in self.targets!
						{
							arrayOfDictionary.append(item.toDictionary());
						}
						
						dictionary["targets"] = arrayOfDictionary;
					}
			

				
					dictionary["status"] = self.status?.rawValue;
				

					dictionary["condition_oid"] = self.condition_oid;
			

				
					dictionary["description"] = self.description;
				

				
					dictionary["category"] = self.category?.rawValue;
				

				
					dictionary["outcomeCode"] = self.outcomeCode;
				

				
					dictionary["name"] = self.name;
				
						
				return dictionary;
			}
		}
		
	