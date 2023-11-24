using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemek_Tarifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] stages =
        {
            "1- Tencerede Suyu Kaynatın",
            "2- Kaynar suya makarnaları dökün",
            "3- tuz atın",
            "4- makarnalar pişince süzgeçe alın",
            "5- tencereye yağ koyduktan sonra makarnaları içine dökün",
            "6- Afiyet olsun"
        };

        int index = 0;

        private void btnAddStage_Click(object sender, EventArgs e)
        {
            if (index <= stages.Length - 1)
            {
                lstStages.Items.Add(stages[index]);
                index++;
            }
            else
            {
                MessageBox.Show("Tarif tamamlanmıştır.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int index = 0;
            while (index < stages.Length)
            {
                lstStages.Items.Add(stages[index]);
                index++;
            }
        }
    }
}
