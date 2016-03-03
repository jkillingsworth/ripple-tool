using System;

namespace RippleTool.UI
{
    public partial class AccountOffersForm : DockForm
    {
        public AccountOffersForm()
        {
            InitializeComponent();
            Model = new Models.AccountOffersModel();
            bindingSourceLedgerOptions.DataSource = new Models.LedgerOptions();
        }

        private Models.AccountOffersModel Model
        {
            get { return bindingSource.DataSource as Models.AccountOffersModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
