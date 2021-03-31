	
		//
		// MedicationDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class MedicationDTO 	    {
		 
				var careActivity_oid: Int?;
				    	 
		 
				var productReference: Int?;
				    	 
		 
				var name: String?;
				    	 
		 
				var manufacturer: String?;
				    	 
		 
				var description: String?;
				    	 
		 
				var dosage: String?;
				    	 
		 
				var form: FormType?;
				    	 
		 
				var medicationCode: String?;
				    	 
	   	   
			// MARK: - Constructor
			
			
		
			init ()
			{
				// Empty constructor
			}
			 func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
			


					dictionary["careActivity_oid"] = self.careActivity_oid;
			

				
					dictionary["productReference"] = self.productReference;
				

				
					dictionary["name"] = self.name;
				

				
					dictionary["manufacturer"] = self.manufacturer;
				

				
					dictionary["description"] = self.description;
				

				
					dictionary["dosage"] = self.dosage;
				

				
					dictionary["form"] = self.form?.rawValue;
				

				
					dictionary["medicationCode"] = self.medicationCode;
				
						
				return dictionary;
			}
		}
		
	