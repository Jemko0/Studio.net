using System;
using System.Collections.Generic;

namespace StudioDotNet.Internal
{
    public class DataStructures
    {
        public partial class TimelineData
        {
            public struct Tracker
            {
                public Tracker(string projectName, List<T_Pattern> patterns)
                {
                    this.projectName = projectName;
                    this.patterns = patterns;
                }

                public string projectName;
                public List<T_Pattern> patterns;
            }

            public struct T_Pattern
            {
                public byte instrument;
                public List<T_PatternNote> notes;
            }

            public struct T_PatternNote
            {
                public float time;
                public float length;
                public sbyte pitch;
            }
        }

        public struct IVector2
        {
            public int x;
            public int y;

            public IVector2(int inx, int iny)
            {
                x = inx;
                y = iny;
            }
        }
    }
}
