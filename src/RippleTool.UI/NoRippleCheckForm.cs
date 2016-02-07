using System;

namespace RippleTool.UI
{
    public partial class NoRippleCheckForm : DockForm
    {
        public NoRippleCheckForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var account = textAccount.Text;
            var role = radioUser.Checked ? CommandTypes.Role.User : CommandTypes.Role.Gateway;
            var commandItem = new CommandTypes.NoRippleCheck(account, role);
            var command = CommandTypes.Command.NewNoRippleCheck(commandItem);
            Integration.executeCommand(command);
        }
    }
}
