using System;
using WeifenLuo.WinFormsUI.Docking;

namespace RippleTool.UI
{
    public partial class RandomForm : DockContent
    {
        public RandomForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var command = CommandTypes.Command.NewRandom(null);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
