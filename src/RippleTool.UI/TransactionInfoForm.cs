using System;

namespace RippleTool.UI
{
    public partial class TransactionInfoForm : DockForm
    {
        public TransactionInfoForm()
        {
            InitializeComponent();
            Model = new Models.TransactionInfoModel();
        }

        private Models.TransactionInfoModel Model
        {
            get { return bindingSource.DataSource as Models.TransactionInfoModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
