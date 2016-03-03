using System;

namespace RippleTool.UI
{
    public partial class AccountInfoForm : DockForm
    {
        public AccountInfoForm()
        {
            InitializeComponent();
            Model = new Models.AccountInfoModel();
            bindingSourceLedgerOptions.DataSource = new Models.LedgerOptions();
        }

        private Models.AccountInfoModel Model
        {
            get { return bindingSource.DataSource as Models.AccountInfoModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
