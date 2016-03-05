using System;

namespace RippleTool.UI
{
    public partial class BookOffersForm : DockForm
    {
        public BookOffersForm()
        {
            InitializeComponent();
            Model = new Models.BookOffersModel();
            bindingSourceLedgerOptions.DataSource = new Models.LedgerOptions();
        }

        private Models.BookOffersModel Model
        {
            get { return bindingSource.DataSource as Models.BookOffersModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
