﻿using System;
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
        

        private void button4_Click_1(object sender, EventArgs e)
        {
            string firstArgumentString = textBoxFirstIn.Text;
            double firstArgument = Convert.ToDouble(firstArgumentString);
            string secondArgumentString = textBoxSecondIn.Text;
            double secondArgument = Convert.ToDouble(secondArgumentString);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculate(((Button)sender).Name);
            double result = calculator.Calculate(firstArgument, secondArgument);
            textBoxOut.Text = result.ToString();

        }

        private void Single_Click(object sender, EventArgs e)
        {
            string argumentString = textBoxFirstIn.Text;
            double argument = Convert.ToDouble(argumentString);
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate(((Button)sender).Name);
            double result = singlecalculator.SingleCalculate(argument);
            textBoxOut.Text = result.ToString();
        }
    }
    }




