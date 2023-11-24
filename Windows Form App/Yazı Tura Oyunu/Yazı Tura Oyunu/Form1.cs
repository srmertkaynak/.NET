﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazı_Tura_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            string[] questions =
            {
                "Yes", // Yazı
                "No" // Tura
            };
            string question = "";
            DialogResult result;
            do
            {
                question = questions[random.Next(0,2)]; // 0 ya da 1 rastgele sayı üret
                result = MessageBox.Show("Yazı mı? Tura mı? Yazı ise Yes, Tura ise No seçiniz.","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            } while (question != result.ToString());

            MessageBox.Show("Kazandınız");
        }
    }
}
