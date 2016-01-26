namespace RippleTool.UI
{
    partial class ResponseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponseForm));
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripItemRaw = new System.Windows.Forms.ToolStripButton();
            this.toolStripItemFormatted = new System.Windows.Forms.ToolStripButton();
            this.toolStripItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textDisplay
            // 
            this.textDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay.Location = new System.Drawing.Point(0, 0);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textDisplay.Size = new System.Drawing.Size(284, 237);
            this.textDisplay.TabIndex = 0;
            this.textDisplay.WordWrap = false;
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.AutoScroll = true;
            this.toolStripContainer.ContentPanel.Controls.Add(this.textDisplay);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(284, 237);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(284, 262);
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
            this.toolStripItemRaw,
            this.toolStripItemFormatted,
            this.toolStripItemSeparator1,
            this.toolStripItemClear});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(284, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // toolStripItemRaw
            // 
            this.toolStripItemRaw.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemRaw.Image")));
            this.toolStripItemRaw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemRaw.Name = "toolStripItemRaw";
            this.toolStripItemRaw.Size = new System.Drawing.Size(49, 22);
            this.toolStripItemRaw.Text = "Raw";
            this.toolStripItemRaw.Click += new System.EventHandler(this.toolStripItemRaw_Click);
            // 
            // toolStripItemFormatted
            // 
            this.toolStripItemFormatted.Checked = true;
            this.toolStripItemFormatted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripItemFormatted.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemFormatted.Image")));
            this.toolStripItemFormatted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemFormatted.Name = "toolStripItemFormatted";
            this.toolStripItemFormatted.Size = new System.Drawing.Size(82, 22);
            this.toolStripItemFormatted.Text = "Formatted";
            this.toolStripItemFormatted.Click += new System.EventHandler(this.toolStripItemFormatted_Click);
            // 
            // toolStripItemSeparator1
            // 
            this.toolStripItemSeparator1.Name = "toolStripItemSeparator1";
            this.toolStripItemSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemClear
            // 
            this.toolStripItemClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemClear.Image")));
            this.toolStripItemClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemClear.Name = "toolStripItemClear";
            this.toolStripItemClear.Size = new System.Drawing.Size(54, 22);
            this.toolStripItemClear.Text = "Clear";
            this.toolStripItemClear.Click += new System.EventHandler(this.toolStripItemClear_Click);
            // 
            // ResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStripContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ResponseForm";
            this.Text = "Response";
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

        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemRaw;
        private System.Windows.Forms.ToolStripButton toolStripItemFormatted;
        private System.Windows.Forms.ToolStripSeparator toolStripItemSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemClear;
    }
}