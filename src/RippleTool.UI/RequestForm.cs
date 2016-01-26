using System;

namespace RippleTool.UI
{
    public partial class RequestForm : DockForm
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Integration.eventCommandExecutionRequest.AddHandler(HandleEvent);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Integration.eventCommandExecutionRequest.RemoveHandler(HandleEvent);
        }

        private void HandleEvent(object sender, string value)
        {
            textDisplay.Lines = Integration.formatJson.Invoke(value).Split('\n');
        }
    }
}
