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
using System.Data.OleDb;
using test_portal.classes;
using test_portal.Interfaces;

namespace test_portal
{
    public partial class login : Form
    {
        private DataBaseOperation dataBaseOperation { get; set; }
        public login()
        {
            InitializeComponent();
            dataBaseOperation = new DataBaseOperation();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            sign_in sign_ = new sign_in();
            sign_.Show();
            this.Hide();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            finally
            {
                dataBaseOperation.CloseConnection();
            }
        }

        private bool isInputValid()
        {
            if (string.IsNullOrWhiteSpace(log_in.Text))
            {
                MessageBox.Show("Login is empty");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Password is empty");
                return false;
            }
            return true;
        }

        private void Avtorizate_Click(object sender, EventArgs e)
        {
            if (!isInputValid()) return;

            ILoginInput input = new LoginInput(log_in.Text, password.Text);
            IAccount accountInterface = dataBaseOperation.GetAccountByUsername(input);

            if (accountInterface == null)
            {
                MessageBox.Show("Account not found", "Error");
                return;
            }

            Account accountObj = (Account)accountInterface;

            if (accountObj.Role == "Admin")
            {
                Main_admin main_Admin = new Main_admin(accountObj);
                main_Admin.Show();
                this.Hide();
            }
            else if (accountObj.Role == "User")
            {
                Main_user main = new Main_user(accountObj);
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

        private void lookpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (lookpassword.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }
    }
}
