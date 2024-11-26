using StudioDotNet.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static StudioDotNet.Internal.DataStructures;

namespace StudioDotNet
{
    public partial class StudioForm : Form
    {
        public StudioForm()
        {
            InitializeComponent();
            UIColors.DefaultColors();
        }

        public TimelineData.Tracker mainTracker = new TimelineData.Tracker("untitled",
                                                    new List<TimelineData.T_Pattern>(),
                                                    new TimelineData.T_TimeSignature(4, 4));
        
        public void CheckUnsaved()
        {
            System.Diagnostics.Debug.WriteLine("PRJ HASH: " + GetProjectHash());
        }

        public uint GetProjectHash()
        {
            return uint.MaxValue;
        }

        private void StudioForm_Load(object sender, EventArgs e)
        {
            Program.formManager.CreateForm<Timeline>("timeline").Show();
        }

        private void WindowCombo_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Text)
            {
                case "Timeline":
                    Program.formManager.CreateForm<Timeline>("timeline").Show();
                    return;
            }
        }
    }
}
