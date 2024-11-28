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
            s += 0;

            foreach (DataStructures.TimelineData.T_PatternNote note in pattern.notes)
            {
                s += StringPropertyParser.ParseByteArray(BitConverter.GetBytes(note.time));
                s += "_";
                s += StringPropertyParser.ParseByteArray(BitConverter.GetBytes(note.pitch));
            }

            return s;
        }
    }
}
