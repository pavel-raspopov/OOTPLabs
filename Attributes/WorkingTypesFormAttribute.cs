using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Attributes
{
    class WorkingTypesFormAttribute : Attribute
    {
        public Type[] WorkingTypes { get; set; }
        public WorkingTypesFormAttribute(Type[] workingTypes)
        {
            WorkingTypes = workingTypes;
        }
        public bool CheckWorkersTypes(Type workingType)
        {
            for (int i = 0; i < WorkingTypes.Length; i++)
                if (WorkingTypes[i] == workingType)
                    return true;
            return false;
        }
    }
}
