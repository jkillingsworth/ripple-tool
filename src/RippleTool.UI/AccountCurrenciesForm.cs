using System;

namespace RippleTool.UI
{
    public partial class AccountCurrenciesForm : DockForm
    {
        public AccountCurrenciesForm()
        {
            InitializeComponent();
            Model = new Models.AccountCurrenciesModel();
            bindingSourceLedgerOptions.DataSource = new Models.LedgerOptions();
        }

        private Models.AccountCurrenciesModel Model
        {
            get { return bindingSource.DataSource as Models.AccountCurrenciesModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
