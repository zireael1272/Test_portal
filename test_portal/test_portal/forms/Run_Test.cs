using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_portal.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_portal.forms
{
    public partial class Run_Test : Form
    {
        private DataBaseOperation dataBaseOperation { get; set; }
        private int testID;
        private int number_answer;
        private int number_correct_answer;
        private TestDetails testDetails;
        private int currentQuestionIndex = 0;
        private double correctAnswersCount = 0;
        private List<CheckBox> answer = new List<CheckBox>();
        private int UserID;
        private Main_user parentForm;

        public Run_Test(int userID, int testID, int number_answer, int number_correct_answer, Main_user parentForm)
        {
            InitializeComponent();
            dataBaseOperation = new DataBaseOperation();
            this.testID = testID;
            this.number_answer = number_answer;
            this.number_correct_answer = number_correct_answer;
            this.UserID = userID;
            this.parentForm = parentForm;
            CreateFieldAnswer();
            testDetails = dataBaseOperation.GetTestDetails(testID);
            Random rnd = new Random();
            testDetails.Questions = testDetails.Questions.OrderBy(q => rnd.Next()).ToList();
            DisplayQuestion(this);
        }

        private void CreateFieldAnswer()
        {
            foreach (var checkBox in answer)
            {
                this.Controls.Remove(checkBox);
            }
            answer.Clear();

            for (int i = 0; i < number_answer; i++)
            {
                var checkBox = new CheckBox
                {
                    Top = 112 + (i * 40),
                    Left = 135,
                    AutoSize = true
                };
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                this.Controls.Add(checkBox);
                answer.Add(checkBox);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (answer.Count(cb => cb.Checked) > number_correct_answer)
            {
                ((CheckBox)sender).Checked = false;
            }
        }

        private void DisplayQuestion(object sender)
        {
            for (int i = 0; i < answer.Count; i++)
            {
                answer[i].Checked = false;
            }

            if (currentQuestionIndex < testDetails.Questions.Count)
            {
                var currentQuestion = testDetails.Questions[currentQuestionIndex];
                textQuestion.Text = currentQuestion.QuestionText;
                for (int i = 0; i < number_answer; i++)
                {
                    if (i < currentQuestion.Answers.Count)
                    {
                        answer[i].Text = currentQuestion.Answers[i].AnswerText;
                        answer[i].Tag = currentQuestion.Answers[i].IsCorrect;
                    }
                }
                questionbyquestions.Text = $"{currentQuestionIndex + 1}/{testDetails.Questions.Count}";
            }
            else
            {
                dataBaseOperation.SaveTestResult(UserID, testID, correctAnswersCount);
                MessageBox.Show("Test finished.", "Test Result");
                Tests_View tests_View = new Tests_View(parentForm, UserID);
                parentForm.OpenChildForm(tests_View, sender);
                this.Hide();
            }
        }

        private void CheckAnswers()
        {
            var currentQuestion = testDetails.Questions[currentQuestionIndex];
            int correctCount = currentQuestion.Answers.Count(a => a.IsCorrect);
            int selectedCorrectCount = 0;

            for (int i = 0; i < answer.Count; i++)
            {
                bool isChecked = answer[i].Checked;
                bool isCorrect = (bool)answer[i].Tag;

                if (isChecked && isCorrect)
                {
                    selectedCorrectCount++;
                }
            }

            if (selectedCorrectCount > 0)
            {
                double fractionCorrect = (double)selectedCorrectCount / correctCount;
                correctAnswersCount += fractionCorrect;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            CheckAnswers();
            currentQuestionIndex++;
            DisplayQuestion(sender);
        }
    }
}
