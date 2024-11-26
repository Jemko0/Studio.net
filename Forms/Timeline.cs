using StudioDotNet.Properties;
using System.Drawing;
using System.Windows.Forms;
using static StudioDotNet.Internal.DataStructures;

namespace StudioDotNet.Forms
{
    public partial class Timeline : Form
    {
        public Timeline()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            StudioForm s = Program.formManager.GetForm("studio") as StudioForm;
            IVector2 Zoom = s.GetZoom();

            Image image = new Bitmap(Resources.BG, new Size(32 * Zoom.x / 16, 32 * Zoom.y / 16));
            TextureBrush tBrush = new TextureBrush(image);
            Pen blackPen = new Pen(Color.Black);
            e.Graphics.FillRectangle(tBrush, new Rectangle(0, 0, StudioForm.ActiveForm.Width, StudioForm.ActiveForm.Height));
        }

        private void FileDropdown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
;            System.Diagnostics.Debug.WriteLine(e.ClickedItem.Text);
            switch (e.ClickedItem.Text)
            {
                case "Open":
                    return;

                case "Quit":
                    StudioForm s = Program.formManager.GetForm<StudioForm>("studio");
                    s.CheckUnsaved();
                    Program.formManager.ExitThread();
                    return;
            }
        }
    }
}
