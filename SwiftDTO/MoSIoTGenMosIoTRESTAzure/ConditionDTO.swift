	
		//
		// ConditionDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class ConditionDTO 	    {
		 
				var patientProfile_oid: Int?;
				    	 
		 
				var id: Int?;
				    	 
		 
				var dateInitial: NSDate?;
				    	 
		 
				var dateEnd: NSDate?;
				    	 
		 
				var description: String?;
				    	 
		 
				var disabilities_oid: [Int]?;
				    	 
		 
				var clinicalStatus: ClinicalStatus?;
				    	 
		 
				var disease: Disease?;
				    	 
		 
				var carePlan_oid: [Int]?;
				    	 
		 
				var goal_oid: [Int]?;
				    	 
		 
				var name: String?;
				    	 
	   	   
			// MARK: - Constructor
			
			
		
			init ()
			{
				// Empty constructor
			}
			 func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
			


					dictionary["patientProfile_oid"] = self.patientProfile_oid;
			

				
					dictionary["id"] = self.id;
				

				
					dictionary["dateInitial"] = self.dateInitial?.toString();
				

				
					dictionary["dateEnd"] = self.dateEnd?.toString();
				

				
					dictionary["description"] = self.description;
				

					dictionary["disabilities_oid"] = self.disabilities_oid;
			

				
					dictionary["clinicalStatus"] = self.clinicalStatus?.rawValue;
				

				
					dictionary["disease"] = self.disease?.rawValue;
				

					dictionary["carePlan_oid"] = self.carePlan_oid;
			

					dictionary["goal_oid"] = self.goal_oid;
			

				
					dictionary["name"] = self.name;
				
						
				return dictionary;
			}
		}
		
	