using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_portal.classes;

namespace test_portal.Interfaces
{
    public interface IDBOperations
    {
        void CloseConnection();
        IAccount GetAccountByUsername(ILoginInput input);
        bool RegisterNewAccount(IAccount newAccount);
        bool DoesLoginExist(string login);
        bool CreateTest(string testName, string groupName, int number_answers, int number_correct_answer);
        bool SaveQuestionToDatabase(int testID, string questionText, List<TextBox> answerTextBoxes, List<CheckBox> correctCheckBoxes);
        bool DoesQuestionExist(int testID, string questionText);
        int GetTestID(string testName, string groupName);
        List<Tuple<string, string, int>> GetAllTests();
        (int numberOfAnswers, int numberOfCorrectAnswers) GetNumberOfAnswersAndCorrectAnswers(string testName, string groupName);
        TestDetails GetTestDetails(int testID);
        bool SaveTestResult(int userID, int testID, double correctAnswersCount);
        double GetTestResult(int userID, int testID);
    }
}
