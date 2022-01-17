namespace sestaPaskaitaWinForm
{
    partial class Form4
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
            this.MainWindowButton = new System.Windows.Forms.Button();
            this.BShowNameDate = new System.Windows.Forms.Button();
            this.TbNameDate = new System.Windows.Forms.TextBox();
            this.BShowName10Times = new System.Windows.Forms.Button();
            this.RtbName10Times = new System.Windows.Forms.RichTextBox();
            this.BOddOrEven = new System.Windows.Forms.Button();
            this.TbInputNumOddEven = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RtbOddOrEven = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbFirstSemester = new System.Windows.Forms.TextBox();
            this.TbSecondSemester = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbThirdSemester = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BCalculateAvg = new System.Windows.Forms.Button();
            this.RtbAvarangeOut = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWindowButton
            // 
            this.MainWindowButton.Location = new System.Drawing.Point(405, 475);
            this.MainWindowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainWindowButton.Name = "MainWindowButton";
            this.MainWindowButton.Size = new System.Drawing.Size(213, 31);
            this.MainWindowButton.TabIndex = 9;
            this.MainWindowButton.Text = "Back to main window";
            this.MainWindowButton.UseVisualStyleBackColor = true;
            this.MainWindowButton.Click += new System.EventHandler(this.MainWindowButton_Click);
            // 
            // BShowNameDate
            // 
            this.BShowNameDate.Location = new System.Drawing.Point(45, 40);
            this.BShowNameDate.Name = "BShowNameDate";
            this.BShowNameDate.Size = new System.Drawing.Size(204, 29);
            this.BShowNameDate.TabIndex = 10;
            this.BShowNameDate.Text = "Show Name and Date";
            this.BShowNameDate.UseVisualStyleBackColor = true;
            this.BShowNameDate.Click += new System.EventHandler(this.BShowNameDate_Click);
            // 
            // TbNameDate
            // 
            this.TbNameDate.Location = new System.Drawing.Point(267, 42);
            this.TbNameDate.Name = "TbNameDate";
            this.TbNameDate.Size = new System.Drawing.Size(341, 27);
            this.TbNameDate.TabIndex = 11;
            // 
            // BShowName10Times
            // 
            this.BShowName10Times.Location = new System.Drawing.Point(45, 93);
            this.BShowName10Times.Name = "BShowName10Times";
            this.BShowName10Times.Size = new System.Drawing.Size(204, 29);
            this.BShowName10Times.TabIndex = 12;
            this.BShowName10Times.Text = "Show Name 10 times";
            this.BShowName10Times.UseVisualStyleBackColor = true;
            this.BShowName10Times.Click += new System.EventHandler(this.BShowName10Times_Click);
            // 
            // RtbName10Times
            // 
            this.RtbName10Times.Location = new System.Drawing.Point(267, 93);
            this.RtbName10Times.Name = "RtbName10Times";
            this.RtbName10Times.Size = new System.Drawing.Size(341, 192);
            this.RtbName10Times.TabIndex = 13;
            this.RtbName10Times.Text = "";
            // 
            // BOddOrEven
            // 
            this.BOddOrEven.Location = new System.Drawing.Point(45, 370);
            this.BOddOrEven.Name = "BOddOrEven";
            this.BOddOrEven.Size = new System.Drawing.Size(204, 29);
            this.BOddOrEven.TabIndex = 14;
            this.BOddOrEven.Text = "Odd or Even";
            this.BOddOrEven.UseVisualStyleBackColor = true;
            this.BOddOrEven.Click += new System.EventHandler(this.BOddOrEven_Click);
            // 
            // TbInputNumOddEven
            // 
            this.TbInputNumOddEven.Location = new System.Drawing.Point(43, 326);
            this.TbInputNumOddEven.Name = "TbInputNumOddEven";
            this.TbInputNumOddEven.Size = new System.Drawing.Size(206, 27);
            this.TbInputNumOddEven.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter the int number";
            // 
            // RtbOddOrEven
            // 
            this.RtbOddOrEven.Location = new System.Drawing.Point(267, 326);
            this.RtbOddOrEven.Name = "RtbOddOrEven";
            this.RtbOddOrEven.Size = new System.Drawing.Size(341, 73);
            this.RtbOddOrEven.TabIndex = 17;
            this.RtbOddOrEven.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "First semester grade";
            // 
            // TbFirstSemester
            // 
            this.TbFirstSemester.Location = new System.Drawing.Point(869, 42);
            this.TbFirstSemester.Name = "TbFirstSemester";
            this.TbFirstSemester.Size = new System.Drawing.Size(82, 27);
            this.TbFirstSemester.TabIndex = 19;
            // 
            // TbSecondSemester
            // 
            this.TbSecondSemester.Location = new System.Drawing.Point(869, 83);
            this.TbSecondSemester.Name = "TbSecondSemester";
            this.TbSecondSemester.Size = new System.Drawing.Size(82, 27);
            this.TbSecondSemester.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Second semester grade";
            // 
            // TbThirdSemester
            // 
            this.TbThirdSemester.Location = new System.Drawing.Point(869, 127);
            this.TbThirdSemester.Name = "TbThirdSemester";
            this.TbThirdSemester.Size = new System.Drawing.Size(82, 27);
            this.TbThirdSemester.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Third semester grade";
            // 
            // BCalculateAvg
            // 
            this.BCalculateAvg.Location = new System.Drawing.Point(697, 179);
            this.BCalculateAvg.Name = "BCalculateAvg";
            this.BCalculateAvg.Size = new System.Drawing.Size(254, 29);
            this.BCalculateAvg.TabIndex = 24;
            this.BCalculateAvg.Text = "Calculate averange";
            this.BCalculateAvg.UseVisualStyleBackColor = true;
            this.BCalculateAvg.Click += new System.EventHandler(this.BCalculateAvg_Click);
            // 
            // RtbAvarangeOut
            // 
            this.RtbAvarangeOut.Location = new System.Drawing.Point(697, 230);
            this.RtbAvarangeOut.Name = "RtbAvarangeOut";
            this.RtbAvarangeOut.Size = new System.Drawing.Size(254, 169);
            this.RtbAvarangeOut.TabIndex = 25;
            this.RtbAvarangeOut.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 600);
            this.Controls.Add(this.RtbAvarangeOut);
            this.Controls.Add(this.BCalculateAvg);
            this.Controls.Add(this.TbThirdSemester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbSecondSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbFirstSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RtbOddOrEven);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbInputNumOddEven);
            this.Controls.Add(this.BOddOrEven);
            this.Controls.Add(this.RtbName10Times);
            this.Controls.Add(this.BShowName10Times);
            this.Controls.Add(this.TbNameDate);
            this.Controls.Add(this.BShowNameDate);
            this.Controls.Add(this.MainWindowButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainWindowButton;
        private System.Windows.Forms.Button BShowNameDate;
        private System.Windows.Forms.TextBox TbNameDate;
        private System.Windows.Forms.Button BShowName10Times;
        private System.Windows.Forms.RichTextBox RtbName10Times;
        private System.Windows.Forms.Button BOddOrEven;
        private System.Windows.Forms.TextBox TbInputNumOddEven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtbOddOrEven;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbFirstSemester;
        private System.Windows.Forms.TextBox TbSecondSemester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbThirdSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BCalculateAvg;
        private System.Windows.Forms.RichTextBox RtbAvarangeOut;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}