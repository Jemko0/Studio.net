using System;
using System.Collections.Generic;
using System.Drawing;

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
                    this.placedPatterns = new List<T_PlacedPattern>();
                }

                public Tracker(string projectName, List<T_Pattern> patterns, T_TimeSignature timeSignature)
                {
                    this.projectName = projectName;
                    this.patterns = patterns;
                    this.timeSignature = timeSignature;
                    this.placedPatterns = new List<T_PlacedPattern>();
                }

                public string projectName;
                public List<T_Pattern> patterns;
                public List<T_PlacedPattern> placedPatterns;
                public T_TimeSignature timeSignature;
            }

            public struct T_Pattern
            {
                public byte instrument;
                public List<T_PatternNote> notes;

                public T_Pattern(byte instrument, List<T_PatternNote> notes)
                {
                    this.instrument = instrument;
                    this.notes = notes;
                }
            }
            
            public struct T_PlacedPattern
            {
                public T_Vis_PatternPosition position;
                public int refPattern;

                public T_PlacedPattern(T_Vis_PatternPosition pos, int refPattern)
                {
                    this.position = pos;
                    this.refPattern = refPattern;
                }
            }
            public struct T_PatternNote
            {
                public float time;
                public float length;
                public sbyte pitch;

                public T_PatternNote(float time, float length, sbyte pitch)
                {
                    this.time = time;
                    this.length = length;
                    this.pitch = pitch;
                }
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

            public struct T_Vis_PatternPosition
            {
                public int timeSlot;
                public int length;
                public int track;

                public T_Vis_PatternPosition(int timeSlot, int length, int track)
                {
                    this.timeSlot = timeSlot;
                    this.length = length;
                    this.track = track;
                }
            }
        }

        public struct IVector2 : IEquatable<IVector2>
        {
            public int x;
            public int y;

            public IVector2(int inx, int iny)
            {
                x = inx;
                y = iny;
            }

            public IVector2(Point p)
            {
                x = p.X;
                y = p.Y;
            }
            public bool Equals(IVector2 other)
            {
                return other.x == x && other.y == y;
            }

            public void Add(ref IVector2 a, ref IVector2 o)
            {
                a.x += o.x;
                a.y += o.y;
            }
        }

        public struct ProjectFileData
        {
            public string fileName;
            public string cachePath;
            public string trackerParsed;
        }
    }

    public class FUtil
    {
        public static float FSnapToGrid(ref float f, float gridSize)
        {
            return (float)Math.Round((f / gridSize)) * gridSize;
        }

        public static float FSnapToGrid(float f, float gridSize)
        {
            return (float)Math.Round((f / gridSize)) * gridSize;
        }
    }
}
