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
            numberAnswers.Wrap = false;
            numberAnswers.Items.Add(6);
            numberAnswers.Items.Add(5);
            numberAnswers.Items.Add(4);
            numberAnswers.Items.Add(3);
            numberAnswers.Items.Add(2);
            numberAnswers.Items.Add(1);
            numberAnswers.Items.Add(0);
            numberAnswers.SelectedIndex = 6;
            AddGroup();
        }

        private void AddGroup()
        {
            namegroup.Items.Add("Math");
            namegroup.Items.Add("Biology");
            namegroup.Items.Add("Chemistry");
        }

        private void createTest_Click(object sender, EventArgs e)
        {
            if(NameTest.Text == "")
            {
                MessageBox.Show("Field name test empty", "Error");
                return;
            }
            else if (numberQuestion.Text == "")
            {
                MessageBox.Show("Field number question empty", "Error");
                return;
            }
            else if (numberAnswers.Text == "0")
            {
                MessageBox.Show("Field number answer incorrect", "Error");
                return;
            }
            else if (namegroup.Text == "")
            {
                MessageBox.Show("Field name group empty", "Error");
                return;
            }
            string nametest = NameTest.Text;
            string nameGroup = namegroup.Text;
            if (dataBaseOperation.CreateTest(nametest, nameGroup))
            {
                int testID = dataBaseOperation.GetTestID(nametest, nameGroup);
                int.TryParse(numberQuestion.Text, out int number_question);
                int.TryParse(numberAnswers.Text, out int number_answer);
                Form_for_question form_For_Question = new Form_for_question(testID, number_question, number_answer);
                this.parentForm.OpenChildForm(form_For_Question, sender);
            }
            else
            {
                MessageBox.Show("Error create test", "Error");
                return;
            }
        }
    }
}
