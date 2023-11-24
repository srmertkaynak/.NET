using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*for (int i = 1; i <= 10; i++)
            {
                lstNumbers.Items.Add(i);
                if (i % 2 == 0)
                {
                    lstDoubleNumbers.Items.Add(i);
                }
            }*/

            for (int i = 10; i > 0; i--)
            {
                lstNumbers.Items.Add(i);
                if (i % 2 == 0)
                {
                    lstDoubleNumbers.Items.Add(i);
                }
            }

        }
    }
}
