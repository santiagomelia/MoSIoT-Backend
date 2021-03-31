	
		//
		// NotificationDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class NotificationDTO 	    {
		 
				var severity: SeverityEvent?;
				    	 
		 
				var message: String?;
				    	 
		 
				var sendDate: NSDate?;
				    	 
		 
				var receivers_oid: [String]?;
				    	 
		 
				var carePlan_oid: Int?;
				    	 
		 
				var id: Int?;
				    	 
	   	   
			// MARK: - Constructor
			
			
		
			init ()
			{
				// Empty constructor
			}
			 func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
			


				
					dictionary["severity"] = self.severity?.rawValue;
				

				
					dictionary["message"] = self.message;
				

				
					dictionary["sendDate"] = self.sendDate?.toString();
				

					dictionary["receivers_oid"] = self.receivers_oid;
			

					dictionary["carePlan_oid"] = self.carePlan_oid;
			

				
					dictionary["id"] = self.id;
				
						
				return dictionary;
			}
		}
		
	