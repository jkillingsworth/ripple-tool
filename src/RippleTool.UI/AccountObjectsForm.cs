using System;

namespace RippleTool.UI
{
    public partial class AccountObjectsForm : DockForm
    {
        public AccountObjectsForm()
        {
            InitializeComponent();
            Model = new Models.AccountObjectsModel();
            bindingSourceLedgerOptions.DataSource = new Models.LedgerOptions();
        }

        private Models.AccountObjectsModel Model
        {
            get { return bindingSource.DataSource as Models.AccountObjectsModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
