﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void plus_Click(object sender, EventArgs e)
        {
            double firstargument = Convert.ToDouble(textBox1.Text);
            double secondargument = Convert.ToDouble(textBox2.Text);
            double result = firstargument + secondargument;
            label1.Text = Convert.ToString(result);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double firstargument = Convert.ToDouble(textBox1.Text);
            double secondargument = Convert.ToDouble(textBox2.Text);
            double result = firstargument * secondargument;
            label1.Text = Convert.ToString(result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double firstargument = Convert.ToDouble(textBox1.Text);
            double secondargument = Convert.ToDouble(textBox2.Text);
            double result = firstargument - secondargument;
            label1.Text = Convert.ToString(result);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double firstargument = Convert.ToDouble(textBox1.Text);
            double secondargument = Convert.ToDouble(textBox2.Text);
            double result = firstargument / secondargument;
            label1.Text = Convert.ToString(result);
        }

    }
}
