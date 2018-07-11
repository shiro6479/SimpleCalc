using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sum_Click(object sender, EventArgs e)
        {
            string FirstNumString = textBoxFirstIn.Text;
            double FirstNum = Convert.ToDouble(FirstNumString);
            string SecondNumString = textBoxSecondIn.Text;
            double SecondNum = Convert.ToDouble(SecondNumString);
            double Result = FirstNum + SecondNum;
            textBoxOut.Text = Result.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            string FirstNumString = textBoxFirstIn.Text;
            double FirstNum = Convert.ToDouble(FirstNumString);
            string SecondNumString = textBoxSecondIn.Text;
            double SecondNum = Convert.ToDouble(SecondNumString);
            double Result = FirstNum - SecondNum;
            textBoxOut.Text = Result.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            string FirstNumString = textBoxFirstIn.Text;
            double FirstNum = Convert.ToDouble(FirstNumString);
            string SecondNumString = textBoxSecondIn.Text;
            double SecondNum = Convert.ToDouble(SecondNumString);
            double Result = FirstNum * SecondNum;
            textBoxOut.Text = Result.ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            string FirstNumString = textBoxFirstIn.Text;
            double FirstNum = Convert.ToDouble(FirstNumString);
            string SecondNumString = textBoxSecondIn.Text;
            double SecondNum = Convert.ToDouble(SecondNumString);
            double Result = FirstNum / SecondNum;
            textBoxOut.Text = Result.ToString();
        }
    }
}


