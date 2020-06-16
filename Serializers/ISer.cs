using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Serializers
{
    public interface ISer
    {
        string FileExtension { get; }
        void Serialize(object[] vehicle, string filePath);
        object[] Deserialize(string filePath);
    }
}
