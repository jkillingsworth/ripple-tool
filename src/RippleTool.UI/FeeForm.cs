using System;

namespace RippleTool.UI
{
    public partial class FeeForm : DockForm
    {
        public FeeForm()
        {
            InitializeComponent();
            Model = new Models.FeeModel();
        }

        private Models.FeeModel Model
        {
            get { return bindingSource.DataSource as Models.FeeModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
