namespace ConvertCurrencies
{
    partial class AuditForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.beginingDatePortionPicker = new System.Windows.Forms.DateTimePicker();
            this.beginingTimePortionPicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePortionPicker = new System.Windows.Forms.DateTimePicker();
            this.endTmePortionPicker = new System.Windows.Forms.DateTimePicker();
            this.filterButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1334, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1258, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 33);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.onClickExitButton);
            // 
            // beginingDatePortionPicker
            // 
            this.beginingDatePortionPicker.Location = new System.Drawing.Point(71, 124);
            this.beginingDatePortionPicker.Name = "beginingDatePortionPicker";
            this.beginingDatePortionPicker.Size = new System.Drawing.Size(200, 31);
            this.beginingDatePortionPicker.TabIndex = 2;
            // 
            // beginingTimePortionPicker
            // 
            this.beginingTimePortionPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.beginingTimePortionPicker.Location = new System.Drawing.Point(277, 124);
            this.beginingTimePortionPicker.Name = "beginingTimePortionPicker";
            this.beginingTimePortionPicker.ShowUpDown = true;
            this.beginingTimePortionPicker.Size = new System.Drawing.Size(200, 31);
            this.beginingTimePortionPicker.TabIndex = 3;
            // 
            // endDatePortionPicker
            // 
            this.endDatePortionPicker.Location = new System.Drawing.Point(759, 124);
            this.endDatePortionPicker.Name = "endDatePortionPicker";
            this.endDatePortionPicker.Size = new System.Drawing.Size(200, 31);
            this.endDatePortionPicker.TabIndex = 4;
            // 
            // endTmePortionPicker
            // 
            this.endTmePortionPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTmePortionPicker.Location = new System.Drawing.Point(966, 124);
            this.endTmePortionPicker.Name = "endTmePortionPicker";
            this.endTmePortionPicker.ShowUpDown = true;
            this.endTmePortionPicker.Size = new System.Drawing.Size(200, 31);
            this.endTmePortionPicker.TabIndex = 5;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(1173, 114);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(142, 41);
            this.filterButton.TabIndex = 6;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.onFilterClicked);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1173, 161);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(142, 51);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.onClearClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Begining";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(754, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ending";
            // 
            // AuditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 778);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.endTmePortionPicker);
            this.Controls.Add(this.endDatePortionPicker);
            this.Controls.Add(this.beginingTimePortionPicker);
            this.Controls.Add(this.beginingDatePortionPicker);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AuditForm";
            this.Text = "AuditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DateTimePicker beginingDatePortionPicker;
        private System.Windows.Forms.DateTimePicker beginingTimePortionPicker;
        private System.Windows.Forms.DateTimePicker endDatePortionPicker;
        private System.Windows.Forms.DateTimePicker endTmePortionPicker;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}