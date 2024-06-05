using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_portal.classes;

namespace test_portal.forms
{
    public partial class Form_for_question : Form
    {
        private int number_answer;
        private int testID;
        private List<TextBox> answerTextBoxes = new List<TextBox>();
        private List<CheckBox> correctCheckBoxes = new List<CheckBox>();
        private List<Label> answerLabels = new List<Label>();
        private DataBaseOperation dataBaseOperation { get; set; }

        public Form_for_question(int testID, int number_answer)
        {
            InitializeComponent();
            this.testID = testID;
            this.number_answer = number_answer;
            CreateFieldAnswer(this.number_answer);
            dataBaseOperation = new DataBaseOperation();
        }

        private void CreateFieldAnswer(int number_answer)
        {
            foreach (var label in answerLabels)
            {
                this.Controls.Remove(label);
            }
            foreach (var textBox in answerTextBoxes)
            {
                this.Controls.Remove(textBox);
            }
            foreach (var checkBox in correctCheckBoxes)
            {
                this.Controls.Remove(checkBox);
            }
            answerLabels.Clear();
            answerTextBoxes.Clear();
            correctCheckBoxes.Clear();

            for (int i = 0; i < number_answer; i++)
            {
                var label = new Label
                {
                    Text = $"{i + 1}",
                    Top = 112 + (i * 40),
                    Left = 135,
                    Width = 10
                };
                this.Controls.Add(label);
                answerLabels.Add(label);

                var textBox = new TextBox
                {
                    Top = 110 + (i * 40),
                    Left = 160,
                    Width = 220,
                    Font = new Font("Arial", 10)
                };
                this.Controls.Add(textBox);
                answerTextBoxes.Add(textBox);


                var checkBox = new CheckBox
                {
                    Top = 109 + (i * 40),
                    Left = 400
                };
                this.Controls.Add(checkBox);
                correctCheckBoxes.Add(checkBox);
            }
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            string questionText = textQuestion.Text;
            if (dataBaseOperation.SaveQuestionToDatabase(testID, questionText, answerTextBoxes, correctCheckBoxes))
            {
                textQuestion.Clear();
                foreach (var textBox in answerTextBoxes)
                {
                    textBox.Clear();
                }
                foreach (var checkBox in correctCheckBoxes)
                {
                    checkBox.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Error saving question and answers", "Error");
            }
        }
    }
}
