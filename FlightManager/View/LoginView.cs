﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            CreateView cv = new CreateView();
            cv.ShowDialog();
        }
    }
}
