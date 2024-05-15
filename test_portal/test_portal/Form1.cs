using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_portal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            sign_in sign_ = new sign_in();
            sign_.Show();
            this.Hide();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Avtorizate_Click(object sender, EventArgs e)
        {
            if(log_in.Text == "admin" && password.Text.ToString() == "123456789")
            {
                Main_admin main_Admin = new Main_admin();
                main_Admin.Show();
                this.Hide();
            }
            else if(log_in.Text == "user" && password.Text.ToString() == "123456789")
            {
                Main_user main = new Main_user();
                main.Show();
                this.Hide();
            }
        }

        private void log_in_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Avtorizate.PerformClick();
            }
        }
    }
}
