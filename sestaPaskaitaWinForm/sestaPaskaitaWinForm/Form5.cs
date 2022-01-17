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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void BtConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TbInputTemperature.Text, out double temperatureC))
            {
                RtbOutputConvert.Text = $"Converting temperature";
                RtbOutputConvert.AppendText($"\r\nTemperature in Kelvins = {temperatureC + 273.16} K");
                RtbOutputConvert.AppendText($"\r\nTemperature in Fahrenheit = {temperatureC * 9 / 5 + 32} F");
                RtbOutputConvert.AppendText($"\r\nTemperature in Reomer = {temperatureC * 0.8} R");
                            }
            else
            {
                MessageBox.Show("You entered not number");
                return;
            }
        }




        private void BtCalculateKMI_Click(object sender, EventArgs e)
        {
            double ansverKMI = 0;
            if (!double.TryParse(tbHeight.Text, out double inputHeight) || !double.TryParse(tbWeight.Text, out double inputWeight))
            {
                MessageBox.Show("Not all fields are with numbers");
                return;

            }
            else
            {
                ansverKMI = inputWeight / Math.Pow(inputHeight, 2);
                if (ansverKMI < 18.5)
                {
                    RtbKmiOutput.Text = $"less the 18,5 - person is weak and his body weight is too low";
                    RtbKmiOutput.AppendText($"\r\nYour index is {ansverKMI}");
                }
                else if (ansverKMI < 25)
                {
                    RtbKmiOutput.Text = $" 18,5 - 25 - ideal body mass index";
                    RtbKmiOutput.AppendText($"\r\nYour index is {ansverKMI}");
                }
                else if (ansverKMI < 30)
                {
                    RtbKmiOutput.Text = $" 25 - 30 - the person is overweight";
                    RtbKmiOutput.AppendText($"\r\nYour index is {ansverKMI}");
                }
                else
                {
                    RtbKmiOutput.Text = $" Higher when 30 - person is obese";
                    RtbKmiOutput.AppendText($"\r\nYour index is {ansverKMI}");
                }
            }


        }
    }
}
