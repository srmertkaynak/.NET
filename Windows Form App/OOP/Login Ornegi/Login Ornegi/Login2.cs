using Login_Ornegi.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Ornegi
{
    public partial class Login2 : Form
    {
        public Login2(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        User user;
        private void Login2_Load(object sender, EventArgs e)
        {
            lblMessage.Text = $"Hoş geldiniz. {user.userName}";
        }
    }
}
