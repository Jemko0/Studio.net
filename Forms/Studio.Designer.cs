namespace StudioDotNet
{
    partial class StudioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudioForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.WindowCombo = new System.Windows.Forms.ToolStripDropDownButton();
            this.timelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCombo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1031, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // WindowCombo
            // 
            this.WindowCombo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WindowCombo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timelineToolStripMenuItem});
            this.WindowCombo.Image = ((System.Drawing.Image)(resources.GetObject("WindowCombo.Image")));
            this.WindowCombo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WindowCombo.Name = "WindowCombo";
            this.WindowCombo.Size = new System.Drawing.Size(78, 24);
            this.WindowCombo.Text = "Window";
            this.WindowCombo.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.WindowCombo_DropDownItemClicked);
            // 
            // timelineToolStripMenuItem
            // 
            this.timelineToolStripMenuItem.Name = "timelineToolStripMenuItem";
            this.timelineToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.timelineToolStripMenuItem.Text = "Timeline";
            // 
            // StudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = global::StudioDotNet.Properties.Resources.StdBGTransparent;
            this.ClientSize = new System.Drawing.Size(1031, 578);
            this.Controls.Add(this.toolStrip1);
            this.Name = "StudioForm";
            this.Text = "Studio.net";
            this.Load += new System.EventHandler(this.StudioForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton WindowCombo;
        private System.Windows.Forms.ToolStripMenuItem timelineToolStripMenuItem;
    }
}

