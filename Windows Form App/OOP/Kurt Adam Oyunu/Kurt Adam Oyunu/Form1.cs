using Kurt_Adam_Oyunu.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurt_Adam_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Account account = new Account();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            account.userName = txtUserName.Text;
            account.race = cmbRace.SelectedItem.ToString();
            account.branch = cmbBranch.SelectedItem.ToString();
            account.weapon = txtWeapon.Text;
            ChangeState(false);
            ChangeVisible(true);
        }
        public void ChangeState(bool state)
        {
            txtUserName.Enabled = state;
            txtWeapon.Enabled = state;
            cmbBranch.Enabled = state;
            cmbRace.Enabled = state;
            btnSelect.Enabled = state;
        }
        public void ChangeVisible(bool isVisible)
        {
            lblHealth.Visible = pcbWolfMan.Visible = btnAttack.Visible = isVisible;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            account.Attack();
            lblHealth.Width -= account.damage;
            MessageBox.Show($"Düşmana {account.damage} kadar hasar verdiniz.");
            if (lblHealth.Width <= 0)
            {
                MessageBox.Show("Düşmanı yendiniz.");
                pcbWolfMan.Visible = false;
            }
            
        }
    }
}
