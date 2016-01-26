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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileSeparator01 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewResponse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSeparator01 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemViewPing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountCurrencies = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusItemServerUri = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusItemProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.themeVS2012Light = new WeifenLuo.WinFormsUI.Docking.VS2012LightTheme();
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
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileSettings,
            this.menuItemFileSeparator01,
            this.menuItemFileExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemFileSettings
            // 
            this.menuItemFileSettings.Name = "menuItemFileSettings";
            this.menuItemFileSettings.Size = new System.Drawing.Size(125, 22);
            this.menuItemFileSettings.Text = "Settings...";
            this.menuItemFileSettings.Click += new System.EventHandler(this.menuItemFileSettings_Click);
            // 
            // menuItemFileSeparator01
            // 
            this.menuItemFileSeparator01.Name = "menuItemFileSeparator01";
            this.menuItemFileSeparator01.Size = new System.Drawing.Size(122, 6);
            // 
            // menuItemFileExit
            // 
            this.menuItemFileExit.Name = "menuItemFileExit";
            this.menuItemFileExit.Size = new System.Drawing.Size(125, 22);
            this.menuItemFileExit.Text = "E&xit";
            this.menuItemFileExit.Click += new System.EventHandler(this.menuItemFileExit_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewRequest,
            this.menuItemViewResponse,
            this.menuItemViewSeparator01,
            this.menuItemViewPing,
            this.menuItemViewRandom,
            this.menuItemViewAccountCurrencies});
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(44, 20);
            this.menuItemView.Text = "&View";
            // 
            // menuItemViewRequest
            // 
            this.menuItemViewRequest.Name = "menuItemViewRequest";
            this.menuItemViewRequest.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewRequest.Text = "Request";
            this.menuItemViewRequest.Click += new System.EventHandler(this.menuItemViewRequest_Click);
            // 
            // menuItemViewResponse
            // 
            this.menuItemViewResponse.Name = "menuItemViewResponse";
            this.menuItemViewResponse.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewResponse.Text = "Response";
            this.menuItemViewResponse.Click += new System.EventHandler(this.menuItemViewResponse_Click);
            // 
            // menuItemViewSeparator01
            // 
            this.menuItemViewSeparator01.Name = "menuItemViewSeparator01";
            this.menuItemViewSeparator01.Size = new System.Drawing.Size(175, 6);
            // 
            // menuItemViewPing
            // 
            this.menuItemViewPing.Name = "menuItemViewPing";
            this.menuItemViewPing.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewPing.Text = "Ping";
            this.menuItemViewPing.Click += new System.EventHandler(this.menuItemViewPing_Click);
            // 
            // menuItemViewRandom
            // 
            this.menuItemViewRandom.Name = "menuItemViewRandom";
            this.menuItemViewRandom.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewRandom.Text = "Random";
            this.menuItemViewRandom.Click += new System.EventHandler(this.menuItemViewRandom_Click);
            // 
            // menuItemViewAccountCurrencies
            // 
            this.menuItemViewAccountCurrencies.Name = "menuItemViewAccountCurrencies";
            this.menuItemViewAccountCurrencies.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewAccountCurrencies.Text = "Account Currencies";
            this.menuItemViewAccountCurrencies.Click += new System.EventHandler(this.menuItemViewAccountCurrencies_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusItemServerUri,
            this.statusItemProgress});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusItemServerUri
            // 
            this.statusItemServerUri.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusItemServerUri.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.statusItemServerUri.Name = "statusItemServerUri";
            this.statusItemServerUri.Size = new System.Drawing.Size(667, 19);
            this.statusItemServerUri.Spring = true;
            this.statusItemServerUri.Text = "wss://s1.ripple.com";
            this.statusItemServerUri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusItemProgress
            // 
            this.statusItemProgress.MarqueeAnimationSpeed = 0;
            this.statusItemProgress.Name = "statusItemProgress";
            this.statusItemProgress.Size = new System.Drawing.Size(100, 18);
            this.statusItemProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // dockPanel
            // 
            this.dockPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 24);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(784, 514);
            this.dockPanel.TabIndex = 1;
            this.dockPanel.Theme = this.themeVS2012Light;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem menuItemFileSettings;
        private System.Windows.Forms.ToolStripSeparator menuItemFileSeparator01;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewRequest;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewResponse;
        private System.Windows.Forms.ToolStripSeparator menuItemViewSeparator01;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewPing;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewRandom;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountCurrencies;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusItemServerUri;
        private System.Windows.Forms.ToolStripProgressBar statusItemProgress;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private WeifenLuo.WinFormsUI.Docking.VS2012LightTheme themeVS2012Light;
    }
}