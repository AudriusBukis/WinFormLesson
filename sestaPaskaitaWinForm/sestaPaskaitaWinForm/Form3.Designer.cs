namespace sestaPaskaitaWinForm
{
    partial class Form3
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
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.btAddToArray = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainWindowButton = new System.Windows.Forms.Button();
            this.btShowArray = new System.Windows.Forms.Button();
            this.rtbShowArray = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(190, 44);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(114, 27);
            this.tbHeight.TabIndex = 0;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(190, 112);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(114, 27);
            this.tbWeight.TabIndex = 1;
            // 
            // btAddToArray
            // 
            this.btAddToArray.Location = new System.Drawing.Point(113, 199);
            this.btAddToArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddToArray.Name = "btAddToArray";
            this.btAddToArray.Size = new System.Drawing.Size(191, 31);
            this.btAddToArray.TabIndex = 3;
            this.btAddToArray.Text = "Add To Array";
            this.btAddToArray.UseVisualStyleBackColor = true;
            this.btAddToArray.Click += new System.EventHandler(this.BtAddToArray_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(113, 48);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(54, 20);
            this.lable1.TabIndex = 4;
            this.lable1.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Weight";
            // 
            // MainWindowButton
            // 
            this.MainWindowButton.Location = new System.Drawing.Point(246, 272);
            this.MainWindowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainWindowButton.Name = "MainWindowButton";
            this.MainWindowButton.Size = new System.Drawing.Size(213, 31);
            this.MainWindowButton.TabIndex = 9;
            this.MainWindowButton.Text = "Back to main window";
            this.MainWindowButton.UseVisualStyleBackColor = true;
            this.MainWindowButton.Click += new System.EventHandler(this.MainWindowButton_Click);
            // 
            // btShowArray
            // 
            this.btShowArray.Location = new System.Drawing.Point(341, 199);
            this.btShowArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btShowArray.Name = "btShowArray";
            this.btShowArray.Size = new System.Drawing.Size(309, 31);
            this.btShowArray.TabIndex = 10;
            this.btShowArray.Text = "Show Array";
            this.btShowArray.UseVisualStyleBackColor = true;
            this.btShowArray.Click += new System.EventHandler(this.BtShowArray_Click);
            // 
            // rtbShowArray
            // 
            this.rtbShowArray.Location = new System.Drawing.Point(341, 12);
            this.rtbShowArray.Name = "rtbShowArray";
            this.rtbShowArray.Size = new System.Drawing.Size(309, 180);
            this.rtbShowArray.TabIndex = 11;
            this.rtbShowArray.Text = "";

            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 348);
            this.Controls.Add(this.rtbShowArray);
            this.Controls.Add(this.btShowArray);
            this.Controls.Add(this.MainWindowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.btAddToArray);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbHeight);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Button btAddToArray;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainWindowButton;
        private System.Windows.Forms.Button btShowArray;
        private System.Windows.Forms.RichTextBox rtbShowArray;
    }
}