using System;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class RequestForm : DockForm
    {
        private IDisposable eventExecuteCommandReq;
        private string json = null;

        public RequestForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            eventExecuteCommandReq = Integration.hookupEventExecuteCommandReq(HandleEvent);

            json = Integration.getJsonReq();
            RenderJson();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnClosed(e);
            eventExecuteCommandReq.Dispose();
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
            Integration.setJsonReq(null);
        }
    }
}
