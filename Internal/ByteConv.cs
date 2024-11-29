using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioDotNet.Internal
{
    public class Conv
    {
        public static string PatternToString(DataStructures.TimelineData.T_Pattern pattern)
        {
            string s = "";
            
            s += pattern.instrument;
            s += "_";
            s += 0;

            foreach (DataStructures.TimelineData.T_PatternNote note in pattern.notes)
            {
                s += StringPropertyParser.ParseByteArray(BitConverter.GetBytes(note.time));
                s += "_";
                s += StringPropertyParser.ParseByteArray(BitConverter.GetBytes(note.pitch));
            }

            return s;
        }

        public static DataStructures.TimelineData.T_Pattern StringToPattern(string s)
        {
            DataStructures.TimelineData.T_Pattern p = new DataStructures.TimelineData.T_Pattern();
            string inst_byte = StringPropertyParser.GetPropertyValueFromPropertyList(s, "pt");
            System.Diagnostics.Debug.WriteLine(inst_byte);
            p.instrument = byte.Parse("0");

            return p;
        }
    }
}
