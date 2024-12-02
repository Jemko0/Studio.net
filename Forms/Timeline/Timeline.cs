using StudioDotNet.Internal;
using StudioDotNet.Properties;
using System.Drawing;
using System.Windows.Forms;
using static StudioDotNet.Internal.DataStructures;
using static StudioDotNet.Internal.DataStructures.TimelineData;

namespace StudioDotNet.Forms.Timeline
{
    public partial class Timeline : Form
    {
        public Timeline()
        {
            InitializeComponent();
        }

        private IVector2 zoom = new IVector2(16, 48);
        private IVector2 timelinePos = new IVector2(0, 0);
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Image image = new Bitmap(Resources.BG, new Size(32 * zoom.x / 16, 32 * zoom.y / 16));

            SolidBrush b_brush = new SolidBrush(UIColors.GetColorByKey("backgrounds"));
            SolidBrush l_brush = new SolidBrush(UIColors.GetColorByKey("tl_lines"));
            SolidBrush p_brush = new SolidBrush(UIColors.GetColorByKey("pt_background"));
            
            //background
            e.Graphics.FillRectangle(b_brush, new Rectangle(0, 0, ActiveForm.Width, ActiveForm.Height));

            //lines
            for(int x = 0; x < pictureBox1.Width; x++)
            {
                T_TimeSignature timeSig = Program.formManager.GetForm<StudioForm>("studioform").mainTracker.timeSignature;

                int lThickness = x % timeSig.numerator == 0 ? 2 : 1;
                e.Graphics.FillRectangle(l_brush, new Rectangle((x * zoom.x) - timelinePos.x , 0, lThickness, pictureBox1.Height));
            }

            for(int y = 0; y < pictureBox1.Height; y++)
            {
                e.Graphics.FillRectangle(l_brush, new Rectangle(0, (y * zoom.y) - timelinePos.y, pictureBox1.Width, 2));
            }

            foreach (T_PlacedPattern pt in Program.formManager.GetForm<StudioForm>("studioform").mainTracker.placedPatterns)
            {
                e.Graphics.FillRectangle(p_brush, new RectangleF(-timelinePos.x + pt.position.timeSlot * (float)zoom.x / 16.0f, -timelinePos.y + pt.position.track * (float)zoom.y / 48.0f, (float)zoom.x / 16.0f * 64.0f, (float)zoom.y));
            }
        }

        private void Timeline_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                timelinePos.x += 1;

            if (e.KeyCode == Keys.Left)
                timelinePos.x -= 1;

            if (e.KeyCode == Keys.Up)
                timelinePos.y += 1;

            if (e.KeyCode == Keys.Down)
                timelinePos.y -= 1;

            if (e.KeyCode == Keys.Add)
            {
                if (Control.ModifierKeys == Keys.Alt)
                {
                    zoom.y += 1;
                }
                else
                {
                    zoom.x += 1;
                }
            }

            if (e.KeyCode == Keys.Subtract)
            {
                if (Control.ModifierKeys == Keys.Alt)
                {
                    zoom.y -= 1;
                }
                else
                {
                    zoom.x -= 1;
                }
            }

            int minZoomXY = 10;

            if(zoom.x < minZoomXY)
            {
                zoom.x = minZoomXY;
            }
            if (zoom.y < minZoomXY)
            {
                zoom.y = minZoomXY;
            }

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            TimelineData.T_Vis_PatternPosition mPos = Conv.MousePosToPattern(new IVector2(e.Location));
            System.Diagnostics.Debug.WriteLine("pt ts = " + mPos.timeSlot);
            System.Diagnostics.Debug.WriteLine("pt tr = " + mPos.track);
            Program.formManager.GetForm<StudioForm>("studioform").AddPatternToTimeline(new T_Vis_PatternPosition(mPos.timeSlot, 1, mPos.track));
            System.Diagnostics.Debug.WriteLine(e.Location);
        }
    }
}
