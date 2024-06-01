using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_portal.classes;
using test_portal.forms;

namespace test_portal
{
    public partial class Main_user : Form
    {
        private Form activeForm;
        private Account accountObj { get; set; }
        public Main_user(Account accountObj)
        {
            InitializeComponent();
            this.accountObj = accountObj;
            nametitle.Text = this.accountObj.LastName + "\n" + this.accountObj.FirstName;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        public void OpenChildForm(Form childform, object Sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childform);
            this.panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }


        private void tests_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click_1(object sender, EventArgs e)
        {
            Settings_user settings_User = new Settings_user();
            OpenChildForm(settings_User, sender);
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form form in formsToClose)
            {
                if (form != this)
                {
                    form.Close();
                }
            }

            Thread thread = new Thread(() =>
            {
                Application.Run(new login());
            });

            thread.Start();
        }
    }
}
