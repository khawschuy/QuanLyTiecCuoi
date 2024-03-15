﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(txbUserName.Text, txbPassWord.Text) == false) {
                MessageBox.Show("Bạn có thật sự muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OK);
            }
            else {
                MainApp mainApp = new MainApp();
                this.Hide();
                mainApp.ShowDialog();
                this.Show();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình không?","Thông báo", MessageBoxButtons.OKCancel ) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}