using System;

namespace RippleTool.UI
{
    public partial class RequestForm : DockForm
    {
        private string json = null;

        public RequestForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Integration.eventExecuteCommandReq.AddHandler(HandleEvent);

            json = Integration.getJsonReq();
            RenderJson();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Integration.eventExecuteCommandReq.RemoveHandler(HandleEvent);
        }

        private void RenderJson()
        {
            if (json == null)
            {
                textJson.Clear();
                return;
            }

            if (toolItemFormatted.Checked == false)
            {
                textJson.Text = json;
                return;
            }

            try
            {
                textJson.Lines = Integration.formatJson.Invoke(json).Split('\n');
            }
            catch (Exception ex)
            {
                textJson.Text = ex.ToString();
            }
        }

        private void HandleEvent(object sender, string value)
        {
            json = value;
            RenderJson();
        }

        private void toolItemFormatted_Click(object sender, EventArgs e)
        {
            toolItemFormatted.Checked = true;
            toolItemRaw.Checked = false;
            RenderJson();
        }

        private void toolItemRaw_Click(object sender, EventArgs e)
        {
            toolItemFormatted.Checked = false;
            toolItemRaw.Checked = true;
            RenderJson();
        }

        private void toolItemClear_Click(object sender, EventArgs e)
        {
            Integration.setJsonReq("");
        }
    }
}
