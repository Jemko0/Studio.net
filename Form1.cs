using StudioDotNet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioDotNet
{
    public partial class StudioForm : Form
    {
        private int zoom = 16;
        public StudioForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Image image = new Bitmap(Resources.BG, new Size(32 * zoom / 16, 32 * zoom / 16));
            TextureBrush tBrush = new TextureBrush(image);
            Pen blackPen = new Pen(Color.Black);
            e.Graphics.FillRectangle(tBrush, new Rectangle(0, 0, StudioForm.ActiveForm.Width, StudioForm.ActiveForm.Height));
        }
    }
}
