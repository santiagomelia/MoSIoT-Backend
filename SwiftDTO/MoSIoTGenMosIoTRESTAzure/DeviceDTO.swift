	
		//
		// DeviceDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class DeviceDTO :    		EntityDTO
	    {
		 
				var deviceSwitch: Bool?;
				    	 
		 
				var tag: String?;
				    	 
		 
				var isSimulated: Bool?;
				    	 
		 
				var serialNumber: String?;
				    	 
		 
				var firmVersion: String?;
				    	 
		 
				var trademark: String?;
				    	 
		 
				var deviceTemplate_oid: Int?;
				    	 
	   	   
			// MARK: - Constructor
			
			
			override init ()
			{
				super.init();
			}
			override func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
				dictionary = super.toDictionary();
			


				
					dictionary["deviceSwitch"] = self.deviceSwitch;
				

				
					dictionary["tag"] = self.tag;
				

				
					dictionary["isSimulated"] = self.isSimulated;
				

				
					dictionary["serialNumber"] = self.serialNumber;
				

				
					dictionary["firmVersion"] = self.firmVersion;
				

				
					dictionary["trademark"] = self.trademark;
				

					dictionary["deviceTemplate_oid"] = self.deviceTemplate_oid;
			
						
				return dictionary;
			}
		}
		
	