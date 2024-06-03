using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_portal.forms
{
    public partial class Form_for_question : Form
    {
        private int number_question;
        private int number_answer;

        private List<TextBox> answerTextBoxes = new List<TextBox>();
        private List<CheckBox> correctCheckBoxes = new List<CheckBox>();
        private List<Label> answerLabels = new List<Label>();

        public Form_for_question(int number_question, int number_answer)
        {
            InitializeComponent();
            this.number_question = number_question;
            this.number_answer = number_answer;
            CreateFieldAnswer(this.number_question, this.number_answer);
        }

        private void CreateFieldAnswer(int number_question, int number_answer)
        {
            for (int i = 0; i < number_answer; i++)
            {
                // Додавання Label
                var label = new Label
                {
                    Text = $"{i + 1}",
                    Top = 95 + (i * 40),
                    Left = 30,
                    Width = 10
                };
                this.Controls.Add(label);
                answerLabels.Add(label);

                // Додавання TextBox
                var textBox = new TextBox
                {
                    Top = 110 + (i * 40),
                    Left = 30,
                    Width = 220
                };
                this.Controls.Add(textBox);
                answerTextBoxes.Add(textBox);

                // Додавання CheckBox
                var checkBox = new CheckBox
                {
                    Top = 109 + (i * 40),
                    Left = 270
                };
                this.Controls.Add(checkBox);
                correctCheckBoxes.Add(checkBox);
            }
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
             
        }
    }
}
