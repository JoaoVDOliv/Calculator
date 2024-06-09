using System.ComponentModel;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.TxtExibition.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.TxtExibition.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            this.TxtExibition.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            this.TxtExibition.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            this.TxtExibition.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.TxtExibition.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            this.TxtExibition.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            this.TxtExibition.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            this.TxtExibition.Text += "9";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            this.TxtExibition.Text += "0";
        }                
    }
}
