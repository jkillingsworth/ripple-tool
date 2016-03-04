using System;

namespace RippleTool.UI
{
    public partial class RawJsonForm : DockForm
    {
        public RawJsonForm()
        {
            InitializeComponent();
            Model = new Models.RawJsonModel();
        }

        private Models.RawJsonModel Model
        {
            get { return bindingSource.DataSource as Models.RawJsonModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
