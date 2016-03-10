using System;

namespace RippleTool.UI
{
    public partial class SubmitSetRegularKeyForm : DockForm
    {
        public SubmitSetRegularKeyForm()
        {
            InitializeComponent();
            Model = new Models.SubmitSetRegularKeyModel();
        }

        private Models.SubmitSetRegularKeyModel Model
        {
            get { return bindingSource.DataSource as Models.SubmitSetRegularKeyModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
