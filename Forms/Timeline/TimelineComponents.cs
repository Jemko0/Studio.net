using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioDotNet.Forms.Timeline
{
    public interface ITimelineRenderable<in T> where T : class
    {
        void getRender(T item);
    }

    public class Pattern : ITimelineRenderable<Pattern>
    {
        public void getRender(Pattern item)
        {
        }
    }
}
