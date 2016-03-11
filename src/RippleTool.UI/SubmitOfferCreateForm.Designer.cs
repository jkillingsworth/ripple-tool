namespace RippleTool.UI
{
    partial class SubmitOfferCreateForm
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
            this.labelAccount = new System.Windows.Forms.Label();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.labelFee = new System.Windows.Forms.Label();
            this.textFee = new System.Windows.Forms.TextBox();
            this.labelSequence = new System.Windows.Forms.Label();
            this.textSequence = new System.Windows.Forms.TextBox();
            this.labelLastLedgerSequence = new System.Windows.Forms.Label();
            this.textLastLedgerSequence = new System.Windows.Forms.TextBox();
            this.groupFlags = new System.Windows.Forms.GroupBox();
            this.checkFullyCanonicalSig = new System.Windows.Forms.CheckBox();
            this.checkPassive = new System.Windows.Forms.CheckBox();
            this.checkImmediateOrCancel = new System.Windows.Forms.CheckBox();
            this.checkFillOrKill = new System.Windows.Forms.CheckBox();
            this.checkSell = new System.Windows.Forms.CheckBox();
            this.labelOfferSequence = new System.Windows.Forms.Label();
            this.textOfferSequence = new System.Windows.Forms.TextBox();
            this.labelExpiration = new System.Windows.Forms.Label();
            this.textExpiration = new System.Windows.Forms.TextBox();
            this.groupTakerGets = new System.Windows.Forms.GroupBox();
            this.radioTakerGetsIsIssued = new System.Windows.Forms.RadioButton();
            this.radioTakerGetsIsNative = new System.Windows.Forms.RadioButton();
            this.labelTakerGetsValue = new System.Windows.Forms.Label();
            this.textTakerGetsValue = new System.Windows.Forms.TextBox();
            this.labelTakerGetsCurrency = new System.Windows.Forms.Label();
            this.textTakerGetsCurrency = new System.Windows.Forms.TextBox();
            this.labelTakerGetsIssuer = new System.Windows.Forms.Label();
            this.textTakerGetsIssuer = new System.Windows.Forms.TextBox();
            this.groupTakerPays = new System.Windows.Forms.GroupBox();
            this.radioTakerPaysIsIssued = new System.Windows.Forms.RadioButton();
            this.radioTakerPaysIsNative = new System.Windows.Forms.RadioButton();
            this.labelTakerPaysValue = new System.Windows.Forms.Label();
            this.textTakerPaysValue = new System.Windows.Forms.TextBox();
            this.labelTakerPaysCurrency = new System.Windows.Forms.Label();
            this.textTakerPaysCurrency = new System.Windows.Forms.TextBox();
            this.labelTakerPaysIssuer = new System.Windows.Forms.Label();
            this.textTakerPaysIssuer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.groupFlags.SuspendLayout();
            this.groupTakerGets.SuspendLayout();
            this.groupTakerPays.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.SubmitOfferCreate);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 808);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 27;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(12, 9);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(55, 15);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "Account:";
            // 
            // textAccount
            // 
            this.textAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Account", true));
            this.textAccount.Location = new System.Drawing.Point(12, 27);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(260, 23);
            this.textAccount.TabIndex = 1;
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(12, 53);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(28, 15);
            this.labelFee.TabIndex = 2;
            this.labelFee.Text = "Fee:";
            // 
            // textFee
            // 
            this.textFee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Fee", true));
            this.textFee.Location = new System.Drawing.Point(12, 71);
            this.textFee.Name = "textFee";
            this.textFee.Size = new System.Drawing.Size(260, 23);
            this.textFee.TabIndex = 3;
            // 
            // labelSequence
            // 
            this.labelSequence.AutoSize = true;
            this.labelSequence.Location = new System.Drawing.Point(12, 97);
            this.labelSequence.Name = "labelSequence";
            this.labelSequence.Size = new System.Drawing.Size(61, 15);
            this.labelSequence.TabIndex = 4;
            this.labelSequence.Text = "Sequence:";
            // 
            // textSequence
            // 
            this.textSequence.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Sequence", true));
            this.textSequence.Location = new System.Drawing.Point(12, 115);
            this.textSequence.Name = "textSequence";
            this.textSequence.Size = new System.Drawing.Size(260, 23);
            this.textSequence.TabIndex = 5;
            // 
            // labelLastLedgerSequence
            // 
            this.labelLastLedgerSequence.AutoSize = true;
            this.labelLastLedgerSequence.Location = new System.Drawing.Point(12, 141);
            this.labelLastLedgerSequence.Name = "labelLastLedgerSequence";
            this.labelLastLedgerSequence.Size = new System.Drawing.Size(175, 15);
            this.labelLastLedgerSequence.TabIndex = 6;
            this.labelLastLedgerSequence.Text = "Last ledger sequence (optional):";
            // 
            // textLastLedgerSequence
            // 
            this.textLastLedgerSequence.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "LastLedgerSequence", true));
            this.textLastLedgerSequence.Location = new System.Drawing.Point(12, 159);
            this.textLastLedgerSequence.Name = "textLastLedgerSequence";
            this.textLastLedgerSequence.Size = new System.Drawing.Size(260, 23);
            this.textLastLedgerSequence.TabIndex = 7;
            // 
            // groupFlags
            // 
            this.groupFlags.Controls.Add(this.checkFullyCanonicalSig);
            this.groupFlags.Controls.Add(this.checkPassive);
            this.groupFlags.Controls.Add(this.checkImmediateOrCancel);
            this.groupFlags.Controls.Add(this.checkFillOrKill);
            this.groupFlags.Controls.Add(this.checkSell);
            this.groupFlags.Location = new System.Drawing.Point(12, 188);
            this.groupFlags.Name = "groupFlags";
            this.groupFlags.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupFlags.Size = new System.Drawing.Size(260, 150);
            this.groupFlags.TabIndex = 8;
            this.groupFlags.TabStop = false;
            this.groupFlags.Text = "Flags";
            // 
            // checkFullyCanonicalSig
            // 
            this.checkFullyCanonicalSig.AutoSize = true;
            this.checkFullyCanonicalSig.Checked = true;
            this.checkFullyCanonicalSig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFullyCanonicalSig.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagFullyCanonicalSig", true));
            this.checkFullyCanonicalSig.Location = new System.Drawing.Point(9, 22);
            this.checkFullyCanonicalSig.Name = "checkFullyCanonicalSig";
            this.checkFullyCanonicalSig.Size = new System.Drawing.Size(157, 19);
            this.checkFullyCanonicalSig.TabIndex = 0;
            this.checkFullyCanonicalSig.Text = "Fully canonical signature";
            this.checkFullyCanonicalSig.UseVisualStyleBackColor = true;
            // 
            // checkPassive
            // 
            this.checkPassive.AutoSize = true;
            this.checkPassive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagPassive", true));
            this.checkPassive.Location = new System.Drawing.Point(9, 47);
            this.checkPassive.Name = "checkPassive";
            this.checkPassive.Size = new System.Drawing.Size(64, 19);
            this.checkPassive.TabIndex = 1;
            this.checkPassive.Text = "Passive";
            this.checkPassive.UseVisualStyleBackColor = true;
            // 
            // checkImmediateOrCancel
            // 
            this.checkImmediateOrCancel.AutoSize = true;
            this.checkImmediateOrCancel.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagImmediateOrCancel", true));
            this.checkImmediateOrCancel.Location = new System.Drawing.Point(9, 72);
            this.checkImmediateOrCancel.Name = "checkImmediateOrCancel";
            this.checkImmediateOrCancel.Size = new System.Drawing.Size(134, 19);
            this.checkImmediateOrCancel.TabIndex = 2;
            this.checkImmediateOrCancel.Text = "Immediate or cancel";
            this.checkImmediateOrCancel.UseVisualStyleBackColor = true;
            // 
            // checkFillOrKill
            // 
            this.checkFillOrKill.AutoSize = true;
            this.checkFillOrKill.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagFillOrKill", true));
            this.checkFillOrKill.Location = new System.Drawing.Point(9, 97);
            this.checkFillOrKill.Name = "checkFillOrKill";
            this.checkFillOrKill.Size = new System.Drawing.Size(73, 19);
            this.checkFillOrKill.TabIndex = 3;
            this.checkFillOrKill.Text = "Fill or kill";
            this.checkFillOrKill.UseVisualStyleBackColor = true;
            // 
            // checkSell
            // 
            this.checkSell.AutoSize = true;
            this.checkSell.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagSell", true));
            this.checkSell.Location = new System.Drawing.Point(9, 122);
            this.checkSell.Name = "checkSell";
            this.checkSell.Size = new System.Drawing.Size(44, 19);
            this.checkSell.TabIndex = 4;
            this.checkSell.Text = "Sell";
            this.checkSell.UseVisualStyleBackColor = true;
            // 
            // labelOfferSequence
            // 
            this.labelOfferSequence.AutoSize = true;
            this.labelOfferSequence.Location = new System.Drawing.Point(12, 341);
            this.labelOfferSequence.Name = "labelOfferSequence";
            this.labelOfferSequence.Size = new System.Drawing.Size(145, 15);
            this.labelOfferSequence.TabIndex = 9;
            this.labelOfferSequence.Text = "Offer sequence (optional):";
            // 
            // textOfferSequence
            // 
            this.textOfferSequence.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "OfferSequence", true));
            this.textOfferSequence.Location = new System.Drawing.Point(12, 359);
            this.textOfferSequence.Name = "textOfferSequence";
            this.textOfferSequence.Size = new System.Drawing.Size(260, 23);
            this.textOfferSequence.TabIndex = 10;
            // 
            // labelExpiration
            // 
            this.labelExpiration.AutoSize = true;
            this.labelExpiration.Location = new System.Drawing.Point(12, 385);
            this.labelExpiration.Name = "labelExpiration";
            this.labelExpiration.Size = new System.Drawing.Size(117, 15);
            this.labelExpiration.TabIndex = 11;
            this.labelExpiration.Text = "Expiration (optional):";
            // 
            // textExpiration
            // 
            this.textExpiration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Expiration", true));
            this.textExpiration.Location = new System.Drawing.Point(12, 403);
            this.textExpiration.Name = "textExpiration";
            this.textExpiration.Size = new System.Drawing.Size(260, 23);
            this.textExpiration.TabIndex = 12;
            // 
            // groupTakerGets
            // 
            this.groupTakerGets.Controls.Add(this.radioTakerGetsIsIssued);
            this.groupTakerGets.Controls.Add(this.radioTakerGetsIsNative);
            this.groupTakerGets.Location = new System.Drawing.Point(12, 432);
            this.groupTakerGets.Name = "groupTakerGets";
            this.groupTakerGets.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupTakerGets.Size = new System.Drawing.Size(260, 50);
            this.groupTakerGets.TabIndex = 13;
            this.groupTakerGets.TabStop = false;
            this.groupTakerGets.Text = "Taker gets";
            // 
            // radioTakerGetsIsIssued
            // 
            this.radioTakerGetsIsIssued.AutoSize = true;
            this.radioTakerGetsIsIssued.Checked = true;
            this.radioTakerGetsIsIssued.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "TakerGetsIsIssued", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioTakerGetsIsIssued.Location = new System.Drawing.Point(9, 22);
            this.radioTakerGetsIsIssued.Name = "radioTakerGetsIsIssued";
            this.radioTakerGetsIsIssued.Size = new System.Drawing.Size(58, 19);
            this.radioTakerGetsIsIssued.TabIndex = 0;
            this.radioTakerGetsIsIssued.TabStop = true;
            this.radioTakerGetsIsIssued.Text = "Issued";
            this.radioTakerGetsIsIssued.UseVisualStyleBackColor = true;
            // 
            // radioTakerGetsIsNative
            // 
            this.radioTakerGetsIsNative.AutoSize = true;
            this.radioTakerGetsIsNative.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "TakerGetsIsNative", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioTakerGetsIsNative.Location = new System.Drawing.Point(73, 22);
            this.radioTakerGetsIsNative.Name = "radioTakerGetsIsNative";
            this.radioTakerGetsIsNative.Size = new System.Drawing.Size(59, 19);
            this.radioTakerGetsIsNative.TabIndex = 1;
            this.radioTakerGetsIsNative.Text = "Native";
            this.radioTakerGetsIsNative.UseVisualStyleBackColor = true;
            // 
            // labelTakerGetsValue
            // 
            this.labelTakerGetsValue.AutoSize = true;
            this.labelTakerGetsValue.Location = new System.Drawing.Point(12, 485);
            this.labelTakerGetsValue.Name = "labelTakerGetsValue";
            this.labelTakerGetsValue.Size = new System.Drawing.Size(95, 15);
            this.labelTakerGetsValue.TabIndex = 14;
            this.labelTakerGetsValue.Text = "Taker gets value:";
            // 
            // textTakerGetsValue
            // 
            this.textTakerGetsValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TakerGetsValue", true));
            this.textTakerGetsValue.Location = new System.Drawing.Point(12, 503);
            this.textTakerGetsValue.Name = "textTakerGetsValue";
            this.textTakerGetsValue.Size = new System.Drawing.Size(260, 23);
            this.textTakerGetsValue.TabIndex = 15;
            // 
            // labelTakerGetsCurrency
            // 
            this.labelTakerGetsCurrency.AutoSize = true;
            this.labelTakerGetsCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "TakerGetsIsIssued", true));
            this.labelTakerGetsCurrency.Location = new System.Drawing.Point(12, 529);
            this.labelTakerGetsCurrency.Name = "labelTakerGetsCurrency";
            this.labelTakerGetsCurrency.Size = new System.Drawing.Size(113, 15);
            this.labelTakerGetsCurrency.TabIndex = 16;
            this.labelTakerGetsCurrency.Text = "Taker gets currency:";
            // 
            // textTakerGetsCurrency
            // 
            this.textTakerGetsCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TakerGetsCurrency", true));
            this.textTakerGetsCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "TakerGetsIsIssued", true));
            this.textTakerGetsCurrency.Location = new System.Drawing.Point(12, 547);
            this.textTakerGetsCurrency.Name = "textTakerGetsCurrency";
            this.textTakerGetsCurrency.Size = new System.Drawing.Size(260, 23);
            this.textTakerGetsCurrency.TabIndex = 17;
            // 
            // labelTakerGetsIssuer
            // 
            this.labelTakerGetsIssuer.AutoSize = true;
            this.labelTakerGetsIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "TakerGetsIsIssued", true));
            this.labelTakerGetsIssuer.Location = new System.Drawing.Point(12, 573);
            this.labelTakerGetsIssuer.Name = "labelTakerGetsIssuer";
            this.labelTakerGetsIssuer.Size = new System.Drawing.Size(97, 15);
            this.labelTakerGetsIssuer.TabIndex = 18;
            this.labelTakerGetsIssuer.Text = "Taker gets issuer:";
            // 
            // textTakerGetsIssuer
            // 
            this.textTakerGetsIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TakerGetsIssuer", true));
            this.textTakerGetsIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "TakerGetsIsIssued", true));
            this.textTakerGetsIssuer.Location = new System.Drawing.Point(12, 591);
            this.textTakerGetsIssuer.Name = "textTakerGetsIssuer";
            this.textTakerGetsIssuer.Size = new System.Drawing.Size(260, 23);
            this.textTakerGetsIssuer.TabIndex = 19;
            // 
            // groupTakerPays
            // 
            this.groupTakerPays.Controls.Add(this.radioTakerPaysIsIssued);
            this.groupTakerPays.Controls.Add(this.radioTakerPaysIsNative);
            this.groupTakerPays.Location = new System.Drawing.Point(12, 620);
            this.groupTakerPays.Name = "groupTakerPays";
            this.groupTakerPays.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupTakerPays.Size = new System.Drawing.Size(260, 50);
            this.groupTakerPays.TabIndex = 20;
            this.groupTakerPays.TabStop = false;
            this.groupTakerPays.Text = "Taker pays";
            // 
            // radioTakerPaysIsIssued
            // 
            this.radioTakerPaysIsIssued.AutoSize = true;
            this.radioTakerPaysIsIssued.Checked = true;
            this.radioTakerPaysIsIssued.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "TakerPaysIsIssued", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioTakerPaysIsIssued.Location = new System.Drawing.Point(9, 22);
            this.radioTakerPaysIsIssued.Name = "radioTakerPaysIsIssued";
            this.radioTakerPaysIsIssued.Size = new System.Drawing.Size(58, 19);
            this.radioTakerPaysIsIssued.TabIndex = 0;
            this.radioTakerPaysIsIssued.TabStop = true;
            this.radioTakerPaysIsIssued.Text = "Issued";
            this.radioTakerPaysIsIssued.UseVisualStyleBackColor = true;
            // 
            // radioTakerPaysIsNative
            // 
            this.radioTakerPaysIsNative.AutoSize = true;
            this.radioTakerPaysIsNative.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "TakerPaysIsNative", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioTakerPaysIsNative.Location = new System.Drawing.Point(73, 22);
            this.radioTakerPaysIsNative.Name = "radioTakerPaysIsNative";
            this.radioTakerPaysIsNative.Size = new System.Drawing.Size(59, 19);
            this.radioTakerPaysIsNative.TabIndex = 1;
            this.radioTakerPaysIsNative.Text = "Native";
            this.radioTakerPaysIsNative.UseVisualStyleBackColor = true;
            // 
            // labelTakerPaysValue
            // 
            this.labelTakerPaysValue.AutoSize = true;
            this.labelTakerPaysValue.Location = new System.Drawing.Point(12, 673);
            this.labelTakerPaysValue.Name = "labelTakerPaysValue";
            this.labelTakerPaysValue.Size = new System.Drawing.Size(97, 15);
            this.labelTakerPaysValue.TabIndex = 21;
            this.labelTakerPaysValue.Text = "Taker pays value:";
            // 
            // textTakerPaysValue
            // 
            this.textTakerPaysValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TakerPaysValue", true));
            this.textTakerPaysValue.Location = new System.Drawing.Point(12, 691);
            this.textTakerPaysValue.Name = "textTakerPaysValue";
            this.textTakerPaysValue.Size = new System.Drawing.Size(260, 23);
            this.textTakerPaysValue.TabIndex = 22;
            // 
            // labelTakerPaysCurrency
            // 
            this.labelTakerPaysCurrency.AutoSize = true;
            this.labelTakerPaysCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "TakerPaysIsIssued", true));
            this.labelTakerPaysCurrency.Location = new System.Drawing.Point(12, 717);
            this.labelTakerPaysCurrency.Name = "labelTakerPaysCurrency";
            this.labelTakerPaysCurrency.Size = new System.Drawing.Size(115, 15);
            this.labelTakerPaysCurrency.TabIndex = 23;
            this.labelTakerPaysCurrency.Text = "Taker pays currency:";
            // 
            // textTakerPaysCurrency
            // 
            this.textTakerPaysCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TakerPaysCurrency", true));
            this.textTakerPaysCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "TakerPaysIsIssued", true));
            this.textTakerPaysCurrency.Location = new System.Drawing.Point(12, 735);
            this.textTakerPaysCurrency.Name = "textTakerPaysCurrency";
            this.textTakerPaysCurrency.Size = new System.Drawing.Size(260, 23);
            this.textTakerPaysCurrency.TabIndex = 24;
            // 
            // labelTakerPaysIssuer
            // 
            this.labelTakerPaysIssuer.AutoSize = true;
            this.labelTakerPaysIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "TakerPaysIsIssued", true));
            this.labelTakerPaysIssuer.Location = new System.Drawing.Point(12, 761);
            this.labelTakerPaysIssuer.Name = "labelTakerPaysIssuer";
            this.labelTakerPaysIssuer.Size = new System.Drawing.Size(99, 15);
            this.labelTakerPaysIssuer.TabIndex = 25;
            this.labelTakerPaysIssuer.Text = "Taker pays issuer:";
            // 
            // textTakerPaysIssuer
            // 
            this.textTakerPaysIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TakerPaysIssuer", true));
            this.textTakerPaysIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "TakerPaysIsIssued", true));
            this.textTakerPaysIssuer.Location = new System.Drawing.Point(12, 779);
            this.textTakerPaysIssuer.Name = "textTakerPaysIssuer";
            this.textTakerPaysIssuer.Size = new System.Drawing.Size(260, 23);
            this.textTakerPaysIssuer.TabIndex = 26;
            // 
            // SubmitOfferCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 862);
            this.Controls.Add(this.textTakerPaysIssuer);
            this.Controls.Add(this.labelTakerPaysIssuer);
            this.Controls.Add(this.textTakerPaysCurrency);
            this.Controls.Add(this.labelTakerPaysCurrency);
            this.Controls.Add(this.textTakerPaysValue);
            this.Controls.Add(this.labelTakerPaysValue);
            this.Controls.Add(this.groupTakerPays);
            this.Controls.Add(this.textTakerGetsIssuer);
            this.Controls.Add(this.labelTakerGetsIssuer);
            this.Controls.Add(this.textTakerGetsCurrency);
            this.Controls.Add(this.labelTakerGetsCurrency);
            this.Controls.Add(this.textTakerGetsValue);
            this.Controls.Add(this.labelTakerGetsValue);
            this.Controls.Add(this.groupTakerGets);
            this.Controls.Add(this.textExpiration);
            this.Controls.Add(this.labelExpiration);
            this.Controls.Add(this.textOfferSequence);
            this.Controls.Add(this.labelOfferSequence);
            this.Controls.Add(this.groupFlags);
            this.Controls.Add(this.textLastLedgerSequence);
            this.Controls.Add(this.labelLastLedgerSequence);
            this.Controls.Add(this.textSequence);
            this.Controls.Add(this.labelSequence);
            this.Controls.Add(this.textFee);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SubmitOfferCreateForm";
            this.Text = "Submit Offer Create";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.groupFlags.ResumeLayout(false);
            this.groupFlags.PerformLayout();
            this.groupTakerGets.ResumeLayout(false);
            this.groupTakerGets.PerformLayout();
            this.groupTakerPays.ResumeLayout(false);
            this.groupTakerPays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.TextBox textFee;
        private System.Windows.Forms.Label labelSequence;
        private System.Windows.Forms.TextBox textSequence;
        private System.Windows.Forms.Label labelLastLedgerSequence;
        private System.Windows.Forms.TextBox textLastLedgerSequence;
        private System.Windows.Forms.GroupBox groupFlags;
        private System.Windows.Forms.CheckBox checkFullyCanonicalSig;
        private System.Windows.Forms.CheckBox checkPassive;
        private System.Windows.Forms.CheckBox checkImmediateOrCancel;
        private System.Windows.Forms.CheckBox checkFillOrKill;
        private System.Windows.Forms.CheckBox checkSell;
        private System.Windows.Forms.Label labelOfferSequence;
        private System.Windows.Forms.TextBox textOfferSequence;
        private System.Windows.Forms.Label labelExpiration;
        private System.Windows.Forms.TextBox textExpiration;
        private System.Windows.Forms.GroupBox groupTakerGets;
        private System.Windows.Forms.RadioButton radioTakerGetsIsIssued;
        private System.Windows.Forms.RadioButton radioTakerGetsIsNative;
        private System.Windows.Forms.Label labelTakerGetsValue;
        private System.Windows.Forms.TextBox textTakerGetsValue;
        private System.Windows.Forms.Label labelTakerGetsCurrency;
        private System.Windows.Forms.TextBox textTakerGetsCurrency;
        private System.Windows.Forms.Label labelTakerGetsIssuer;
        private System.Windows.Forms.TextBox textTakerGetsIssuer;
        private System.Windows.Forms.GroupBox groupTakerPays;
        private System.Windows.Forms.RadioButton radioTakerPaysIsIssued;
        private System.Windows.Forms.RadioButton radioTakerPaysIsNative;
        private System.Windows.Forms.Label labelTakerPaysValue;
        private System.Windows.Forms.TextBox textTakerPaysValue;
        private System.Windows.Forms.Label labelTakerPaysCurrency;
        private System.Windows.Forms.TextBox textTakerPaysCurrency;
        private System.Windows.Forms.Label labelTakerPaysIssuer;
        private System.Windows.Forms.TextBox textTakerPaysIssuer;
    }
}