using System;

namespace RippleTool.UI
{
    public partial class RandomForm : DockForm
    {
        public RandomForm()
        {
            InitializeComponent();
            Model = new Models.RandomModel();
        }

        private Models.RandomModel Model
        {
            get { return bindingSource.DataSource as Models.RandomModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.Submit();
        }
    }
}
