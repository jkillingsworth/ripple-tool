using System;

namespace RippleTool.UI
{
    public partial class NoRippleCheckForm : DockForm
    {
        public NoRippleCheckForm()
        {
            InitializeComponent();
            Model = new Models.NoRippleCheckModel();
            bindingSourceLedgerOptions.DataSource = new Models.LedgerOptions();
        }

        private Models.NoRippleCheckModel Model
        {
            get { return bindingSource.DataSource as Models.NoRippleCheckModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
