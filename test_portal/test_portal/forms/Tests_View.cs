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
    public partial class Tests_View : Form
    {
        private DataBaseOperation dataBaseOperation { get; set; }
        private Main_user parentForm;
        private int UserID;
        public Tests_View(Main_user parentForm, int UserID)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            dataBaseOperation = new DataBaseOperation();
            this.UserID = UserID;
            AddGroup();
            LoadTests();
        }

        private void TableTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddGroup()
        {
            namegroupsort.Items.Add("-");
            namegroupsort.Items.Add("Math");
            namegroupsort.Items.Add("Biology");
            namegroupsort.Items.Add("Chemistry");
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
                int result = dataBaseOperation.GetTestResult(UserID, test.Item3);
                TableTests.Rows.Add(test.Item1, test.Item2, result == -1 ? "" : result.ToString());
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
                int number_answer = dataBaseOperation.GetNumberOfAnswers(testName, groupName);
                Run_Test run_Test = new Run_Test(UserID,testID, number_answer,parentForm);
                parentForm.OpenChildForm(run_Test, sender);
                this.Hide();
            }
        }

        private void namegroupsort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortTestsByGroup();
        }
    }
}
