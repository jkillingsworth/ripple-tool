namespace RippleTool.UI
{
    partial class ServerStateForm
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelCommandId = new System.Windows.Forms.Label();
            this.textCommandId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.ServerStateModel);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 56);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelCommandId
            // 
            this.labelCommandId.AutoSize = true;
            this.labelCommandId.Location = new System.Drawing.Point(12, 9);
            this.labelCommandId.Name = "labelCommandId";
            this.labelCommandId.Size = new System.Drawing.Size(76, 15);
            this.labelCommandId.TabIndex = 0;
            this.labelCommandId.Text = "ID (optional):";
            // 
            // textCommandId
            // 
            this.textCommandId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "CommandId", true));
            this.textCommandId.Location = new System.Drawing.Point(12, 27);
            this.textCommandId.Name = "textCommandId";
            this.textCommandId.Size = new System.Drawing.Size(260, 23);
            this.textCommandId.TabIndex = 1;
            // 
            // ServerStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 862);
            this.Controls.Add(this.textCommandId);
            this.Controls.Add(this.labelCommandId);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ServerStateForm";
            this.Text = "Server State";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelCommandId;
        private System.Windows.Forms.TextBox textCommandId;
    }
}