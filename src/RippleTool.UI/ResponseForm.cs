﻿using System;

namespace RippleTool.UI
{
    public partial class ResponseForm : WeifenLuo.WinFormsUI.Docking.DockContent
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
            textDisplay.Text = value;
        }
    }
}
