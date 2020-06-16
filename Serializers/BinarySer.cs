using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOTP.Serializers
{
    public class BinarySer : ISer
    {
        public string FileExtension { get; } = ".dat|*.dat";
        public void Serialize(object[] vehicle, string filePath)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(fileStream, vehicle);
            }
        }
        public object[] Deserialize(string filePath)
        {
            object[] vehicle;
            BinaryFormatter binFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                vehicle = (object[])binFormatter.Deserialize(fileStream);
            }
            return vehicle;
        }
    }
}
