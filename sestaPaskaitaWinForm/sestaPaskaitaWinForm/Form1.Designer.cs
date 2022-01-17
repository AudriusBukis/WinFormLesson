namespace sestaPaskaitaWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskNo1 = new System.Windows.Forms.Button();
            this.TaskNo2 = new System.Windows.Forms.Button();
            this.TaskNo3 = new System.Windows.Forms.Button();
            this.TaskNo4 = new System.Windows.Forms.Button();
            this.TaskNo5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskNo1
            // 
            this.TaskNo1.Location = new System.Drawing.Point(90, 155);
            this.TaskNo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TaskNo1.Name = "TaskNo1";
            this.TaskNo1.Size = new System.Drawing.Size(225, 31);
            this.TaskNo1.TabIndex = 0;
            this.TaskNo1.Text = "Užduotis nr.1";
            this.TaskNo1.UseVisualStyleBackColor = true;
            this.TaskNo1.Click += new System.EventHandler(this.TaskNo1_Click);
            // 
            // TaskNo2
            // 
            this.TaskNo2.Location = new System.Drawing.Point(90, 193);
            this.TaskNo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TaskNo2.Name = "TaskNo2";
            this.TaskNo2.Size = new System.Drawing.Size(225, 31);
            this.TaskNo2.TabIndex = 1;
            this.TaskNo2.Text = "Užduotis nr.2";
            this.TaskNo2.UseVisualStyleBackColor = true;
            this.TaskNo2.Click += new System.EventHandler(this.TaskNo2_Click);
            // 
            // TaskNo3
            // 
            this.TaskNo3.Location = new System.Drawing.Point(90, 232);
            this.TaskNo3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TaskNo3.Name = "TaskNo3";
            this.TaskNo3.Size = new System.Drawing.Size(225, 31);
            this.TaskNo3.TabIndex = 2;
            this.TaskNo3.Text = "Užduotis nr.3";
            this.TaskNo3.UseVisualStyleBackColor = true;
            this.TaskNo3.Click += new System.EventHandler(this.TaskNo3_Click);
            // 
            // TaskNo4
            // 
            this.TaskNo4.Location = new System.Drawing.Point(90, 271);
            this.TaskNo4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TaskNo4.Name = "TaskNo4";
            this.TaskNo4.Size = new System.Drawing.Size(225, 31);
            this.TaskNo4.TabIndex = 3;
            this.TaskNo4.Text = "Užduotis nr.4";
            this.TaskNo4.UseVisualStyleBackColor = true;
            this.TaskNo4.Click += new System.EventHandler(this.TaskNo4_Click);
            // 
            // TaskNo5
            // 
            this.TaskNo5.Location = new System.Drawing.Point(90, 309);
            this.TaskNo5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TaskNo5.Name = "TaskNo5";
            this.TaskNo5.Size = new System.Drawing.Size(225, 31);
            this.TaskNo5.TabIndex = 4;
            this.TaskNo5.Text = "Užduotis nr.5";
            this.TaskNo5.UseVisualStyleBackColor = true;
            this.TaskNo5.Click += new System.EventHandler(this.TaskNo5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "pasirinkite užduotį kuria norite matyti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskNo5);
            this.Controls.Add(this.TaskNo4);
            this.Controls.Add(this.TaskNo3);
            this.Controls.Add(this.TaskNo2);
            this.Controls.Add(this.TaskNo1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TaskNo1;
        private System.Windows.Forms.Button TaskNo2;
        private System.Windows.Forms.Button TaskNo3;
        private System.Windows.Forms.Button TaskNo4;
        private System.Windows.Forms.Button TaskNo5;
        private System.Windows.Forms.Label label1;
    }
}
