using System;

namespace RippleTool.UI
{
    public partial class AccountTransactionsForm : DockForm
    {
        public AccountTransactionsForm()
        {
            InitializeComponent();
            Model = new Models.AccountTransactionsModel();
        }

        private Models.AccountTransactionsModel Model
        {
            get { return bindingSource.DataSource as Models.AccountTransactionsModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
