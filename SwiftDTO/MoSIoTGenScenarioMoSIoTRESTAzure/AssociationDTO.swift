	
		//
		// AssociationDTO.swift
		// 
		// Code autogenerated. Do not modify this file.
		//
		
		import Foundation
		import SwiftyJSON
	
		 class AssociationDTO 	    {
		 
				var id: Int?;
				    	 
		 
				var name: String?;
				    	 
		 
				var rolOrigin_oid: Int?;
				    	 
		 
				var rolTarget_oid: Int?;
				    	 
		 
				var type: AssociationType?;
				    	 
		 
				var cardinalityOrigin: CardinalityType?;
				    	 
		 
				var cardinalityTarget: CardinalityType?;
				    	 
		 
				var entityOrigin_oid: Int?;
				    	 
		 
				var entityTarget_oid: Int?;
				    	 
		 
				var ioTScenario_oid: Int?;
				    	 
		 
				var description: String?;
				    	 
	   	   
			// MARK: - Constructor
			
			
		
			init ()
			{
				// Empty constructor
			}
			 func toDictionary() -> [String : AnyObject]
		
		   
			{
				var dictionary: [String : AnyObject] = [:];
				
			


				
					dictionary["id"] = self.id;
				

				
					dictionary["name"] = self.name;
				

					dictionary["rolOrigin_oid"] = self.rolOrigin_oid;
			

					dictionary["rolTarget_oid"] = self.rolTarget_oid;
			

				
					dictionary["type"] = self.type?.rawValue;
				

				
					dictionary["cardinalityOrigin"] = self.cardinalityOrigin?.rawValue;
				

				
					dictionary["cardinalityTarget"] = self.cardinalityTarget?.rawValue;
				

					dictionary["entityOrigin_oid"] = self.entityOrigin_oid;
			

					dictionary["entityTarget_oid"] = self.entityTarget_oid;
			

					dictionary["ioTScenario_oid"] = self.ioTScenario_oid;
			

				
					dictionary["description"] = self.description;
				
						
				return dictionary;
			}
		}
		
	