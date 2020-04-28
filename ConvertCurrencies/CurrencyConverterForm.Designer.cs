namespace ConvertCurrencies
{
    partial class CurrencyConverterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCurrency1 = new System.Windows.Forms.TextBox();
            this.listBoxCurrency1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCurrency2 = new System.Windows.Forms.ListBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultCurrencyLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert";
            // 
            // textBoxCurrency1
            // 
            this.textBoxCurrency1.Location = new System.Drawing.Point(172, 159);
            this.textBoxCurrency1.Name = "textBoxCurrency1";
            this.textBoxCurrency1.Size = new System.Drawing.Size(100, 31);
            this.textBoxCurrency1.TabIndex = 1;
            // 
            // listBoxCurrency1
            // 
            this.listBoxCurrency1.FormattingEnabled = true;
            this.listBoxCurrency1.ItemHeight = 25;
            this.listBoxCurrency1.Location = new System.Drawing.Point(279, 159);
            this.listBoxCurrency1.Name = "listBoxCurrency1";
            this.listBoxCurrency1.Size = new System.Drawing.Size(120, 79);
            this.listBoxCurrency1.TabIndex = 2;
            this.listBoxCurrency1.SelectedIndexChanged += new System.EventHandler(this.onFirstCurrencySelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // listBoxCurrency2
            // 
            this.listBoxCurrency2.FormattingEnabled = true;
            this.listBoxCurrency2.ItemHeight = 25;
            this.listBoxCurrency2.Location = new System.Drawing.Point(457, 159);
            this.listBoxCurrency2.Name = "listBoxCurrency2";
            this.listBoxCurrency2.Size = new System.Drawing.Size(120, 79);
            this.listBoxCurrency2.TabIndex = 4;
            this.listBoxCurrency2.SelectedIndexChanged += new System.EventHandler(this.onSecondCurrencySelected);
            // 
            // convertButton
            // 
            this.convertButton.Enabled = false;
            this.convertButton.Location = new System.Drawing.Point(609, 159);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(110, 41);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(167, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 2);
            this.label3.TabIndex = 6;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(172, 348);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 25);
            this.resultLabel.TabIndex = 7;
            // 
            // resultCurrencyLabel
            // 
            this.resultCurrencyLabel.AutoSize = true;
            this.resultCurrencyLabel.Location = new System.Drawing.Point(274, 348);
            this.resultCurrencyLabel.Name = "resultCurrencyLabel";
            this.resultCurrencyLabel.Size = new System.Drawing.Size(0, 25);
            this.resultCurrencyLabel.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1025, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Audit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onClickAuditButton);
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultCurrencyLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.listBoxCurrency2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxCurrency1);
            this.Controls.Add(this.textBoxCurrency1);
            this.Controls.Add(this.label1);
            this.Name = "CurrencyConverterForm";
            this.Text = "Currency converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCurrency1;
        private System.Windows.Forms.ListBox listBoxCurrency1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCurrency2;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultCurrencyLabel;
        private System.Windows.Forms.Button button1;
    }
}

