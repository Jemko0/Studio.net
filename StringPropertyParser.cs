using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioDotNet
{
    public class StringPropertyParser
    {
        private static char P_SEPERATOR = ':';
        public static string MakeProperty(string pname, string pvalue)
        {
            return pname + "=" + pvalue + P_SEPERATOR;
        }

        public static string GetPropertyValueFromPropertyList(string properties, string pname)
        {
            string str = GetPropertyFromPropertyList(properties, pname);
            str.Replace(pname, "");
            str.Replace("=", "");
            str.Replace(":", "");

            return str;
        }

        public static string GetPropertyFromPropertyList(string properties, string pname)
        {
            string str = properties;
            string[] strArr = str.Split(P_SEPERATOR);

            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Contains(pname))
                {
                    return strArr[i];
                }
            }
            return "BAD_PROPERTY";
        }
    }
}
