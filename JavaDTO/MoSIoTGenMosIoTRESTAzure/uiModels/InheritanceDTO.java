	
		package MoSIoTGenMosIoTRESTAzure.uiModels.DTO;
		
		import java.util.ArrayList;
		
		import org.json.JSONArray;
		import org.json.JSONException;
		import org.json.JSONObject;
		import  MoSIoTGenMosIoTRESTAzure.uiModels.DTO.utils.*;
		import  MoSIoTGenMosIoTRESTAzure.uiModels.DTO.enumerations.*;
		
		
		/**
		 * Code autogenerated. Do not modify this file.
		 */
		
		
		public class InheritanceDTO 	    implements IDTO
	    {
				private ArrayList<Integer> father_oid;
				public ArrayList<Integer>  getFather_oid () { return father_oid; } 
				public void setFather_oid (ArrayList<Integer> value) { father_oid = value;  } 
				    	 
				private Integer son_oid;
				public Integer  getSon_oid () { return son_oid; } 
				public void setSon_oid (Integer value) { son_oid = value;  } 
				    	 
				private Integer id;
				public Integer getId () { return id; } 
				public void setId  (Integer value) { id = value;  } 
				    	 
	   
			    public JSONObject toJSON ()
				{
					JSONObject json = new JSONObject();
					
					try
					{

						if (this.father_oid != null)
						{
							JSONArray jsonArray = new JSONArray();
							for (int i = 0; i < this.father_oid.size(); ++i)
							{
								jsonArray.put(this.father_oid.get(i));
							}
							json.put("Father_oid", jsonArray);
						}
		

						if (this.son_oid != null)
						{
							json.put("Son_oid", this.son_oid.intValue());
						}
				
						  json.put("Id", this.id.intValue());
				
						
					}
					catch (JSONException e)
					{
						e.printStackTrace();
					}
				
				return json;
			}
		
			// endregion
		}
	   
	   
	   
		
	