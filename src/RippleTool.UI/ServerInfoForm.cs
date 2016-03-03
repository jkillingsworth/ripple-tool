using System;

namespace RippleTool.UI
{
    public partial class ServerInfoForm : DockForm
    {
        public ServerInfoForm()
        {
            InitializeComponent();
            Model = new Models.ServerInfoModel();
        }

        private Models.ServerInfoModel Model
        {
            get { return bindingSource.DataSource as Models.ServerInfoModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
