﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                new MainMenu().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Incorrect Password. Try again");
                textUserName.Clear();
                txtPassword.Clear();
                textUserName.Focus();
            }
        }
    }
}