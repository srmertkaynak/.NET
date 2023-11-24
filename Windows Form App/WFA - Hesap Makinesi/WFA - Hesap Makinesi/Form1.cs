using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA___Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1;
        string op;

        private void btnDividedBy_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "/";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "-";
        }

        private void btnMultiplay_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "*";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "+";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double number2;
            double result;

            number2 = textBox1.Text;
            if (op == "+")
            {
                result = number1 + number2;
            }else if(op == "-")
            {
                result =number1 - number2;
            }else if (op == "*")
            {
                result = number1 * number2;
            }
            else
            {
                result = number1 / number2;
            }
            textBox1.Text = result.ToString();
        }
    }
}
