using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string[] books =
            {
                "Simyacı",
                "Bülbülü öldürmek",
                "Sefiller",
                "Minyeli Abdullah",
                "Semerkand",
                "Beyaz Diş",
                "Ölüm Sessiz Geldi"
            };

            foreach (string book in books)
            {
                lstBooks.Items.Add(book);
            }
        }
    }
}
