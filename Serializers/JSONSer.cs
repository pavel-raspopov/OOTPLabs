using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace OOTP.Serializers
{
    public class JSONSer : ISer
    {
        public string FileExtension { get; } = ".json|*.json";
        public void Serialize(object[] vehicle, string filePath)
        {
            using (StreamWriter fileStream = new StreamWriter(filePath, false))
            {
                string jsonVehicle = JsonConvert.SerializeObject(vehicle, Formatting.Indented, new JsonSerializerSettings
                { TypeNameHandling = TypeNameHandling.All, PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                fileStream.Write(jsonVehicle);
            }
        }

        public object[] Deserialize(string filePath)
        {
            object[] vehicle;
            using (StreamReader fileStream = new StreamReader(filePath))
            {
                string jsonVehicle = fileStream.ReadToEnd();
                vehicle = (object[])JsonConvert.DeserializeObject<object[]>(jsonVehicle, new JsonSerializerSettings
                { TypeNameHandling = TypeNameHandling.All, PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
            return vehicle;
        }
    }
}
