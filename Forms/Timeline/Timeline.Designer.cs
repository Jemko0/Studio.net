namespace StudioDotNet.Forms.Timeline
{
    partial class Timeline
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
            this.TimelineToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBTN_PaintTool = new System.Windows.Forms.ToolStripButton();
            this.toolBTN_BrushTool = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimelineToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimelineToolStrip
            // 
            this.TimelineToolStrip.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.TimelineToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolBTN_PaintTool,
            this.toolBTN_BrushTool});
            this.TimelineToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TimelineToolStrip.Name = "TimelineToolStrip";
            this.TimelineToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TimelineToolStrip.Size = new System.Drawing.Size(716, 32);
            this.TimelineToolStrip.Stretch = true;
            this.TimelineToolStrip.TabIndex = 2;
            this.TimelineToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolBTN_PaintTool
            // 
            this.toolBTN_PaintTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBTN_PaintTool.Image = global::StudioDotNet.Properties.Resources.TTools_PaintTool;
            this.toolBTN_PaintTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBTN_PaintTool.Name = "toolBTN_PaintTool";
            this.toolBTN_PaintTool.Size = new System.Drawing.Size(29, 29);
            this.toolBTN_PaintTool.Text = "Paint";
            // 
            // toolBTN_BrushTool
            // 
            this.toolBTN_BrushTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBTN_BrushTool.Image = global::StudioDotNet.Properties.Resources.TTools_BrushTool;
            this.toolBTN_BrushTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBTN_BrushTool.Name = "toolBTN_BrushTool";
            this.toolBTN_BrushTool.Size = new System.Drawing.Size(29, 29);
            this.toolBTN_BrushTool.Text = "Brush";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(692, 344);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 386);
            this.Controls.Add(this.TimelineToolStrip);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Timeline";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Timeline";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Timeline_KeyDown);
            this.TimelineToolStrip.ResumeLayout(false);
            this.TimelineToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip TimelineToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBTN_BrushTool;
        private System.Windows.Forms.ToolStripButton toolBTN_PaintTool;
    }
}