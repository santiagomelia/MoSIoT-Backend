	
		//
		// EventTelemetryDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class EventTelemetryDTO :    		SpecificTelemetryDTO
	    {
		 
				var severity: SeverityEvent?;
				    	 
		 
				var eventCommand_oid: Int?;
				    	 
		 
				var notification_oid: Int?;
				    	 
	   	   
			// MARK: - Constructor
			
			
			override init ()
			{
				super.init();
			}
			override func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
				dictionary = super.toDictionary();
			


				
					dictionary["severity"] = self.severity?.rawValue;
				

					dictionary["eventCommand_oid"] = self.eventCommand_oid;
			

					dictionary["notification_oid"] = self.notification_oid;
			
						
				return dictionary;
			}
		}
		
	