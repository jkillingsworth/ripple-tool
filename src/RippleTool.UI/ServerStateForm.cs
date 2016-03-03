using System;

namespace RippleTool.UI
{
    public partial class ServerStateForm : DockForm
    {
        public ServerStateForm()
        {
            InitializeComponent();
            Model = new Models.ServerStateModel();
        }

        private Models.ServerStateModel Model
        {
            get { return bindingSource.DataSource as Models.ServerStateModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
