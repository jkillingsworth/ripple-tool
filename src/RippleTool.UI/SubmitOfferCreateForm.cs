using System;

namespace RippleTool.UI
{
    public partial class SubmitOfferCreateForm : DockForm
    {
        public SubmitOfferCreateForm()
        {
            InitializeComponent();
            Model = new Models.SubmitOfferCreate();
        }

        private Models.SubmitOfferCreate Model
        {
            get { return bindingSource.DataSource as Models.SubmitOfferCreate; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
