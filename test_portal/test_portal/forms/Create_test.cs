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

namespace test_portal.forms
{
    public partial class Create_test : Form
    {
        private Main_admin parentForm;
        public Create_test(Main_admin parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            numberAnswers.Wrap = false;
            numberAnswers.Items.Add(6);
            numberAnswers.Items.Add(5);
            numberAnswers.Items.Add(4);
            numberAnswers.Items.Add(3);
            numberAnswers.Items.Add(2);
            numberAnswers.Items.Add(1);
            numberAnswers.Items.Add(0);
            numberAnswers.SelectedIndex = 6;
        }


        private void createTest_Click(object sender, EventArgs e)
        {
            int.TryParse(numberQuestion.Text, out int number_question);
            int.TryParse(numberAnswers.Text, out int number_answer);
            Form_for_question form_For_Question = new Form_for_question(number_question, number_answer);
            this.parentForm.OpenChildForm(form_For_Question, sender);
        }
    }
}
