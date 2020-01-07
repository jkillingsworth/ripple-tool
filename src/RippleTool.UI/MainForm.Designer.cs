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
            this.menuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewResponse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemViewRawJson = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewPing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemViewFee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewServerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewServerState = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemViewAccountCurrencies = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountLines = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountOffers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewGatewayBalances = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewNoRippleCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemViewBookOffers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewRipplePathFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSubmit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSubmitPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSubmitAccountSet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSubmitSetRegularKey = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSubmitOfferCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSubmitOfferCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSubmitTrustSet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewTransactionInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemToolsGenerateKeyPair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindowCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpXrpLedgerDevPortal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpXrpCharts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusItemProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusItemServerUri = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusItemAccountId = new System.Windows.Forms.ToolStripStatusLabel();
            this.dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dialogSaveFile = new System.Windows.Forms.SaveFileDialog();
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
            this.menuItemTools,
            this.menuItemWindow,
            this.menuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.menuItemWindow;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.MenuActivate += new System.EventHandler(this.menuStrip_MenuActivate);
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileNew,
            this.menuItemFileOpen,
            this.menuItemFileSave,
            this.menuItemFileSaveAs,
            this.menuItemFileSeparator1,
            this.menuItemFileSettings,
            this.menuItemFileSeparator2,
            this.menuItemFileExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemFileNew
            // 
            this.menuItemFileNew.Name = "menuItemFileNew";
            this.menuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemFileNew.Size = new System.Drawing.Size(155, 22);
            this.menuItemFileNew.Text = "&New";
            this.menuItemFileNew.Click += new System.EventHandler(this.menuItemFileNew_Click);
            // 
            // menuItemFileOpen
            // 
            this.menuItemFileOpen.Name = "menuItemFileOpen";
            this.menuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemFileOpen.Size = new System.Drawing.Size(155, 22);
            this.menuItemFileOpen.Text = "&Open...";
            this.menuItemFileOpen.Click += new System.EventHandler(this.menuItemFileOpen_Click);
            // 
            // menuItemFileSave
            // 
            this.menuItemFileSave.Name = "menuItemFileSave";
            this.menuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemFileSave.Size = new System.Drawing.Size(155, 22);
            this.menuItemFileSave.Text = "&Save";
            this.menuItemFileSave.Click += new System.EventHandler(this.menuItemFileSave_Click);
            // 
            // menuItemFileSaveAs
            // 
            this.menuItemFileSaveAs.Name = "menuItemFileSaveAs";
            this.menuItemFileSaveAs.Size = new System.Drawing.Size(155, 22);
            this.menuItemFileSaveAs.Text = "Save &As...";
            this.menuItemFileSaveAs.Click += new System.EventHandler(this.menuItemFileSaveAs_Click);
            // 
            // menuItemFileSeparator1
            // 
            this.menuItemFileSeparator1.Name = "menuItemFileSeparator1";
            this.menuItemFileSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // menuItemFileSettings
            // 
            this.menuItemFileSettings.Name = "menuItemFileSettings";
            this.menuItemFileSettings.Size = new System.Drawing.Size(155, 22);
            this.menuItemFileSettings.Text = "Settings";
            this.menuItemFileSettings.Click += new System.EventHandler(this.menuItemFileSettings_Click);
            // 
            // menuItemFileSeparator2
            // 
            this.menuItemFileSeparator2.Name = "menuItemFileSeparator2";
            this.menuItemFileSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // menuItemFileExit
            // 
            this.menuItemFileExit.Name = "menuItemFileExit";
            this.menuItemFileExit.Size = new System.Drawing.Size(155, 22);
            this.menuItemFileExit.Text = "E&xit";
            this.menuItemFileExit.Click += new System.EventHandler(this.menuItemFileExit_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewRequest,
            this.menuItemViewResponse,
            this.menuItemViewSeparator1,
            this.menuItemViewRawJson,
            this.menuItemViewPing,
            this.menuItemViewRandom,
            this.menuItemViewSeparator2,
            this.menuItemViewFee,
            this.menuItemViewServerInfo,
            this.menuItemViewServerState,
            this.menuItemViewSeparator3,
            this.menuItemViewAccountCurrencies,
            this.menuItemViewAccountInfo,
            this.menuItemViewAccountLines,
            this.menuItemViewAccountObjects,
            this.menuItemViewAccountOffers,
            this.menuItemViewAccountTransactions,
            this.menuItemViewGatewayBalances,
            this.menuItemViewNoRippleCheck,
            this.menuItemViewSeparator4,
            this.menuItemViewBookOffers,
            this.menuItemViewRipplePathFind,
            this.menuItemViewSubmit,
            this.menuItemViewTransactionInfo});
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(44, 20);
            this.menuItemView.Text = "&View";
            // 
            // menuItemViewRequest
            // 
            this.menuItemViewRequest.Name = "menuItemViewRequest";
            this.menuItemViewRequest.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.menuItemViewRequest.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewRequest.Text = "Re&quest";
            this.menuItemViewRequest.Click += new System.EventHandler(this.menuItemViewRequest_Click);
            // 
            // menuItemViewResponse
            // 
            this.menuItemViewResponse.Name = "menuItemViewResponse";
            this.menuItemViewResponse.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuItemViewResponse.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewResponse.Text = "Re&sponse";
            this.menuItemViewResponse.Click += new System.EventHandler(this.menuItemViewResponse_Click);
            // 
            // menuItemViewSeparator1
            // 
            this.menuItemViewSeparator1.Name = "menuItemViewSeparator1";
            this.menuItemViewSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // menuItemViewRawJson
            // 
            this.menuItemViewRawJson.Name = "menuItemViewRawJson";
            this.menuItemViewRawJson.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewRawJson.Text = "JSON";
            this.menuItemViewRawJson.Click += new System.EventHandler(this.menuItemViewRawJson_Click);
            // 
            // menuItemViewPing
            // 
            this.menuItemViewPing.Name = "menuItemViewPing";
            this.menuItemViewPing.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewPing.Text = "Ping";
            this.menuItemViewPing.Click += new System.EventHandler(this.menuItemViewPing_Click);
            // 
            // menuItemViewRandom
            // 
            this.menuItemViewRandom.Name = "menuItemViewRandom";
            this.menuItemViewRandom.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewRandom.Text = "Random";
            this.menuItemViewRandom.Click += new System.EventHandler(this.menuItemViewRandom_Click);
            // 
            // menuItemViewSeparator2
            // 
            this.menuItemViewSeparator2.Name = "menuItemViewSeparator2";
            this.menuItemViewSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // menuItemViewFee
            // 
            this.menuItemViewFee.Name = "menuItemViewFee";
            this.menuItemViewFee.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewFee.Text = "Fee";
            this.menuItemViewFee.Click += new System.EventHandler(this.menuItemViewFee_Click);
            // 
            // menuItemViewServerInfo
            // 
            this.menuItemViewServerInfo.Name = "menuItemViewServerInfo";
            this.menuItemViewServerInfo.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewServerInfo.Text = "Server Info";
            this.menuItemViewServerInfo.Click += new System.EventHandler(this.menuItemViewServerInfo_Click);
            // 
            // menuItemViewServerState
            // 
            this.menuItemViewServerState.Name = "menuItemViewServerState";
            this.menuItemViewServerState.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewServerState.Text = "Server State";
            this.menuItemViewServerState.Click += new System.EventHandler(this.menuItemViewServerState_Click);
            // 
            // menuItemViewSeparator3
            // 
            this.menuItemViewSeparator3.Name = "menuItemViewSeparator3";
            this.menuItemViewSeparator3.Size = new System.Drawing.Size(216, 6);
            // 
            // menuItemViewAccountCurrencies
            // 
            this.menuItemViewAccountCurrencies.Name = "menuItemViewAccountCurrencies";
            this.menuItemViewAccountCurrencies.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewAccountCurrencies.Text = "Account Currencies";
            this.menuItemViewAccountCurrencies.Click += new System.EventHandler(this.menuItemViewAccountCurrencies_Click);
            // 
            // menuItemViewAccountInfo
            // 
            this.menuItemViewAccountInfo.Name = "menuItemViewAccountInfo";
            this.menuItemViewAccountInfo.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewAccountInfo.Text = "Account Info";
            this.menuItemViewAccountInfo.Click += new System.EventHandler(this.menuItemViewAccountInfo_Click);
            // 
            // menuItemViewAccountLines
            // 
            this.menuItemViewAccountLines.Name = "menuItemViewAccountLines";
            this.menuItemViewAccountLines.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewAccountLines.Text = "Account Lines";
            this.menuItemViewAccountLines.Click += new System.EventHandler(this.menuItemViewAccountLines_Click);
            // 
            // menuItemViewAccountObjects
            // 
            this.menuItemViewAccountObjects.Name = "menuItemViewAccountObjects";
            this.menuItemViewAccountObjects.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewAccountObjects.Text = "Account Objects";
            this.menuItemViewAccountObjects.Click += new System.EventHandler(this.menuItemViewAccountObjects_Click);
            // 
            // menuItemViewAccountOffers
            // 
            this.menuItemViewAccountOffers.Name = "menuItemViewAccountOffers";
            this.menuItemViewAccountOffers.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewAccountOffers.Text = "Account Offers";
            this.menuItemViewAccountOffers.Click += new System.EventHandler(this.menuItemViewAccountOffers_Click);
            // 
            // menuItemViewAccountTransactions
            // 
            this.menuItemViewAccountTransactions.Name = "menuItemViewAccountTransactions";
            this.menuItemViewAccountTransactions.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewAccountTransactions.Text = "Account Transactions";
            this.menuItemViewAccountTransactions.Click += new System.EventHandler(this.menuItemViewAccountTransactions_Click);
            // 
            // menuItemViewGatewayBalances
            // 
            this.menuItemViewGatewayBalances.Name = "menuItemViewGatewayBalances";
            this.menuItemViewGatewayBalances.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewGatewayBalances.Text = "Gateway Balances";
            this.menuItemViewGatewayBalances.Click += new System.EventHandler(this.menuItemViewGatewayBalances_Click);
            // 
            // menuItemViewNoRippleCheck
            // 
            this.menuItemViewNoRippleCheck.Name = "menuItemViewNoRippleCheck";
            this.menuItemViewNoRippleCheck.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewNoRippleCheck.Text = "No Ripple Check";
            this.menuItemViewNoRippleCheck.Click += new System.EventHandler(this.menuItemViewNoRippleCheck_Click);
            // 
            // menuItemViewSeparator4
            // 
            this.menuItemViewSeparator4.Name = "menuItemViewSeparator4";
            this.menuItemViewSeparator4.Size = new System.Drawing.Size(216, 6);
            // 
            // menuItemViewBookOffers
            // 
            this.menuItemViewBookOffers.Name = "menuItemViewBookOffers";
            this.menuItemViewBookOffers.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewBookOffers.Text = "Book Offers";
            this.menuItemViewBookOffers.Click += new System.EventHandler(this.menuItemViewBookOffers_Click);
            // 
            // menuItemViewRipplePathFind
            // 
            this.menuItemViewRipplePathFind.Name = "menuItemViewRipplePathFind";
            this.menuItemViewRipplePathFind.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewRipplePathFind.Text = "Ripple Path Find";
            this.menuItemViewRipplePathFind.Click += new System.EventHandler(this.menuItemViewRipplePathFind_Click);
            // 
            // menuItemViewSubmit
            // 
            this.menuItemViewSubmit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewSubmitPayment,
            this.menuItemViewSubmitAccountSet,
            this.menuItemViewSubmitSetRegularKey,
            this.menuItemViewSubmitOfferCreate,
            this.menuItemViewSubmitOfferCancel,
            this.menuItemViewSubmitTrustSet});
            this.menuItemViewSubmit.Name = "menuItemViewSubmit";
            this.menuItemViewSubmit.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewSubmit.Text = "Submit";
            // 
            // menuItemViewSubmitPayment
            // 
            this.menuItemViewSubmitPayment.Name = "menuItemViewSubmitPayment";
            this.menuItemViewSubmitPayment.Size = new System.Drawing.Size(155, 22);
            this.menuItemViewSubmitPayment.Text = "Payment";
            this.menuItemViewSubmitPayment.Click += new System.EventHandler(this.menuItemViewSubmitPayment_Click);
            // 
            // menuItemViewSubmitAccountSet
            // 
            this.menuItemViewSubmitAccountSet.Name = "menuItemViewSubmitAccountSet";
            this.menuItemViewSubmitAccountSet.Size = new System.Drawing.Size(155, 22);
            this.menuItemViewSubmitAccountSet.Text = "Account Set";
            this.menuItemViewSubmitAccountSet.Click += new System.EventHandler(this.menuItemViewSubmitAccountSet_Click);
            // 
            // menuItemViewSubmitSetRegularKey
            // 
            this.menuItemViewSubmitSetRegularKey.Name = "menuItemViewSubmitSetRegularKey";
            this.menuItemViewSubmitSetRegularKey.Size = new System.Drawing.Size(155, 22);
            this.menuItemViewSubmitSetRegularKey.Text = "Set Regular Key";
            this.menuItemViewSubmitSetRegularKey.Click += new System.EventHandler(this.menuItemViewSubmitSetRegularKey_Click);
            // 
            // menuItemViewSubmitOfferCreate
            // 
            this.menuItemViewSubmitOfferCreate.Name = "menuItemViewSubmitOfferCreate";
            this.menuItemViewSubmitOfferCreate.Size = new System.Drawing.Size(155, 22);
            this.menuItemViewSubmitOfferCreate.Text = "Offer Create";
            this.menuItemViewSubmitOfferCreate.Click += new System.EventHandler(this.menuItemViewSubmitOfferCreate_Click);
            // 
            // menuItemViewSubmitOfferCancel
            // 
            this.menuItemViewSubmitOfferCancel.Name = "menuItemViewSubmitOfferCancel";
            this.menuItemViewSubmitOfferCancel.Size = new System.Drawing.Size(155, 22);
            this.menuItemViewSubmitOfferCancel.Text = "Offer Cancel";
            this.menuItemViewSubmitOfferCancel.Click += new System.EventHandler(this.menuItemViewSubmitOfferCancel_Click);
            // 
            // menuItemViewSubmitTrustSet
            // 
            this.menuItemViewSubmitTrustSet.Name = "menuItemViewSubmitTrustSet";
            this.menuItemViewSubmitTrustSet.Size = new System.Drawing.Size(155, 22);
            this.menuItemViewSubmitTrustSet.Text = "Trust Set";
            this.menuItemViewSubmitTrustSet.Click += new System.EventHandler(this.menuItemViewSubmitTrustSet_Click);
            // 
            // menuItemViewTransactionInfo
            // 
            this.menuItemViewTransactionInfo.Name = "menuItemViewTransactionInfo";
            this.menuItemViewTransactionInfo.Size = new System.Drawing.Size(219, 22);
            this.menuItemViewTransactionInfo.Text = "Transaction Info";
            this.menuItemViewTransactionInfo.Click += new System.EventHandler(this.menuItemViewTransactionInfo_Click);
            // 
            // menuItemTools
            // 
            this.menuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemToolsGenerateKeyPair});
            this.menuItemTools.Name = "menuItemTools";
            this.menuItemTools.Size = new System.Drawing.Size(48, 20);
            this.menuItemTools.Text = "&Tools";
            // 
            // menuItemToolsGenerateKeyPair
            // 
            this.menuItemToolsGenerateKeyPair.Name = "menuItemToolsGenerateKeyPair";
            this.menuItemToolsGenerateKeyPair.Size = new System.Drawing.Size(175, 22);
            this.menuItemToolsGenerateKeyPair.Text = "Generate &Key Pair...";
            this.menuItemToolsGenerateKeyPair.Click += new System.EventHandler(this.menuItemToolsGenerateKeyPair_Click);
            // 
            // menuItemWindow
            // 
            this.menuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemWindowCloseAll});
            this.menuItemWindow.Name = "menuItemWindow";
            this.menuItemWindow.Size = new System.Drawing.Size(63, 20);
            this.menuItemWindow.Text = "&Window";
            // 
            // menuItemWindowCloseAll
            // 
            this.menuItemWindowCloseAll.Name = "menuItemWindowCloseAll";
            this.menuItemWindowCloseAll.Size = new System.Drawing.Size(120, 22);
            this.menuItemWindowCloseAll.Text = "C&lose All";
            this.menuItemWindowCloseAll.Click += new System.EventHandler(this.menuItemWindowCloseAll_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHelpXrpLedgerDevPortal,
            this.menuItemHelpXrpCharts,
            this.menuItemHelpSeparator1,
            this.menuItemHelpAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "&Help";
            // 
            // menuItemHelpXrpLedgerDevPortal
            // 
            this.menuItemHelpXrpLedgerDevPortal.Name = "menuItemHelpXrpLedgerDevPortal";
            this.menuItemHelpXrpLedgerDevPortal.Size = new System.Drawing.Size(191, 22);
            this.menuItemHelpXrpLedgerDevPortal.Text = "XRP Ledger Dev Portal";
            this.menuItemHelpXrpLedgerDevPortal.Click += new System.EventHandler(this.menuItemHelpXrpLedgerDevPortal_Click);
            // 
            // menuItemHelpXrpCharts
            // 
            this.menuItemHelpXrpCharts.Name = "menuItemHelpXrpCharts";
            this.menuItemHelpXrpCharts.Size = new System.Drawing.Size(191, 22);
            this.menuItemHelpXrpCharts.Text = "XRP Charts";
            this.menuItemHelpXrpCharts.Click += new System.EventHandler(this.menuItemHelpXrpCharts_Click);
            // 
            // menuItemHelpSeparator1
            // 
            this.menuItemHelpSeparator1.Name = "menuItemHelpSeparator1";
            this.menuItemHelpSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // menuItemHelpAbout
            // 
            this.menuItemHelpAbout.Name = "menuItemHelpAbout";
            this.menuItemHelpAbout.Size = new System.Drawing.Size(191, 22);
            this.menuItemHelpAbout.Text = "&About RippleTool";
            this.menuItemHelpAbout.Click += new System.EventHandler(this.menuItemHelpAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusItemProgress,
            this.statusItemServerUri,
            this.statusItemAccountId});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusItemProgress
            // 
            this.statusItemProgress.MarqueeAnimationSpeed = 0;
            this.statusItemProgress.Name = "statusItemProgress";
            this.statusItemProgress.Size = new System.Drawing.Size(100, 18);
            this.statusItemProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // statusItemServerUri
            // 
            this.statusItemServerUri.Name = "statusItemServerUri";
            this.statusItemServerUri.Size = new System.Drawing.Size(433, 19);
            this.statusItemServerUri.Spring = true;
            this.statusItemServerUri.Text = "wss://s1.ripple.com";
            this.statusItemServerUri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusItemAccountId
            // 
            this.statusItemAccountId.Name = "statusItemAccountId";
            this.statusItemAccountId.Size = new System.Drawing.Size(234, 19);
            this.statusItemAccountId.Text = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh";
            this.statusItemAccountId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dialogOpenFile
            // 
            this.dialogOpenFile.Filter = "XML Files|*.xml|All Files|*.*";
            // 
            // dialogSaveFile
            // 
            this.dialogSaveFile.Filter = "XML Files|*.xml|All Files|*.*";
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
            this.AllowDrop = true;
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
        private System.Windows.Forms.ToolStripMenuItem menuItemFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator menuItemFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileSettings;
        private System.Windows.Forms.ToolStripSeparator menuItemFileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewRequest;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewResponse;
        private System.Windows.Forms.ToolStripSeparator menuItemViewSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewPing;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewRandom;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewRawJson;
        private System.Windows.Forms.ToolStripSeparator menuItemViewSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewFee;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewServerInfo;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewServerState;
        private System.Windows.Forms.ToolStripSeparator menuItemViewSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountCurrencies;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountInfo;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountLines;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountObjects;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountOffers;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountTransactions;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewGatewayBalances;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewNoRippleCheck;
        private System.Windows.Forms.ToolStripSeparator menuItemViewSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewBookOffers;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewRipplePathFind;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewSubmit;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewSubmitPayment;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewSubmitAccountSet;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewSubmitSetRegularKey;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewSubmitOfferCreate;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewSubmitOfferCancel;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewSubmitTrustSet;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewTransactionInfo;
        private System.Windows.Forms.ToolStripMenuItem menuItemTools;
        private System.Windows.Forms.ToolStripMenuItem menuItemToolsGenerateKeyPair;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindowCloseAll;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpXrpLedgerDevPortal;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpXrpCharts;
        private System.Windows.Forms.ToolStripSeparator menuItemHelpSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpAbout;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar statusItemProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusItemServerUri;
        private System.Windows.Forms.ToolStripStatusLabel statusItemAccountId;
        private System.Windows.Forms.OpenFileDialog dialogOpenFile;
        private System.Windows.Forms.SaveFileDialog dialogSaveFile;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private WeifenLuo.WinFormsUI.Docking.VS2012LightTheme themeVS2012Light;
    }
}