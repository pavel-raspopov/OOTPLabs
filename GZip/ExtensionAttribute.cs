using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Attributes
{
    class ExtensionAttribute : Attribute
    {
        public string Extension { set; get; }
        public ExtensionAttribute(string extension)
        {
            Extension = extension;
        }
    }
}
