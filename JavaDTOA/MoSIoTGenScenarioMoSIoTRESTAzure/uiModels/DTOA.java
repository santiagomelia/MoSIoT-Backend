
package MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTOA;

import MoSIoTGenScenarioMoSIoTRESTAzure.uiModels.DTO.IDTO;

import org.json.JSONObject;

import java.util.ArrayList;

/**
 * Code autogenerated. Do not modify this file.
 */
	
public abstract class DTOA
{
    protected Integer id;
    public Integer getId () { return id; }
    public void setId (Integer id) { this.id = id; }

    /**
     * Hace una asignacion de los parametros dados por el JSON
     * @param jsonObject el JSON recibido
     */
    public abstract void setFromJSON(JSONObject jsonObject);

    /**
     * Convierte la estructura DTOA a su correspondiente DTO
     * @return el DTO generado
     */
    public abstract IDTO toDTO();


    public abstract JSONObject toJSON();

    boolean containsId(ArrayList<DTOA> list, Integer id) {
        for (DTOA object : list) {
            if (object.getId().intValue() == id.intValue()) {
                return true;
            }
        }
        return false;
    }
}



