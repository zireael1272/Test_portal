using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_portal.classes;
using test_portal.forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_portal.forms
{
    public partial class Create_test : Form
    {
        private Main_admin parentForm;
        private DataBaseOperation dataBaseOperation { get; set; }
        public Create_test(Main_admin parentForm)
        {
            InitializeComponent();
            dataBaseOperation = new DataBaseOperation();
            this.parentForm = parentForm;
            AddNumberAnswer();
            AddGroup();
        }

        private void AddGroup()
        {
            namegroup.Items.Add("Math");
            namegroup.Items.Add("Biology");
            namegroup.Items.Add("Chemistry");
            namegroup.Items.Add("Programming");
            namegroup.Items.Add("Physicists");
        }

        private void AddNumberAnswer()
        {
            numberAnswers.Wrap = false;
            numberAnswers.Items.Add(6);
            numberAnswers.Items.Add(5);
            numberAnswers.Items.Add(4);
            numberAnswers.Items.Add(3);
            numberAnswers.Items.Add(2);
            numberAnswers.Items.Add(1);
            numberAnswers.Items.Add(0);
            numberAnswers.SelectedIndex = 6;

            number_correct_answer.Wrap = false;
            number_correct_answer.Items.Add(6);
            number_correct_answer.Items.Add(5);
            number_correct_answer.Items.Add(4);
            number_correct_answer.Items.Add(3);
            number_correct_answer.Items.Add(2);
            number_correct_answer.Items.Add(1);
            number_correct_answer.Items.Add(0);
            number_correct_answer.SelectedIndex = 6;
        }

        private bool InputisInputValid()
        {
            int.TryParse(number_correct_answer.Text, out int nca);
            int.TryParse(numberAnswers.Text, out int na);
            if (NameTest.Text == "")
            {
                MessageBox.Show("Field name test empty", "Error");
                return false;
            }
            else if (numberAnswers.Text == "0")
            {
                MessageBox.Show("Field number answer incorrect", "Error");
                return false;
            }
            else if (namegroup.Text == "")
            {
                MessageBox.Show("Field name group empty", "Error");
                return false;
            }
            else if(nca > na)
            {
                MessageBox.Show("the number of correct answers cannot exceed the number of answers", "Error");
                return false;
            }
            return true;
        }

        private void createTest_Click(object sender, EventArgs e)
        {
            if (!InputisInputValid())
                return;

            string nametest = NameTest.Text;
            string nameGroup = namegroup.Text;
            int.TryParse(numberAnswers.Text, out int number_answers);
            int.TryParse(number_correct_answer.Text, out int numbercorrectanswer);
            if (dataBaseOperation.CreateTest(nametest, nameGroup, number_answers, numbercorrectanswer))
            {
                int testID = dataBaseOperation.GetTestID(nametest, nameGroup);
                int.TryParse(numberAnswers.Text, out int number_answer);
                Form_for_question form_For_Question = new Form_for_question(testID, number_answer, numbercorrectanswer);
                this.parentForm.OpenChildForm(form_For_Question, sender);
            }
            else
            {
                MessageBox.Show("Error create test", "Error");
                return;
            }
        }

        private void NameTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                namegroup.Focus();
            }
        }

        private void numberAnswers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                createTest.PerformClick();
            }
        }
    }
}
