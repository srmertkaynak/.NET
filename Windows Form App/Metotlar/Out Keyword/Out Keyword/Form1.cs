using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Out_Keyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            String message = Play(out number1, out number2);
            lblNumber1.Text = number1.ToString();
            lblNumber2.Text = number2.ToString();
            MessageBox.Show(message);

        }

        Random random = new Random();

        public string Play(out int number1, out int number2)
        {
            string message;
            number1 = random.Next(1, 7);
            number2 = random.Next(1, 7);

            if (number1 == number2)
            {
                message = "Kazandınız. Tebrikler.";
            }
            else
            {
                message = "Kaybettiniz...";
            }
            return message;
        }
    }
}
