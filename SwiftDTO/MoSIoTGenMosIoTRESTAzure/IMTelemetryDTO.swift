	
		//
		// IMTelemetryDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class IMTelemetryDTO :    		EntityDTO
	    {
		 
				var telemetry_oid: Int?;
				    	 
		 
				var iMTelemetryValues_oid: [Int]?;
				    	 
	   	   
			// MARK: - Constructor
			
			
			override init ()
			{
				super.init();
			}
			override func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
				dictionary = super.toDictionary();
			


					dictionary["telemetry_oid"] = self.telemetry_oid;
			

					dictionary["iMTelemetryValues_oid"] = self.iMTelemetryValues_oid;
			
						
				return dictionary;
			}
		}
		
	