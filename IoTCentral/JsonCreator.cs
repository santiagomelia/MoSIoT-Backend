using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IoTCentral
{
    public class JsonCreator
    {
   
        JsonTextReader reader;

        public JsonCreator(JsonTextReader jtextReader)
        {
            
            this.reader = jtextReader;
        }
        public JObject ReadCompleteJson ()
        {
            JObject jsonObject = new JObject();
            while (reader.Read())
            {
              
                if (reader.TokenType.ToString().Equals("StartObject")){ /// "{"
                   
                    ReadObject(jsonObject);
                }
                Console.WriteLine("Terminó todo el JSON: Token Type: {0}", reader.TokenType);
            }
            return jsonObject;
        }

        public void ReadObject(JObject jobject)
        {
            try
            {
                bool salir = false;
                while (!salir && reader.Read())
                {
                    Console.WriteLine("Comienza lectura del Token {0} en objeto con el valor {1}", reader.TokenType.ToString(), reader.Value);

                    if (reader.TokenType.ToString().Equals("PropertyName")) // Son propiedades con valor
                    {
                        string name = reader.Value.ToString();
                        reader.Read(); // Se leen 2
                        Object value = null;
                        if (reader.TokenType.ToString().Equals("StartArray")) /// "["
                        {
                            JArray array = new JArray();
                            ReadArray(array);
                            value = array;
                        }
                        else // name : value
                        {
                            value = reader.Value;
                        }
                        JProperty property = new JProperty(name, value);
                        jobject.Add(property);
    
                    }
                    else if (reader.TokenType.ToString().Equals("StartArray")) /// "["
                    {
                        
                        JArray array = new JArray();
                        ReadArray(array);
                        jobject.Add(array);
              
                    }
                    else if (reader.TokenType.ToString().Equals("StartObject")) // "{"
                    {
                        JObject o = new JObject();
                        ReadObject(o);
                        jobject.Add(o);
                    }
                    else // "}"
                    {
                        salir = true;
                    
                    }
                    Console.WriteLine("Finaliza lectura del Token {0} en objeto con el valor {1}", reader.TokenType.ToString(), reader.Value);
                }
            } catch (Exception e)
            {
                Console.WriteLine("Ha fallado leyendo el Token {0} en objeto {1}", reader.TokenType.ToString(), jobject.ToString());
                System.Console.WriteLine(e.Message);
            }
        }

        public void ReadArray(JArray array)
        {
            bool salir = false;
            while (!salir && reader.Read())
            {
                Console.WriteLine("Comienza lectura del Token {0} en el array {1}", reader.TokenType.ToString(), array.ToString());
                if (reader.TokenType.ToString().Equals("StartObject")) //"{"
                {
                    JObject o = new JObject();
                    ReadObject(o);
                    array.Add(o);
                }
                else if (reader.TokenType.ToString().Equals("EndArray"))
                { // "]"
                    salir = true;
                    Console.WriteLine("Salió del Array: Token Type: {0}", reader.TokenType);
                }
                else // String, Integer....valores
                {
                    JValue value = new JValue(reader.Value);
                    array.Add(value);
                }
                Console.WriteLine("Finaliza lectura del Token {0} en el array {1}", reader.TokenType.ToString(), array.ToString());
            }
        }

    }
}
