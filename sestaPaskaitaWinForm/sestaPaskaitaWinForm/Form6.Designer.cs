namespace sestaPaskaitaWinForm
{
    partial class Form6
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
            this.MainWindowButton = new System.Windows.Forms.Button();
            this.listGrade = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbInputGrade = new System.Windows.Forms.TextBox();
            this.BtInsertGrade = new System.Windows.Forms.Button();
            this.BtDalateGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainWindowButton
            // 
            this.MainWindowButton.Location = new System.Drawing.Point(276, 385);
            this.MainWindowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainWindowButton.Name = "MainWindowButton";
            this.MainWindowButton.Size = new System.Drawing.Size(213, 31);
            this.MainWindowButton.TabIndex = 11;
            this.MainWindowButton.Text = "Back to main window";
            this.MainWindowButton.UseVisualStyleBackColor = true;
            this.MainWindowButton.Click += new System.EventHandler(this.MainWindowButton_Click);
            // 
            // listGrade
            // 
            this.listGrade.FormattingEnabled = true;
            this.listGrade.ItemHeight = 20;
            this.listGrade.Location = new System.Drawing.Point(361, 43);
            this.listGrade.Name = "listGrade";
            this.listGrade.Size = new System.Drawing.Size(201, 284);
            this.listGrade.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Grade";
            // 
            // TbInputGrade
            // 
            this.TbInputGrade.Location = new System.Drawing.Point(188, 36);
            this.TbInputGrade.Name = "TbInputGrade";
            this.TbInputGrade.Size = new System.Drawing.Size(125, 27);
            this.TbInputGrade.TabIndex = 14;
            // 
            // BtInsertGrade
            // 
            this.BtInsertGrade.Location = new System.Drawing.Point(133, 81);
            this.BtInsertGrade.Name = "BtInsertGrade";
            this.BtInsertGrade.Size = new System.Drawing.Size(180, 29);
            this.BtInsertGrade.TabIndex = 15;
            this.BtInsertGrade.Text = "Insert grede";
            this.BtInsertGrade.UseVisualStyleBackColor = true;
            this.BtInsertGrade.Click += new System.EventHandler(this.BtInsertGrade_Click);
            // 
            // BtDalateGrade
            // 
            this.BtDalateGrade.Location = new System.Drawing.Point(133, 127);
            this.BtDalateGrade.Name = "BtDalateGrade";
            this.BtDalateGrade.Size = new System.Drawing.Size(180, 29);
            this.BtDalateGrade.TabIndex = 16;
            this.BtDalateGrade.Text = "Delate grede";
            this.BtDalateGrade.UseVisualStyleBackColor = true;
            this.BtDalateGrade.Click += new System.EventHandler(this.BtDalateGrade_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtDalateGrade);
            this.Controls.Add(this.BtInsertGrade);
            this.Controls.Add(this.TbInputGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listGrade);
            this.Controls.Add(this.MainWindowButton);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainWindowButton;
        private System.Windows.Forms.ListBox listGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbInputGrade;
        private System.Windows.Forms.Button BtInsertGrade;
        private System.Windows.Forms.Button BtDalateGrade;
    }
}