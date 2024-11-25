using System;

namespace StudioDotNet.Internal
{
    public class DataStructures
    {
        public DataStructures() { }

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
