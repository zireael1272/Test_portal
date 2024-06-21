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

namespace test_portal.forms
{
    public partial class Change_test : Form
    {
        private DataBaseOperation dataBaseOperation { get; set; }
        private Main_admin parentForm;

        public Change_test(Main_admin parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            dataBaseOperation = new DataBaseOperation();
            AddGroup();
            LoadTests();
        }

        private void AddGroup()
        {
            namegroupsort.Items.Add("-");
            namegroupsort.Items.Add("Math");
            namegroupsort.Items.Add("Biology");
            namegroupsort.Items.Add("Chemistry");
            namegroupsort.Items.Add("Programming");
            namegroupsort.Items.Add("Physicists");
        }

        private void SortTestsByGroup()
        {
            string selectedGroup = namegroupsort.SelectedItem.ToString();

            TableTests.Rows.Clear();
            var tests = dataBaseOperation.GetAllTests();
            foreach (var test in tests)
            {
                if (selectedGroup == "-" || test.Item2 == selectedGroup)
                {
                    TableTests.Rows.Add(test.Item1, test.Item2);
                }
            }
        }

        private void LoadTests()
        {
            var tests = dataBaseOperation.GetAllTests();
            foreach (var test in tests)
            {
                TableTests.Rows.Add(test.Item1, test.Item2);
            }
        }

        private void TableTests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TableTests.Rows.Count)
            {
                DataGridViewRow row = TableTests.Rows[e.RowIndex];
                string testName = row.Cells["NameTest"].Value.ToString();
                string groupName = row.Cells["NameGroup"].Value.ToString();
                int testID = dataBaseOperation.GetTestID(testName, groupName);
                int number_answer, number_correct_answer;
                (number_answer, number_correct_answer) = dataBaseOperation.GetNumberOfAnswersAndCorrectAnswers(testName, groupName);
                Form_for_question form_For_Questioт = new Form_for_question(testID, number_answer, number_correct_answer);
                parentForm.OpenChildForm(form_For_Questioт, sender);
                this.Hide();
            }     
        }

        private void namegroupsort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortTestsByGroup();
        }

        private void TableTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
