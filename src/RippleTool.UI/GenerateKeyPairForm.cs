using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class GenerateKeyPairForm : Form
    {
        public GenerateKeyPairForm()
        {
            InitializeComponent();
            Model = new Models.GenerateKeyPairModel();
        }

        private Models.GenerateKeyPairModel Model
        {
            get { return bindingSource.DataSource as Models.GenerateKeyPairModel; }
            set { bindingSource.DataSource = value; }
        }

        private void buttonGenerate_Click(object sender, System.EventArgs e)
        {
            Model.Generate();
        }

        private void buttonReset_Click(object sender, System.EventArgs e)
        {
            Model.Reset();
        }
    }
}
