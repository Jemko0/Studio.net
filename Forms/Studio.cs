using StudioDotNet.Forms;
using System;
using System.Windows.Forms;
using static StudioDotNet.Internal.DataStructures;

namespace StudioDotNet
{
    public partial class StudioForm : Form
    {
        private IVector2 Tzoom = new IVector2(16, 16);

        public IVector2 GetZoom()
        {
            return Tzoom;
        }

        public StudioForm()
        {
            InitializeComponent();
        }

        private void StudioForm_Load(object sender, EventArgs e)
        {
            Program.formManager.CreateForm<Timeline>("time").Show();
        }
    }
}
