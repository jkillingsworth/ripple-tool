using System;

namespace RippleTool.UI
{
    public partial class ResponseForm : DockForm
    {
        public ResponseForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Integration.eventCommandExecutionResponse.AddHandler(HandleEvent);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Integration.eventCommandExecutionResponse.RemoveHandler(HandleEvent);
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

        private void toolItemRaw_Click(object sender, EventArgs e)
        {
            toolItemRaw.Checked = true;
            toolItemFormatted.Checked = false;
        }

        private void toolItemFormatted_Click(object sender, EventArgs e)
        {
            toolItemRaw.Checked = false;
            toolItemFormatted.Checked = true;
        }

        private void toolItemClear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
        }
    }
}
