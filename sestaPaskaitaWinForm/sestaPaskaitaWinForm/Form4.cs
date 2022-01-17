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
    public partial class Form4 : Form
    {
        public Form4()
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

       
        private void BShowNameDate_Click(object sender, EventArgs e)
        {
            string userName = "Audrius";
            DateTime todaynow = DateTime.Now;
            TbNameDate.Text = $"Name {userName} Date {todaynow.Year}-{todaynow.Month}-{todaynow.Day}";
        }

        private void BShowName10Times_Click(object sender, EventArgs e)
        {
            string userName = "Audrius";
            RtbName10Times.Text = "Name printed 10 times";
            for (int i = 1; i <= 10; i++)
            {
                RtbName10Times.AppendText($"\r\n {i}. {userName}");
            }
            
        }

        private void BOddOrEven_Click(object sender, EventArgs e)
        {
            if(int.TryParse(TbInputNumOddEven.Text, out int intNumber))
            {
                if(intNumber %2 == 0)
                {
                    RtbOddOrEven.Text = $" this number {intNumber} - is even";
                }
                else
                {
                    RtbOddOrEven.Text = $" this number {intNumber} - is odd";
                }
            }
            else
            {
                MessageBox.Show("You entered not an int number");
                return;
            }
        }

        private void BCalculateAvg_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TbFirstSemester.Text, out int firstGrade)
                && int.TryParse(TbSecondSemester.Text, out int secondGrade)
                && int.TryParse(TbThirdSemester.Text, out int thirdGrade))
            {
                if ((firstGrade > 11 || firstGrade < 0)
                    || (secondGrade > 11 || secondGrade < 0) 
                    || (thirdGrade > 11 || thirdGrade < 0))
                {
                    MessageBox.Show("You entered grade not in rage from 0 to 10");
                    return;
                }
                else
                {
                    double averange = ((double)firstGrade + (double)secondGrade + (double)thirdGrade) / 3;
                    RtbAvarangeOut.Text = "Averange will be";
                    RtbAvarangeOut.AppendText($"\r\nFirst semester grade - {firstGrade}");
                    RtbAvarangeOut.AppendText($"\r\nSecond semester grade - {secondGrade}");
                    RtbAvarangeOut.AppendText($"\r\nThird semester grade - {thirdGrade}");
                    RtbAvarangeOut.AppendText($"\r\n-------------------------------------");
                    RtbAvarangeOut.AppendText($"\r\nAverange year grade is - {averange}");
                }
                
            }
            else
            {
                MessageBox.Show("You entered not an int number");
                return;
            }
        }
    }
}

