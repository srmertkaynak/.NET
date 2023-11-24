using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] cities = new string[]
        {
            "İstanbul",
            "Ankara",
            "Trabzon",
            "Kayseri",
            "Antalya",
            "Konya"
        };

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbFrom.Items.Add(cities[0]);
            cmbFrom.Items.Add(cities[1]);
            MessageBox.Show(cities.Length + " farklı şehir bulunmaktadır.");

        }

        private void cmbFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbTo.Items.Clear();
            cmbTo.Text = "";

            if (cmbFrom.SelectedItem.ToString() == cities[0])
            {
                cmbTo.Items.Add(cities[2]);
                cmbTo.Items.Add(cities[3]);
            }
            else
            {
                cmbTo.Items.Add(cities[4]);
                cmbTo.Items.Add(cities[5]);
            }
        }

        private void satinAl_Click(object sender, EventArgs e)
        {
            string from = cmbFrom.SelectedItem.ToString();
            string to = cmbTo.SelectedItem.ToString();
            MessageBox.Show("Kalkış Noktası: " + from + ", Varış Noktası: " + to);

        }
    }
}
