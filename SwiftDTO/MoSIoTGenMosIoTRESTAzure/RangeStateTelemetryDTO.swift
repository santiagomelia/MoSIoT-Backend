	
		//
		// RangeStateTelemetryDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class RangeStateTelemetryDTO 	    {
		 
				var stateTelemetry_oid: [Int]?;
				    	 
		 
				var id: Int?;
				    	 
		 
				var name: String?;
				    	 
		 
				var value: String?;
				    	 
	   	   
			// MARK: - Constructor
			
			
		
			init ()
			{
				// Empty constructor
			}
			 func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
			


					dictionary["stateTelemetry_oid"] = self.stateTelemetry_oid;
			

				
					dictionary["id"] = self.id;
				

				
					dictionary["name"] = self.name;
				

				
					dictionary["value"] = self.value;
				
						
				return dictionary;
			}
		}
		
	