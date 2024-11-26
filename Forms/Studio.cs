using StudioDotNet.Forms;
using System;
using System.Security.Cryptography;
using System.Security.Policy;
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

        public TimelineData.Tracker mainTracker = new TimelineData.Tracker();
        
        public void CheckUnsaved()
        {
            System.Diagnostics.Debug.WriteLine("PRJ HASH: " + GetProjectHash());
        }

        public uint GetProjectHash()
        {
            return uint.MaxValue;
        }

        public StudioForm()
        {
            InitializeComponent();
        }

        private void StudioForm_Load(object sender, EventArgs e)
        {
            Program.formManager.CreateForm<Timeline>("time").Show();
        }

        private void WindowCombo_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Text)
            {
                case "Timeline":
                    Program.formManager.CreateForm<StudioForm>("studio").Show();
                    return;
            }
        }
    }
}
