using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_portal.classes;

namespace test_portal.forms
{
    public partial class Create_acc : Form
    {
        private Account AccountObj { get; set; }
        public DataBaseOperation dataBaseOperation { get; set; }
        public Create_acc(Account newAccount)
        {
            InitializeComponent();
            AccountObj = newAccount;
            dataBaseOperation = new DataBaseOperation();
        }

        private void Create_acc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool isInputValid()
        {
            if (first_name.Text == "")
            {
                MessageBox.Show("first name empty");
                return false;
            }
            else if (last_name.Text == "")
            {
                MessageBox.Show("last name empty");
                return false;
            }
            else if (!IsAlphabetic(first_name.Text))
            {
                MessageBox.Show("last name not alphabetic");
                return false;
            }
            else if (!IsAlphabetic(last_name.Text))
            {
                MessageBox.Show("last name not alphabetic");
                return false;
            }
            return true;
        }

        private bool IsAlphabetic(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z]+$");
        }

        private void create_Click(object sender, EventArgs e)
        {
            AccountObj.FirstName = first_name.Text;
            AccountObj.LastName = last_name.Text;
            if (dataBaseOperation.RegisterNewAccount(AccountObj))
            {
                Main_user main_User = new Main_user();
                main_User.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error register","Error");
            }
        }

        private void first_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                last_name.Focus();
            }
        }

        private void last_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                create.PerformClick();
            }
        }
    }
}
