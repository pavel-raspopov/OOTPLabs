using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using OOTP.Vehicles;

namespace OOTP.Serializers
{
    class TextSer : ISer
    {
        public string FileExtension { get; } = ".txt|*.txt";
        public void Serialize(object[] vehicle, string filePath)
        {
            using (StreamWriter fileStream = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                for (int i = 0; i < vehicle.Length; i++)
                {
                    string result = vehicle[i].GetType().FullName + "*";
                    result += SerializeObj(vehicle[i]);
                    fileStream.WriteLine(result);
                }
            }
        }
        public object[] Deserialize(string filePath)
        {
            int pos = 0;
            string line;
            object[] vehicle = new Vehicle[GetObjAmount(filePath)];
            using (StreamReader fileStream = new StreamReader(filePath, Encoding.UTF8))
            {
                for (int i = 0; i < vehicle.Length; i++)
                {
                    line = fileStream.ReadLine();
                    Type objType = Type.GetType(GetValue(line, ref pos));
                    vehicle[i] = DeserializeObj(objType, line, ref pos);
                    pos = 0;
                }
            }
            return vehicle;
        }
        private string SerializeObj(object obj)
        {
            string result = "";
            PropertyInfo[] props = obj.GetType().GetProperties();

            for (int i = 0; i < props.Length; i++)
            {
                Type propType = props[i].GetValue(obj).GetType();
                if ((propType.IsClass) && (propType.Namespace != "System"))
                    result += SerializeObj(props[i].GetValue(obj));
                else
                    result += Convert.ToString(props[i].GetValue(obj)) + '*';
            }
            return result;
        }
        private object DeserializeObj(Type type, string line, ref int pos)
        {
            object obj = Activator.CreateInstance(type);
            PropertyInfo[] props;
            props = obj.GetType().GetProperties();
            for (int i = 0; i < props.Length; i++)
            {
                Type propType = props[i].GetValue(obj).GetType();
                if ((propType.IsClass) && (propType.Namespace != "System"))
                    props[i].SetValue(obj, DeserializeObj(propType, line, ref pos));
                else
                    SetObjValue(obj, props[i], GetValue(line, ref pos));
            }
            return obj;
        }
        private string GetValue(string line, ref int pos)
        {
            string result = "";
            while ((line[pos] != '*') && (pos < line.Length))
            {
                result += line[pos];
                pos++;
            }
            pos++;
            return result;
        }
        private int GetObjAmount(string filePath)
        {
            int result = 0;
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                    result++;
            }
            return result;
        }
        public void SetObjValue(Object vehicle, PropertyInfo prop, string value)
        {
            object obj;
            Type type = prop.GetValue(vehicle).GetType();
            if (type.IsEnum)
                obj = Enum.Parse(type, value);
            else
                obj = Convert.ChangeType(value, type);
            prop.SetValue(vehicle, obj);
        }
    }
}
