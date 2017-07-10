using System;
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

        private void act_Click(object sender, EventArgs e)
        {
            double firstargument = Convert.ToDouble(textBox1.Text);
            double secondargument = Convert.ToDouble(textBox2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "plus":
                    result = firstargument + secondargument;
                    break;

                case "minus":
                    result = firstargument - secondargument;
                    break;
                case "generation":
                    result = firstargument * secondargument;
                    break;
                case "division":
                    result = firstargument / secondargument;
                    break;
                default: throw new Exception("No operation");
            }

            label1.Text = Convert.ToString(result);
        }
    }
}
