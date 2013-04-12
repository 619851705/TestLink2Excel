using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLink2Excel.Utils
{
    public delegate void ObjectHelperOnHangeHandler(object instance);
    
    public static class ObjectHelper
    {
        public static event ObjectHelperOnHangeHandler OnChanged;

        public static void RaiseChanged(object instance)
        {
            if (OnChanged != null)
            {
                OnChanged(instance);
            }
        }
    }
}
