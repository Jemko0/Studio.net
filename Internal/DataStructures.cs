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
                    this.timeSignature = new T_TimeSignature(4, 4);
                }

                public Tracker(string projectName, List<T_Pattern> patterns, T_TimeSignature timeSignature)
                {
                    this.projectName = projectName;
                    this.patterns = patterns;
                    this.timeSignature = timeSignature;
                }

                public string projectName;
                public List<T_Pattern> patterns;
                public T_TimeSignature timeSignature;
            }

            public struct T_Pattern
            {
                public byte instrument;
                public byte track;
                public List<T_PatternNote> notes;
            }

            public struct T_PatternNote
            {
                public float time;
                public float length;
                public sbyte pitch;
            }

            public struct T_TimeSignature
            {
                public int numerator;
                public int denominator;

                public T_TimeSignature(int num, int den)
                {
                    numerator = num;
                    denominator = den;
                }
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
