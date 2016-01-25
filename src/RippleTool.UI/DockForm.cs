using System;
using WeifenLuo.WinFormsUI.Docking;

namespace RippleTool.UI
{
    public partial class DockForm : DockContent
    {
        public DockForm()
        {
            InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Font = DockPanel.Font;
        }
    }
}
