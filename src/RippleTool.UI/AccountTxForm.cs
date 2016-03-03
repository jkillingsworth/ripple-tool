using System;

namespace RippleTool.UI
{
    public partial class AccountTxForm : DockForm
    {
        public AccountTxForm()
        {
            InitializeComponent();
            Model = new Models.AccountTxModel();
        }

        private Models.AccountTxModel Model
        {
            get { return bindingSource.DataSource as Models.AccountTxModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
