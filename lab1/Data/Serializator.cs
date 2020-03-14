using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace lab1
{         

    interface ISerialize
    {
        void Serialize(Object obj, string path);
        Object Deserialize( string path);
    }

    internal class SerializeJson : ISerialize
    {
        DataContractJsonSerializer serializeJson;
        public SerializeJson(Type type)
        {
            serializeJson = new DataContractJsonSerializer(type);
            
        }

        public void Serialize(Object obj, string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializeJson.WriteObject(stream, obj);
            }
        }

        public Object Deserialize(string path)
        {

            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                return serializeJson.ReadObject(stream);
            }
        }
    }


    public class SerializeXml : ISerialize
    {
        DataContractSerializer serializeXml;
        public SerializeXml(Type type)
        {
            serializeXml = new DataContractSerializer(type);
        }
        public void Serialize(Object obj , string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializeXml.WriteObject(stream, obj);
            }
        }

        public Object Deserialize( string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                return serializeXml.ReadObject(stream);
            } 
        }      
    }
    
}
