namespace RippleTool.UI
{
    partial class RequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textJson = new System.Windows.Forms.TextBox();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolItemFormatted = new System.Windows.Forms.ToolStripButton();
            this.toolItemRaw = new System.Windows.Forms.ToolStripButton();
            this.toolItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolItemClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textJson
            // 
            this.textJson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textJson.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJson.Location = new System.Drawing.Point(0, 0);
            this.textJson.Multiline = true;
            this.textJson.Name = "textJson";
            this.textJson.ReadOnly = true;
            this.textJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textJson.Size = new System.Drawing.Size(284, 437);
            this.textJson.TabIndex = 0;
            this.textJson.WordWrap = false;
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.AutoScroll = true;
            this.toolStripContainer.ContentPanel.Controls.Add(this.textJson);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(284, 437);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(284, 462);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolItemFormatted,
            this.toolItemRaw,
            this.toolItemSeparator1,
            this.toolItemClear});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(284, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // toolItemFormatted
            // 
            this.toolItemFormatted.Checked = true;
            this.toolItemFormatted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolItemFormatted.Image = global::RippleTool.UI.Properties.Resources.JsonFormatted;
            this.toolItemFormatted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolItemFormatted.Name = "toolItemFormatted";
            this.toolItemFormatted.Size = new System.Drawing.Size(82, 22);
            this.toolItemFormatted.Text = "Formatted";
            this.toolItemFormatted.Click += new System.EventHandler(this.toolItemFormatted_Click);
            // 
            // toolItemRaw
            // 
            this.toolItemRaw.Image = global::RippleTool.UI.Properties.Resources.JsonRaw;
            this.toolItemRaw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolItemRaw.Name = "toolItemRaw";
            this.toolItemRaw.Size = new System.Drawing.Size(49, 22);
            this.toolItemRaw.Text = "Raw";
            this.toolItemRaw.Click += new System.EventHandler(this.toolItemRaw_Click);
            // 
            // toolItemSeparator1
            // 
            this.toolItemSeparator1.Name = "toolItemSeparator1";
            this.toolItemSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolItemClear
            // 
            this.toolItemClear.Image = global::RippleTool.UI.Properties.Resources.JsonClear;
            this.toolItemClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolItemClear.Name = "toolItemClear";
            this.toolItemClear.Size = new System.Drawing.Size(54, 22);
            this.toolItemClear.Text = "Clear";
            this.toolItemClear.Click += new System.EventHandler(this.toolItemClear_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.toolStripContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RequestForm";
            this.Text = "Request";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.PerformLayout();
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textJson;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolItemFormatted;
        private System.Windows.Forms.ToolStripButton toolItemRaw;
        private System.Windows.Forms.ToolStripSeparator toolItemSeparator1;
        private System.Windows.Forms.ToolStripButton toolItemClear;
    }
}