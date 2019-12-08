using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class StringTools
    {
        public static String ToStringproperties<T> (this T t)
        {
            String result = "";
            foreach (PropertyInfo item in t.GetType().GetProperties())
            {
                result += String.Format("{0,-30}    {1,-50}\n", item.Name, item.GetValue(t, null));
            }
            return result;
        }
    }
}
