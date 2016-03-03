using System;

namespace RippleTool.UI
{
    public partial class PingForm : DockForm
    {
        public PingForm()
        {
            InitializeComponent();
            Model = new Models.PingModel();
        }

        private Models.PingModel Model
        {
            get { return bindingSource.DataSource as Models.PingModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
