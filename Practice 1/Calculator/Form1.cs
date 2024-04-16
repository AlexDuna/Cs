using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalculFinal;
        double num1;
        double num2;
        string option;
        double result;

        private void button1_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button10.Text;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txt.Text);
            txt.Clear();

        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + DotButton.Text;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txt.Text);
            txt.Clear();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txt.Text);
            txt.Clear();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txt.Text);
            txt.Clear();
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            option = "sqrt";
            txt.Clear();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txt.Text);

            if (option.Equals("+"))
                result = num1 + num2;
            if(option.Equals("-"))
                result = num1 - num2;
            if(option.Equals("*"))
                result = num1 * num2;
            if(option.Equals("/"))
                result = num1 / num2;
            if (option.Equals("sqrt"))
                result = Math.Sqrt(num2);

            txt.Clear();
            txt.Text = result.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txt.Clear();
        }
    }
}
