using System;

namespace RippleTool.UI
{
    public partial class RawForm : DockForm
    {
        public RawForm()
        {
            InitializeComponent();
            Model = new Models.RawModel();
        }

        private Models.RawModel Model
        {
            get { return bindingSource.DataSource as Models.RawModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
