	
		//
		// TelemetryDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class TelemetryDTO 	    {
		 
				var deviceTemplate_oid: Int?;
				    	 
		 
				var frecuency: Double?;
				    	 
		 
				var typeTelemetry_oid: Int?;
				    	 
		 
				var schema: DataType?;
				    	 
		 
				var unit: TypeUnit?;
				    	 
		 
				var id: Int?;
				    	 
		 
				var name: String?;
				    	 
		 
				var type: TelemetryType?;
				    	 
		 
				var properties_oid: [Int]?;
				    	 
		 
				var vitalSign_oid: Int?;
				    	 
	   	   
			// MARK: - Constructor
			
			
		
			init ()
			{
				// Empty constructor
			}
			 func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
			


					dictionary["deviceTemplate_oid"] = self.deviceTemplate_oid;
			

				
					dictionary["frecuency"] = self.frecuency;
				

					dictionary["typeTelemetry_oid"] = self.typeTelemetry_oid;
			

				
					dictionary["schema"] = self.schema?.rawValue;
				

				
					dictionary["unit"] = self.unit?.rawValue;
				

				
					dictionary["id"] = self.id;
				

				
					dictionary["name"] = self.name;
				

				
					dictionary["type"] = self.type?.rawValue;
				

					dictionary["properties_oid"] = self.properties_oid;
			

					dictionary["vitalSign_oid"] = self.vitalSign_oid;
			
						
				return dictionary;
			}
		}
		
	