using System;

namespace RippleTool.UI
{
    public partial class SubmitAccountSetForm : DockForm
    {
        public SubmitAccountSetForm()
        {
            InitializeComponent();
            Model = new Models.SubmitAccountSetModel();
            bindingSourceSetFlagOptions.DataSource = new Models.AccountSetFlagOptions();
            bindingSourceClearFlagOptions.DataSource = new Models.AccountSetFlagOptions();
        }

        private Models.SubmitAccountSetModel Model
        {
            get { return bindingSource.DataSource as Models.SubmitAccountSetModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
