using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioDotNet
{
    public class StringPropertyParser
    {
        private static char P_SEPERATOR = ';';
        public static string MakeProperty(string pname, string pvalue)
        {
            return pname + " = " + pvalue + P_SEPERATOR;
        }

        public static string GetPropertyValueFromPropertyList(string properties, string pname)
        {
            string str = GetPropertyFromPropertyList(properties, pname);
            str.Replace(pname, "");
            str.Replace("=", "");
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

        public static string ParseByteArray(byte[] list)
        {
            string s = "";
            foreach(var i in list)
            {
                s += i.ToString();
                if (list.Last<byte>() != i)
                {
                    s += ':';
                }
            }
            return s;
        }


        /// <summary>
        /// Very inefficient way of replacing chars in a string when theyre next to other ones
        /// </summary>
        /// <param name="s"></param>
        /// <param name="ch"></param>
        /// <returns></returns>
        public static string ReplaceFix(string s, char ch)
        {
            char[] c = s.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == ch)
                {
                    c[i] = '\0';
                }
            }

            string newString = "";

            for (int i = 0; i < c.Length; i++)
            {
                if(c[i] != '\0')
                {
                    newString += s;
                }
            }

            return newString;
        }
    }
}
