using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sestaPaskaitaWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void MainWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void submitNameButton_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Name can not be empty");
                return;
            }

            rtbOutput.Text = $"Hello, {tbName.Text} !!!";
            rtbOutput.AppendText("\r\nNice to see you");
        }    
    }
}
