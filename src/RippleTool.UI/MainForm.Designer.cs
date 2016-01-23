namespace RippleTool.UI
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewResponse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSeparator01 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemViewPing = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusItemServerUri = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemView});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemFileExit
            // 
            this.menuItemFileExit.Name = "menuItemFileExit";
            this.menuItemFileExit.Size = new System.Drawing.Size(92, 22);
            this.menuItemFileExit.Text = "E&xit";
            this.menuItemFileExit.Click += new System.EventHandler(this.menuItemFileExit_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewResponse,
            this.menuItemViewSeparator01,
            this.menuItemViewPing});
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(44, 20);
            this.menuItemView.Text = "&View";
            // 
            // menuItemViewResponse
            // 
            this.menuItemViewResponse.Name = "menuItemViewResponse";
            this.menuItemViewResponse.Size = new System.Drawing.Size(124, 22);
            this.menuItemViewResponse.Text = "Response";
            this.menuItemViewResponse.Click += new System.EventHandler(this.menuItemViewResponse_Click);
            // 
            // menuItemViewSeparator01
            // 
            this.menuItemViewSeparator01.Name = "menuItemViewSeparator01";
            this.menuItemViewSeparator01.Size = new System.Drawing.Size(121, 6);
            // 
            // menuItemViewPing
            // 
            this.menuItemViewPing.Name = "menuItemViewPing";
            this.menuItemViewPing.Size = new System.Drawing.Size(124, 22);
            this.menuItemViewPing.Text = "Ping";
            this.menuItemViewPing.Click += new System.EventHandler(this.menuItemViewPing_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusItemServerUri});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusItemServerUri
            // 
            this.statusItemServerUri.Name = "statusItemServerUri";
            this.statusItemServerUri.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "RippleTool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewResponse;
        private System.Windows.Forms.ToolStripSeparator menuItemViewSeparator01;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewPing;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusItemServerUri;
    }
}