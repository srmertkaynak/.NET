using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ref_Keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number = 20;

        public void SendCopy(int copyNumber)
        {
            copyNumber = 40;
        }

        public void RefCopy(ref int refCopy)
        {
            refCopy = 50;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            SendCopy(number);
            MessageBox.Show(number.ToString());
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            RefCopy(ref number);
            MessageBox.Show(number.ToString());
        }
    }
}
