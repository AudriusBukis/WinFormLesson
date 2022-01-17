namespace sestaPaskaitaWinForm
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbInputTemperature = new System.Windows.Forms.TextBox();
            this.RtbOutputConvert = new System.Windows.Forms.RichTextBox();
            this.BtConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RtbKmiOutput = new System.Windows.Forms.RichTextBox();
            this.BtCalculateKMI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainWindowButton
            // 
            this.MainWindowButton.Location = new System.Drawing.Point(262, 406);
            this.MainWindowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainWindowButton.Name = "MainWindowButton";
            this.MainWindowButton.Size = new System.Drawing.Size(213, 31);
            this.MainWindowButton.TabIndex = 10;
            this.MainWindowButton.Text = "Back to main window";
            this.MainWindowButton.UseVisualStyleBackColor = true;
            this.MainWindowButton.Click += new System.EventHandler(this.MainWindowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter current temperature C";
            // 
            // TbInputTemperature
            // 
            this.TbInputTemperature.Location = new System.Drawing.Point(160, 59);
            this.TbInputTemperature.Name = "TbInputTemperature";
            this.TbInputTemperature.Size = new System.Drawing.Size(93, 27);
            this.TbInputTemperature.TabIndex = 12;
            // 
            // RtbOutputConvert
            // 
            this.RtbOutputConvert.Location = new System.Drawing.Point(38, 145);
            this.RtbOutputConvert.Name = "RtbOutputConvert";
            this.RtbOutputConvert.Size = new System.Drawing.Size(346, 109);
            this.RtbOutputConvert.TabIndex = 13;
            this.RtbOutputConvert.Text = "";
            // 
            // BtConvert
            // 
            this.BtConvert.Location = new System.Drawing.Point(160, 100);
            this.BtConvert.Name = "BtConvert";
            this.BtConvert.Size = new System.Drawing.Size(93, 29);
            this.BtConvert.TabIndex = 14;
            this.BtConvert.Text = "Convert";
            this.BtConvert.UseVisualStyleBackColor = true;
            this.BtConvert.Click += new System.EventHandler(this.BtConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Weight";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(499, 63);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(54, 20);
            this.lable1.TabIndex = 17;
            this.lable1.Text = "Height";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(576, 95);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(114, 27);
            this.tbWeight.TabIndex = 16;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(576, 59);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(114, 27);
            this.tbHeight.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "KMI calculation";
            // 
            // RtbKmiOutput
            // 
            this.RtbKmiOutput.Location = new System.Drawing.Point(442, 173);
            this.RtbKmiOutput.Name = "RtbKmiOutput";
            this.RtbKmiOutput.Size = new System.Drawing.Size(346, 109);
            this.RtbKmiOutput.TabIndex = 21;
            this.RtbKmiOutput.Text = "";
            // 
            // BtCalculateKMI
            // 
            this.BtCalculateKMI.Location = new System.Drawing.Point(556, 129);
            this.BtCalculateKMI.Name = "BtCalculateKMI";
            this.BtCalculateKMI.Size = new System.Drawing.Size(93, 29);
            this.BtCalculateKMI.TabIndex = 22;
            this.BtCalculateKMI.Text = "Calculate";
            this.BtCalculateKMI.UseVisualStyleBackColor = true;
            this.BtCalculateKMI.Click += new System.EventHandler(this.BtCalculateKMI_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtCalculateKMI);
            this.Controls.Add(this.RtbKmiOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.BtConvert);
            this.Controls.Add(this.RtbOutputConvert);
            this.Controls.Add(this.TbInputTemperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainWindowButton);
            this.Name = "Form5";
            this.Text = "t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainWindowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbInputTemperature;
        private System.Windows.Forms.RichTextBox RtbOutputConvert;
        private System.Windows.Forms.Button BtConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RtbKmiOutput;
        private System.Windows.Forms.Button BtCalculateKMI;
    }
}