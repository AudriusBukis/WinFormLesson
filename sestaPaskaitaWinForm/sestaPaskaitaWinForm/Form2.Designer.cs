namespace sestaPaskaitaWinForm
{
    partial class Form2
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.submitNameButton = new System.Windows.Forms.Button();
            this.Vardas = new System.Windows.Forms.Label();
            this.MainWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(100, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(186, 16);
            this.tbName.TabIndex = 7;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(100, 104);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(186, 217);
            this.rtbOutput.TabIndex = 6;
            this.rtbOutput.Text = "";
            // 
            // submitNameButton
            // 
            this.submitNameButton.Location = new System.Drawing.Point(100, 75);
            this.submitNameButton.Name = "submitNameButton";
            this.submitNameButton.Size = new System.Drawing.Size(186, 23);
            this.submitNameButton.TabIndex = 5;
            this.submitNameButton.Text = "Vardas";
            this.submitNameButton.UseVisualStyleBackColor = true;
            this.submitNameButton.Click += new System.EventHandler(this.submitNameButton_Click);
            // 
            // Vardas
            // 
            this.Vardas.AutoSize = true;
            this.Vardas.Location = new System.Drawing.Point(53, 49);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(41, 15);
            this.Vardas.TabIndex = 4;
            this.Vardas.Text = "Vardas";
            // 
            // MainWindowButton
            // 
            this.MainWindowButton.Location = new System.Drawing.Point(100, 362);
            this.MainWindowButton.Name = "MainWindowButton";
            this.MainWindowButton.Size = new System.Drawing.Size(186, 23);
            this.MainWindowButton.TabIndex = 8;
            this.MainWindowButton.Text = "Back to main window";
            this.MainWindowButton.UseVisualStyleBackColor = true;
            this.MainWindowButton.Click += new System.EventHandler(this.MainWindowButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 404);
            this.Controls.Add(this.MainWindowButton);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.submitNameButton);
            this.Controls.Add(this.Vardas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button submitNameButton;
        private System.Windows.Forms.Label Vardas;
        private System.Windows.Forms.Button MainWindowButton;
    }
}