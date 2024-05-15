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

namespace test_portal
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void sign_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void first_name_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void sign_Click(object sender, EventArgs e)
        {
            Create_acc create_Acc = new Create_acc();
            create_Acc.Show();
            this.Hide();
        }
    }
}
