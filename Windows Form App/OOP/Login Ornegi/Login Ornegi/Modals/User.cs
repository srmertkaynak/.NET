﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Ornegi.Modals
{
    public class User
    {
        public User(string _userName, string _password)
        {
            userName = _userName;
            password = _password;
        }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
