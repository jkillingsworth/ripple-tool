using System;

namespace RippleTool.UI
{
    public partial class GatewayBalancesForm : DockForm
    {
        public GatewayBalancesForm()
        {
            InitializeComponent();
            Model = new Models.GatewayBalancesModel();
            bindingSourceLedgerOptions.DataSource = new Models.LedgerOptions();
        }

        private Models.GatewayBalancesModel Model
        {
            get { return bindingSource.DataSource as Models.GatewayBalancesModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
