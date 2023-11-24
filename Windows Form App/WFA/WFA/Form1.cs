using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number = 0;

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(++number));
        }

        private void btnClickAzalt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(--number));
        }
    }
}
