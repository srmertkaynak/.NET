using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotParametresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArcher_Click(object sender, EventArgs e)
        {
            Attack("Arrow", 50);
        }

        private void btnMage_Click(object sender, EventArgs e)
        {
            Attack("Magic", 75);
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            Attack("Sword", 100);
        }
        /// <summary>
        /// Sadece Classlar kullanabilir.
        /// </summary>
        /// <param name="attackStyle">Hangi stiller ile vuruş yapılacağı girilmelidir.</param>
        /// <param name="damage">Verilecek hasar girilir.</param>
        public void Attack(string attackStyle, int damage = 200)
        {
            MessageBox.Show($"Düşmana {attackStyle} ile {damage} hasar verildi.");
        }
        /// <summary>
        /// Sadece NPC'ler kullanabilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssasin_Click(object sender, EventArgs e)
        {
            Attack("Bıçak");
        }

        public void Attack()
        {
            MessageBox.Show($"Düşmana 100 hasar verildi.");
        }

        private void btnNpc_Click(object sender, EventArgs e)
        {
            Attack();
        }
    }
}
