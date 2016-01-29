using System;
using System.Diagnostics;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RippleTool.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            statusItemServerUri.Text = Integration.configServerUri;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Integration.eventCommandExecutionRequest.AddHandler(HandleEventRequest);
            Integration.eventCommandExecutionResponse.AddHandler(HandleEventResponse);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Integration.eventCommandExecutionRequest.RemoveHandler(HandleEventRequest);
            Integration.eventCommandExecutionResponse.RemoveHandler(HandleEventResponse);
        }

        private void HandleEventRequest(object sender, string value)
        {
            statusItemProgress.MarqueeAnimationSpeed = 1;
        }

        private void HandleEventResponse(object sender, string value)
        {
            statusItemProgress.MarqueeAnimationSpeed = 0;
            statusItemProgress.Invalidate();
        }

        private void Show(DockContent dockContent)
        {
            dockContent.Show(dockPanel);
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

        private void menuItemViewTx_Click(object sender, EventArgs e)
        {
            Show(new TxForm());
        }

        private void menuItemWindowCloseAll_Click(object sender, EventArgs e)
        {
            foreach (var form in MdiChildren)
            {
                form.Close();
            }
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
