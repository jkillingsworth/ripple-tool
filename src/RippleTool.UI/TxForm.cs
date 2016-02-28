using System;

namespace RippleTool.UI
{
    public partial class TxForm : DockForm
    {
        public TxForm()
        {
            InitializeComponent();
            Model = new Models.TxModel();
        }

        private Models.TxModel Model
        {
            get { return bindingSource.DataSource as Models.TxModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
