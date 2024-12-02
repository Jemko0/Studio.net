using StudioDotNet.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static StudioDotNet.Internal.DataStructures;
using StudioDotNet.Forms.Timeline;

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
        
        public void AddPatternToTimeline(TimelineData.T_Vis_PatternPosition position)
        {
            mainTracker.placedPatterns.Add(new TimelineData.T_PlacedPattern(position, 0));
            Program.formManager.GetForm<Timeline>("timeline").Refresh();
        }

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

        private void FileDropDown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem?.Text)
            {
                case "New":
                    Saving.CreateNew();
                    return;

                case "Open":
                    OpenFileDialog fd = new OpenFileDialog();
                    fd.ShowDialog();
                    fd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                    fd.Multiselect = false;
                    Saving.OpenFile(fd.FileName);
                    return;

                case "Save":
                    Saving.SaveFile(System.IO.Directory.GetCurrentDirectory() + "/Projects/" + textBox1.Text);
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddPatternToTimeline();
        }
    }
}
