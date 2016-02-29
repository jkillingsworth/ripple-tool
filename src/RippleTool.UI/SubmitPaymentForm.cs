using System;

namespace RippleTool.UI
{
    public partial class SubmitPaymentForm : DockForm
    {
        public SubmitPaymentForm()
        {
            InitializeComponent();
            Model = new Models.SubmitPaymentModel();
        }

        private Models.SubmitPaymentModel Model
        {
            get { return bindingSource.DataSource as Models.SubmitPaymentModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
