using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_portal.classes
{
    public class TestDetails
    {
        public List<QuestionDetails> Questions { get; set; } = new List<QuestionDetails>();
        public class QuestionDetails
        {
            public int QuestionID { get; set; }
            public string QuestionText { get; set; }
            public List<AnswerDetails> Answers { get; set; } = new List<AnswerDetails>();
        }

        public class AnswerDetails
        {
            public string AnswerText { get; set; }
            public bool IsCorrect { get; set; }
        }
    }
}
