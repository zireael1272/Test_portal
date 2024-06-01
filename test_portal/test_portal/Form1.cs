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

namespace test_portal
{
    public partial class login : Form
    {
        public DataBaseOperation dataBaseOperation { get; set; }
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
            Application.Exit();
        }

        private bool isInputValid()
        {
            if (log_in.Text == "")
            {
                MessageBox.Show("login empty");
                return false;
            }
            else if (password.Text == "")
            {
                MessageBox.Show("password empty");
                return false;
            }
            return true;
        }

        private void Avtorizate_Click(object sender, EventArgs e)
        {
            LoginInput input = new LoginInput(log_in.Text, password.Text);
            if (!isInputValid()) return;

            Account accountObj = dataBaseOperation.GetAccountByUsername(input);
            if (accountObj == null)
            {
                MessageBox.Show("Error", "Account not");
                return;
            }

            if(accountObj.Role == "Admin")
            {
                Main_admin main_Admin = new Main_admin();
                main_Admin.Show();
                this.Hide();
            }
            else if(accountObj.Role == "User")
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
