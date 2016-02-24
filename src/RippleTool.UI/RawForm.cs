using System;

namespace RippleTool.UI
{
    public partial class RawForm : DockForm
    {
        public RawForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var command = textJson.Text;
            Integration.executeRawJson(command);
        }
    }
}
