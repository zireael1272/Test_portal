using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_portal.forms;
using System.Data.OleDb;

namespace test_portal
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void sign_in_FormClosing(object sender, FormClosingEventArgs e)
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
            else if (passwordagain.Text == "")
            {
                MessageBox.Show("password again empty");
                return false;
            }
            else if (passwordagain.Text != password.Text)
            {
                MessageBox.Show("password again does not match password");
                return false;
            }
            return true;
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (!isInputValid()) return;
            Create_acc create_Acc = new Create_acc();
            create_Acc.Show();
            this.Hide();
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
                passwordagain.Focus();
            }
        }

        private void passwordagain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                sign.PerformClick();
            }
        }

    }
}
