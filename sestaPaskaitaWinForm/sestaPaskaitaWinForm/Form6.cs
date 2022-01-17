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
    public partial class Form6 : Form
    {
        public List<string> newListGrade = new List<string>();
        public Form6()
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

        private void BtInsertGrade_Click(object sender, EventArgs e)
        {
            //newListGrade.Add(TbInputGrade.Text);
            listGrade.Items.Add(TbInputGrade.Text);
            
        }

        private void BtDalateGrade_Click(object sender, EventArgs e)
        {
            listGrade.Items.Remove(listGrade.SelectedItem);

        }
    }
}
