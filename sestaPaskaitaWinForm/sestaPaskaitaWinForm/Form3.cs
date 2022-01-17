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
    public partial class Form3 : Form
    {
        public double Height, Weight;
        public List<double> newListHeight = new List<double>();
        public List<double> newListWeight  = new List<double>();
        public Form3()
        {

            InitializeComponent();

        }

        private void BtAddToArray_Click(object sender, EventArgs e)
        {
            
            if (tbHeight.Text == "" || tbWeight.Text == "")
            {
                MessageBox.Show("Not all fields are with numbers");
                return;
            }
            if (!double.TryParse(tbHeight.Text, out Height) || !double.TryParse(tbWeight.Text, out Weight))
            {
                MessageBox.Show("Not all fields are with numbers");
                return;
            }
            else
            {
                newListHeight.Add(Height);
                newListWeight.Add(Weight);
            }

        }

        private void BtShowArray_Click(object sender, EventArgs e)
        {
            rtbShowArray.Text = "Array of the inputs";
            for (int i = 0; i < newListHeight.Count; i++)
            {
                rtbShowArray.AppendText($"\r\n{i + 1}. Height - {newListHeight[i]} Weight - {newListWeight[i]}");
            }    
        }

        private void MainWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
