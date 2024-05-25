using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_portal.forms
{
    public partial class Create_acc : Form
    {
        public Create_acc()
        {
            InitializeComponent();
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
            Main_user main_User = new Main_user();
            main_User.Show();
            this.Hide();
        }
    }
}
