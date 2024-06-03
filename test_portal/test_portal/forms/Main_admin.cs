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
    public partial class Main_admin : Form
    {
        private Form activeForm;
        private DataBaseOperation dataBaseOperation { get; set; }
        private Account accountObj { get; set; }
        public Main_admin(Account accountObj)
        {
            InitializeComponent();
            dataBaseOperation = new DataBaseOperation();
            this.accountObj = accountObj;
            nametitle.Text = this.accountObj.LastName + "\n" + this.accountObj.FirstName;
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
        private void Main_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void create_test_Click_1(object sender, EventArgs e)
        {
            Create_test create_Test = new Create_test(this);
            OpenChildForm(create_Test, sender);
        }

        private void settings_Click_1(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            OpenChildForm(settings, sender);
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
