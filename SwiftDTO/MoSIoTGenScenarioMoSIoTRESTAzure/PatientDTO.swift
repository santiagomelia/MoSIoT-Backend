	
		//
		// PatientDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class PatientDTO :    		EntityDTO
	    {
		 
				var patientProfile_oid: Int?;
				    	 
		 
				var userPatient_oid: Int?;
				    	 
	   	   
			// MARK: - Constructor
			
			
			override init ()
			{
				super.init();
			}
			override func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
				dictionary = super.toDictionary();
			


					dictionary["patientProfile_oid"] = self.patientProfile_oid;
			

					dictionary["userPatient_oid"] = self.userPatient_oid;
			
						
				return dictionary;
			}
		}
		
	