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
            namegroupsort.Items.Add("Math");
            namegroupsort.Items.Add("Biology");
            namegroupsort.Items.Add("Chemistry");
        }

        private void LoadTests()
        {
            var tests = dataBaseOperation.GetAllTests();
            foreach (var test in tests)
            {
                TableTests.Rows.Add(test.Item1, test.Item2);
            }
        }
        private void TableTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableTests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TableTests.Rows.Count)
            {
                DataGridViewRow row = TableTests.Rows[e.RowIndex];
                string testName = row.Cells["NameTest"].Value.ToString();
                string groupName = row.Cells["NameGroup"].Value.ToString();
                int testID = dataBaseOperation.GetTestID(testName, groupName);
                int number_answer = dataBaseOperation.GetNumberOfAnswers(testName, groupName);
                AddQuestionInTest addQuestionInTest = new AddQuestionInTest(testID, number_answer);
                parentForm.OpenChildForm(addQuestionInTest, sender);
                this.Hide();
            }
        }
    }
}
