using OOP_Class_Kavramı.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Class_Kavramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            // Class of User
            User user = new User();
            user.userName = "Abdullah";
            user.password = "123";
            user.age = 27;
            user.job = "developer";
            MessageBox.Show($"kullanıcı adı: {user.userName} - password: {user.password}");
            User user2 = new User();

        }

        private void btnNewTree_Click(object sender, EventArgs e)
        {
            // Class of Tree
            Tree tree = new Tree();
            tree.color = "Gri";
            tree.age = 100;
            tree.height = 50;
            tree.type = 1;
            MessageBox.Show($"Ağaç Rengi: {tree.color} - Ağaç Yaşı: {tree.age}");
        }
    }
}
