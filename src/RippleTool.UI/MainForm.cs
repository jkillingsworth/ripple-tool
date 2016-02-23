using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RippleTool.UI
{
    public partial class MainForm : Form
    {
        private string currentFile = null;

        public MainForm()
        {
            InitializeComponent();
            InitializeDockPanel();
            statusItemServerUri.Text = Integration.Config.serverUri;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Integration.hookupEventExecuteCommandReq(HandleEventReq);
            Integration.hookupEventExecuteCommandRes(HandleEventRes);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Integration.unhookEventExecuteCommandReq(HandleEventReq);
            Integration.unhookEventExecuteCommandRes(HandleEventRes);
        }

        private static IDockContent GetDockContentInstance(string typeName)
        {
            var type = Type.GetType(typeName);
            var instance = Activator.CreateInstance(type);
            return (IDockContent)instance;
        }

        private void InitializeDockPanel()
        {
            var formReq = new RequestForm();
            var formRes = new ResponseForm();

            formReq.Show(dockPanel, DockState.DockRight);
            formRes.Show(dockPanel.Panes[0], DockAlignment.Bottom, 0.7);

            dockPanel.DockRightPortion = 0.7;
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

        private void HandleEventReq(object sender, string value)
        {
            statusItemProgress.MarqueeAnimationSpeed = 1;
        }

        private void HandleEventRes(object sender, string value)
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

        private void menuItemViewPing_Click(object sender, EventArgs e)
        {
            Show(new PingForm());
        }

        private void menuItemViewRandom_Click(object sender, EventArgs e)
        {
            Show(new RandomForm());
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

        private void menuItemViewAccountTx_Click(object sender, EventArgs e)
        {
            Show(new AccountTxForm());
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

        private void menuItemViewSubmitTrustSet_Click(object sender, EventArgs e)
        {
            Show(new SubmitTrustSetForm());
        }

        private void menuItemViewTx_Click(object sender, EventArgs e)
        {
            Show(new TxForm());
        }

        private void menuItemWindowCloseAll_Click(object sender, EventArgs e)
        {
            CloseAllDocuments();
        }

        private void menuItemHelpDeveloperCenter_Click(object sender, EventArgs e)
        {
            Process.Start("https://ripple.com/build/");
        }

        private void menuItemHelpKnowledgeCenter_Click(object sender, EventArgs e)
        {
            Process.Start("https://ripple.com/learn/");
        }

        private void menuItemHelpAbout_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }
    }
}
