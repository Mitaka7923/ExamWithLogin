﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPassword
{
    public partial class LoginForm : Form
    {
        public Dictionary<string, string> usernames;
        public string username;
        internal ClickMethods clickMethods;

        public LoginForm()
        {
            InitializeComponent();
            clickMethods = new ClickMethods(this);
            usernames = Initialization.AssignUsernames();
        }
    }
}