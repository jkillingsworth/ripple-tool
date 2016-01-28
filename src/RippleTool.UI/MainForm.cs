using System;
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

        private void menuItemViewAccountOffers_Click(object sender, EventArgs e)
        {
            Show(new AccountOffersForm());
        }

        private void menuItemViewAccountObjects_Click(object sender, EventArgs e)
        {
            Show(new AccountObjectsForm());
        }

        private void menuItemViewAccountTx_Click(object sender, EventArgs e)
        {
            Show(new AccountTxForm());
        }

        private void menuItemViewNoRippleCheck_Click(object sender, EventArgs e)
        {
            Show(new NoRippleCheckForm());
        }

        private void menuItemViewGatewayBalances_Click(object sender, EventArgs e)
        {
            Show(new GatewayBalancesForm());
        }
    }
}
