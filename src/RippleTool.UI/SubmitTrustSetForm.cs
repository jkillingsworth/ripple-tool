using System;

namespace RippleTool.UI
{
    public partial class SubmitTrustSetForm : DockForm
    {
        public SubmitTrustSetForm()
        {
            InitializeComponent();
            Model = new Models.SubmitTrustSetModel();
        }

        private Models.SubmitTrustSetModel Model
        {
            get { return bindingSource.DataSource as Models.SubmitTrustSetModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
