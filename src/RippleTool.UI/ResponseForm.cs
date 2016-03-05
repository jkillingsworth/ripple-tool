using System;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class ResponseForm : DockForm
    {
        private IDisposable eventExecuteCommandRes;
        private string json = null;

        public ResponseForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            eventExecuteCommandRes = Integration.hookupEventExecuteCommandRes(HandleEvent);

            json = Integration.getJsonRes();
            RenderJson();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnClosed(e);
            eventExecuteCommandRes.Dispose();
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

        private void HandleEvent(string value)
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
            Integration.setJsonRes(null);
        }
    }
}
