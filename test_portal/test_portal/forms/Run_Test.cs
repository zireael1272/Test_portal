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
        private TestDetails testDetails;
        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;
        private List<CheckBox> answer = new List<CheckBox>();
        private int UserID;
        private Main_user parentForm;

        public Run_Test(int userID, int testID, int number_answer, Main_user parentForm)
        {
            InitializeComponent();
            dataBaseOperation = new DataBaseOperation();
            this.testID = testID;
            this.number_answer = number_answer;
            this.UserID = userID;
            this.parentForm = parentForm;
            CreateFieldAnswer();
            testDetails = dataBaseOperation.GetTestDetails(testID);
            DisplayQuestion();
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
                this.Controls.Add(checkBox);
                answer.Add(checkBox);
            }
        }

        private void DisplayQuestion()
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
                this.Hide();
            }
        }

        private void CheckAnswers()
        {
            var currentQuestion = testDetails.Questions[currentQuestionIndex];
            bool allCorrect = true;

            for (int i = 0; i < currentQuestion.Answers.Count; i++)
            {
                bool isChecked = answer[i].Checked;
                bool isCorrect = (bool)answer[i].Tag;

                if (isChecked != isCorrect)
                {
                    allCorrect = false;
                }
            }

            if (allCorrect)
            {
                correctAnswersCount++;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            CheckAnswers();
            currentQuestionIndex++;
            DisplayQuestion();
        }
    }
}
