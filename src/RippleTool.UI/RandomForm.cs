using System;

namespace RippleTool.UI
{
    public partial class RandomForm : DockForm
    {
        public RandomForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var command = CommandTypes.Command.NewRandom(null);
            Integration.executeCommand(command);
        }
    }
}
