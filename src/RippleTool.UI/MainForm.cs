using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RippleTool.UI
{
    public partial class MainForm : Form
    {
        private IDisposable eventExecuteCommandException;
        private IDisposable eventExecuteCommandBeginning;
        private IDisposable eventExecuteCommandFinishing;
        private string currentFile = null;

        public MainForm()
        {
            InitializeComponent();
            InitializeDockPanel();
            statusItemServerUri.Text = Config.serverUri;
            statusItemAccountId.Text = Config.accountId;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            eventExecuteCommandException = Integration.hookupEventExecuteCommandException(HandleEventException);
            eventExecuteCommandBeginning = Integration.hookupEventExecuteCommandBeginning(HandleEventBeginning);
            eventExecuteCommandFinishing = Integration.hookupEventExecuteCommandFinishing(HandleEventFinishing);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnClosed(e);
            eventExecuteCommandException.Dispose();
            eventExecuteCommandBeginning.Dispose();
            eventExecuteCommandFinishing.Dispose();
        }

        protected override void OnDragEnter(DragEventArgs e)
        {
            base.OnDragEnter(e);

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            base.OnDragDrop(e);

            CloseAllDocuments();
            CloseAllPanes();

            var fileList = e.Data.GetData(DataFormats.FileDrop) as string[];
            var fileName = fileList[0];
            var deserializer = new DeserializeDockContent(GetDockContentInstance);
            dockPanel.LoadFromXml(fileName, deserializer);
            currentFile = fileName;
        }

        private static IDockContent GetDockContentInstance(string typeName)
        {
            var type = Type.GetType(typeName);
            var instance = Activator.CreateInstance(type);
            return (IDockContent)instance;
        }

        private void InitializeDockPanel()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(GetType(), "MainFormLayout.xml"))
            {
                var deserializer = new DeserializeDockContent(GetDockContentInstance);
                dockPanel.LoadFromXml(stream, deserializer);
            }
        }

        private void CloseAllDocuments()
        {
            foreach (var form in MdiChildren)
            {
                form.Close();
            }
        }

        private void CloseAllPanes()
        {
            foreach (var pane in dockPanel.Panes.ToList())
            {
                pane.CloseActiveContent();
            }
        }

        private void PromptFileOpen()
        {
            var result = dialogOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                CloseAllDocuments();
                CloseAllPanes();

                using (var stream = dialogOpenFile.OpenFile())
                {
                    var deserializer = new DeserializeDockContent(GetDockContentInstance);
                    dockPanel.LoadFromXml(stream, deserializer);
                }

                currentFile = dialogOpenFile.FileName;
            }
        }

        private void PromptFileSave()
        {
            var result = dialogSaveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (var stream = dialogSaveFile.OpenFile())
                {
                    dockPanel.SaveAsXml(stream, System.Text.Encoding.UTF8);
                }

                currentFile = dialogSaveFile.FileName;
            }
        }

        private void Show(DockContent dockContent)
        {
            dockContent.Show(dockPanel);
        }

        private void HandleEventException(Exception ex)
        {
            throw new Exception("An error occurred.", ex);
        }

        private void HandleEventBeginning(object obj)
        {
            statusItemProgress.MarqueeAnimationSpeed = 1;
        }

        private void HandleEventFinishing(object obj)
        {
            statusItemProgress.MarqueeAnimationSpeed = 0;
            statusItemProgress.Invalidate();
        }

        private void menuStrip_MenuActivate(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0)
            {
                menuItemWindowCloseAll.Enabled = false;

                var index = menuItemWindow.DropDownItems.Count - 1;
                var items = menuItemWindow.DropDownItems;
                if (items[index] is ToolStripSeparator)
                {
                    items.RemoveAt(index);
                }
            }
            else
            {
                menuItemWindowCloseAll.Enabled = true;
            }
        }

        private void menuItemFileNew_Click(object sender, EventArgs e)
        {
            CloseAllDocuments();
            CloseAllPanes();

            currentFile = null;
        }

        private void menuItemFileOpen_Click(object sender, EventArgs e)
        {
            PromptFileOpen();
        }

        private void menuItemFileSave_Click(object sender, EventArgs e)
        {
            if (currentFile != null)
            {
                dockPanel.SaveAsXml(currentFile, System.Text.Encoding.UTF8);
                return;
            }

            PromptFileSave();
        }

        private void menuItemFileSaveAs_Click(object sender, EventArgs e)
        {
            PromptFileSave();
        }

        private void menuItemFileSettings_Click(object sender, EventArgs e)
        {
            var form = new SettingsForm();
            form.ShowDialog();
        }

        private void menuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemViewRequest_Click(object sender, EventArgs e)
        {
            Show(new RequestForm());
        }

        private void menuItemViewResponse_Click(object sender, EventArgs e)
        {
            Show(new ResponseForm());
        }

        private void menuItemViewRawJson_Click(object sender, EventArgs e)
        {
            Show(new RawJsonForm());
        }

        private void menuItemViewPing_Click(object sender, EventArgs e)
        {
            Show(new PingForm());
        }

        private void menuItemViewRandom_Click(object sender, EventArgs e)
        {
            Show(new RandomForm());
        }

        private void menuItemViewServerInfo_Click(object sender, EventArgs e)
        {
            Show(new ServerInfoForm());
        }

        private void menuItemViewServerState_Click(object sender, EventArgs e)
        {
            Show(new ServerStateForm());
        }

        private void menuItemViewAccountCurrencies_Click(object sender, EventArgs e)
        {
            Show(new AccountCurrenciesForm());
        }

        private void menuItemViewAccountInfo_Click(object sender, EventArgs e)
        {
            Show(new AccountInfoForm());
        }

        private void menuItemViewAccountLines_Click(object sender, EventArgs e)
        {
            Show(new AccountLinesForm());
        }

        private void menuItemViewAccountObjects_Click(object sender, EventArgs e)
        {
            Show(new AccountObjectsForm());
        }

        private void menuItemViewAccountOffers_Click(object sender, EventArgs e)
        {
            Show(new AccountOffersForm());
        }

        private void menuItemViewAccountTransactions_Click(object sender, EventArgs e)
        {
            Show(new AccountTransactionsForm());
        }

        private void menuItemViewGatewayBalances_Click(object sender, EventArgs e)
        {
            Show(new GatewayBalancesForm());
        }

        private void menuItemViewNoRippleCheck_Click(object sender, EventArgs e)
        {
            Show(new NoRippleCheckForm());
        }

        private void menuItemViewBookOffers_Click(object sender, EventArgs e)
        {
            Show(new BookOffersForm());
        }

        private void menuItemViewRipplePathFind_Click(object sender, EventArgs e)
        {
            Show(new RipplePathFindForm());
        }

        private void menuItemViewSubmitPayment_Click(object sender, EventArgs e)
        {
            Show(new SubmitPaymentForm());
        }

        private void menuItemViewSubmitAccountSet_Click(object sender, EventArgs e)
        {
            Show(new SubmitAccountSetForm());
        }

        private void menuItemViewSubmitSetRegularKey_Click(object sender, EventArgs e)
        {
            Show(new SubmitSetRegularKeyForm());
        }

        private void menuItemViewSubmitOfferCreate_Click(object sender, EventArgs e)
        {
            Show(new SubmitOfferCreateForm());
        }

        private void menuItemViewSubmitOfferCancel_Click(object sender, EventArgs e)
        {
            Show(new SubmitOfferCancelForm());
        }

        private void menuItemViewSubmitTrustSet_Click(object sender, EventArgs e)
        {
            Show(new SubmitTrustSetForm());
        }

        private void menuItemViewTransactionInfo_Click(object sender, EventArgs e)
        {
            Show(new TransactionInfoForm());
        }

        private void menuItemToolsGenerateKeyPair_Click(object sender, EventArgs e)
        {
            var form = new GenerateKeyPairForm();
            form.ShowDialog();
        }

        private void menuItemWindowCloseAll_Click(object sender, EventArgs e)
        {
            CloseAllDocuments();
        }

        private void menuItemHelpXrpLedgerDevPortal_Click(object sender, EventArgs e)
        {
            Process.Start("https://xrpl.org/");
        }

        private void menuItemHelpXrpCharts_Click(object sender, EventArgs e)
        {
            Process.Start("https://xrpcharts.ripple.com/#/");
        }

        private void menuItemHelpAbout_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }
    }
}
