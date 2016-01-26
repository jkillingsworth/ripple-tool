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
            if (toolStripItemFormatted.Checked)
            {
                textDisplay.Lines = Integration.formatJson.Invoke(value).Split('\n');
            }
            else
            {
                textDisplay.Text = value;
            }
        }

        private void toolStripItemRaw_Click(object sender, EventArgs e)
        {
            toolStripItemRaw.Checked = true;
            toolStripItemFormatted.Checked = false;
        }

        private void toolStripItemFormatted_Click(object sender, EventArgs e)
        {
            toolStripItemRaw.Checked = false;
            toolStripItemFormatted.Checked = true;
        }

        private void toolStripItemClear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
        }
    }
}
