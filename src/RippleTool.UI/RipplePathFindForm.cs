using System;

namespace RippleTool.UI
{
    public partial class RipplePathFindForm : DockForm
    {
        public RipplePathFindForm()
        {
            InitializeComponent();
            Model = new Models.RipplePathFindModel();
            bindingSourceLedgerOptions.DataSource = new Models.LedgerOptions();
        }

        private Models.RipplePathFindModel Model
        {
            get { return bindingSource.DataSource as Models.RipplePathFindModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
