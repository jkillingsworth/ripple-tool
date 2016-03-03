using System;

namespace RippleTool.UI
{
    public partial class AccountLinesForm : DockForm
    {
        public AccountLinesForm()
        {
            InitializeComponent();
            Model = new Models.AccountLinesModel();
            bindingSourceLedgerOptions.DataSource = new Models.LedgerOptions();
        }

        private Models.AccountLinesModel Model
        {
            get { return bindingSource.DataSource as Models.AccountLinesModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
