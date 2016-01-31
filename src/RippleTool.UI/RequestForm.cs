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
            if (toolItemFormatted.Checked)
            {
                textDisplay.Lines = Integration.formatJson.Invoke(value).Split('\n');
            }
            else
            {
                textDisplay.Text = value;
            }
        }

        private void toolItemFormatted_Click(object sender, EventArgs e)
        {
            toolItemFormatted.Checked = true;
            toolItemRaw.Checked = false;
        }

        private void toolItemRaw_Click(object sender, EventArgs e)
        {
            toolItemFormatted.Checked = false;
            toolItemRaw.Checked = true;
        }

        private void toolItemClear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
        }
    }
}
