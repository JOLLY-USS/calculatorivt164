﻿using System;
using System.Windows.Forms;
using calculator.OneArg;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void act_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArgument, secondArgument);
            label1.Text = Convert.ToString(result);
        }
        private void OneArgumentOperation_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            IOneArgumentCalculator calculator = OneArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArgument);
            label1.Text = Convert.ToString(result);
        }
    }
}
