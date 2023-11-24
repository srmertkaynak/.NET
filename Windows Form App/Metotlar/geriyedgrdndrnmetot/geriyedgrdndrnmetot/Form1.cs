using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geriyedgrdndrnmetot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetName()
        {
            return "Mert";
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            string name = GetName();
            MessageBox.Show(name);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Calculate(3,2).ToString());
        }

        public int Calculate(int number1, int number2)
        {
            int number = number1 * number2;
            return number;
        }

    }
}
