﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Attributes
{
    class VehicleTypeAttribute : Attribute
    {
        public string TypeName { get; set; }

        public VehicleTypeAttribute(string typeName)
        {
            TypeName = typeName;
        }
    }
}