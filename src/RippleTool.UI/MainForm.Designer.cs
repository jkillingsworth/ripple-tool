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
            this.menuItemFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewResponse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemViewPing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountCurrencies = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountLines = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountOffers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountTx = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewNoRippleCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewGatewayBalances = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewTx = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpDeveloperCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpKnowledgeCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuItemView,
            this.menuItemWindow,
            this.menuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.menuItemWindow;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileSettings,
            this.menuItemFileSeparator1,
            this.menuItemFileExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemFileSettings
            // 
            this.menuItemFileSettings.Name = "menuItemFileSettings";
            this.menuItemFileSettings.Size = new System.Drawing.Size(116, 22);
            this.menuItemFileSettings.Text = "Settings";
            this.menuItemFileSettings.Click += new System.EventHandler(this.menuItemFileSettings_Click);
            // 
            // menuItemFileSeparator1
            // 
            this.menuItemFileSeparator1.Name = "menuItemFileSeparator1";
            this.menuItemFileSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // menuItemFileExit
            // 
            this.menuItemFileExit.Name = "menuItemFileExit";
            this.menuItemFileExit.Size = new System.Drawing.Size(116, 22);
            this.menuItemFileExit.Text = "E&xit";
            this.menuItemFileExit.Click += new System.EventHandler(this.menuItemFileExit_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewRequest,
            this.menuItemViewResponse,
            this.menuItemViewSeparator1,
            this.menuItemViewPing,
            this.menuItemViewRandom,
            this.menuItemViewAccountCurrencies,
            this.menuItemViewAccountInfo,
            this.menuItemViewAccountLines,
            this.menuItemViewAccountOffers,
            this.menuItemViewAccountObjects,
            this.menuItemViewAccountTx,
            this.menuItemViewNoRippleCheck,
            this.menuItemViewGatewayBalances,
            this.menuItemViewTx});
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
            // menuItemViewSeparator1
            // 
            this.menuItemViewSeparator1.Name = "menuItemViewSeparator1";
            this.menuItemViewSeparator1.Size = new System.Drawing.Size(175, 6);
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
            // menuItemViewAccountInfo
            // 
            this.menuItemViewAccountInfo.Name = "menuItemViewAccountInfo";
            this.menuItemViewAccountInfo.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewAccountInfo.Text = "Account Info";
            this.menuItemViewAccountInfo.Click += new System.EventHandler(this.menuItemViewAccountInfo_Click);
            // 
            // menuItemViewAccountLines
            // 
            this.menuItemViewAccountLines.Name = "menuItemViewAccountLines";
            this.menuItemViewAccountLines.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewAccountLines.Text = "Account Lines";
            this.menuItemViewAccountLines.Click += new System.EventHandler(this.menuItemViewAccountLines_Click);
            // 
            // menuItemViewAccountOffers
            // 
            this.menuItemViewAccountOffers.Name = "menuItemViewAccountOffers";
            this.menuItemViewAccountOffers.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewAccountOffers.Text = "Account Offers";
            this.menuItemViewAccountOffers.Click += new System.EventHandler(this.menuItemViewAccountOffers_Click);
            // 
            // menuItemViewAccountObjects
            // 
            this.menuItemViewAccountObjects.Name = "menuItemViewAccountObjects";
            this.menuItemViewAccountObjects.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewAccountObjects.Text = "Account Objects";
            this.menuItemViewAccountObjects.Click += new System.EventHandler(this.menuItemViewAccountObjects_Click);
            // 
            // menuItemViewAccountTx
            // 
            this.menuItemViewAccountTx.Name = "menuItemViewAccountTx";
            this.menuItemViewAccountTx.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewAccountTx.Text = "Account Tx";
            this.menuItemViewAccountTx.Click += new System.EventHandler(this.menuItemViewAccountTx_Click);
            // 
            // menuItemViewNoRippleCheck
            // 
            this.menuItemViewNoRippleCheck.Name = "menuItemViewNoRippleCheck";
            this.menuItemViewNoRippleCheck.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewNoRippleCheck.Text = "No Ripple Check";
            this.menuItemViewNoRippleCheck.Click += new System.EventHandler(this.menuItemViewNoRippleCheck_Click);
            // 
            // menuItemViewGatewayBalances
            // 
            this.menuItemViewGatewayBalances.Name = "menuItemViewGatewayBalances";
            this.menuItemViewGatewayBalances.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewGatewayBalances.Text = "Gateway Balances";
            this.menuItemViewGatewayBalances.Click += new System.EventHandler(this.menuItemViewGatewayBalances_Click);
            // 
            // menuItemViewTx
            // 
            this.menuItemViewTx.Name = "menuItemViewTx";
            this.menuItemViewTx.Size = new System.Drawing.Size(178, 22);
            this.menuItemViewTx.Text = "Tx";
            this.menuItemViewTx.Click += new System.EventHandler(this.menuItemViewTx_Click);
            // 
            // menuItemWindow
            // 
            this.menuItemWindow.Name = "menuItemWindow";
            this.menuItemWindow.Size = new System.Drawing.Size(63, 20);
            this.menuItemWindow.Text = "&Window";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHelpDeveloperCenter,
            this.menuItemHelpKnowledgeCenter,
            this.menuItemHelpSeparator1,
            this.menuItemHelpAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "&Help";
            // 
            // menuItemHelpDeveloperCenter
            // 
            this.menuItemHelpDeveloperCenter.Name = "menuItemHelpDeveloperCenter";
            this.menuItemHelpDeveloperCenter.Size = new System.Drawing.Size(171, 22);
            this.menuItemHelpDeveloperCenter.Text = "Developer Center";
            this.menuItemHelpDeveloperCenter.Click += new System.EventHandler(this.menuItemHelpDeveloperCenter_Click);
            // 
            // menuItemHelpKnowledgeCenter
            // 
            this.menuItemHelpKnowledgeCenter.Name = "menuItemHelpKnowledgeCenter";
            this.menuItemHelpKnowledgeCenter.Size = new System.Drawing.Size(171, 22);
            this.menuItemHelpKnowledgeCenter.Text = "Knowledge Center";
            this.menuItemHelpKnowledgeCenter.Click += new System.EventHandler(this.menuItemHelpKnowledgeCenter_Click);
            // 
            // menuItemHelpSeparator1
            // 
            this.menuItemHelpSeparator1.Name = "menuItemHelpSeparator1";
            this.menuItemHelpSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // menuItemHelpAbout
            // 
            this.menuItemHelpAbout.Name = "menuItemHelpAbout";
            this.menuItemHelpAbout.Size = new System.Drawing.Size(171, 22);
            this.menuItemHelpAbout.Text = "About RippleTool";
            this.menuItemHelpAbout.Click += new System.EventHandler(this.menuItemHelpAbout_Click);
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
        private System.Windows.Forms.ToolStripSeparator menuItemFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewRequest;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewResponse;
        private System.Windows.Forms.ToolStripSeparator menuItemViewSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewPing;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewRandom;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountCurrencies;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountInfo;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountLines;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountOffers;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountObjects;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountTx;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewNoRippleCheck;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewGatewayBalances;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewTx;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpKnowledgeCenter;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpDeveloperCenter;
        private System.Windows.Forms.ToolStripSeparator menuItemHelpSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpAbout;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusItemServerUri;
        private System.Windows.Forms.ToolStripProgressBar statusItemProgress;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private WeifenLuo.WinFormsUI.Docking.VS2012LightTheme themeVS2012Light;
    }
}