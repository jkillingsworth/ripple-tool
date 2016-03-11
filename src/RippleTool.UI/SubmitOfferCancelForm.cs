using System;

namespace RippleTool.UI
{
    public partial class SubmitOfferCancelForm : DockForm
    {
        public SubmitOfferCancelForm()
        {
            InitializeComponent();
            Model = new Models.SubmitOfferCancel();
        }

        private Models.SubmitOfferCancel Model
        {
            get { return bindingSource.DataSource as Models.SubmitOfferCancel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
