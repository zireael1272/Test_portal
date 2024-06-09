using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections;
using static test_portal.classes.TestDetails;

namespace test_portal.classes
{
    public class DataBaseOperation
    {
        private readonly OleDbConnection _dbConnection;
        public DataBaseOperation()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/User/Desktop/Test_portal/Test_portal/DB_test.accdb";
            _dbConnection = new OleDbConnection(connectionString);

            try
            {
                _dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open database connection: {ex.Message}", "Error");
            }
        }

        public Account GetAccountByUsername(LoginInput input)
        {
            if (_dbConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.", "Error");
                return null;
            }

            string query = "SELECT UserID, Username, Password, Role, FirstName, LastName FROM Users WHERE Username = ? AND Password = ?";
            try
            {
                using (OleDbCommand dbCommand = new OleDbCommand(query, _dbConnection))
                {
                    dbCommand.Parameters.AddWithValue("Username", input.Username);
                    dbCommand.Parameters.AddWithValue("Password", input.Password);
                    using (OleDbDataReader dbDataReader = dbCommand.ExecuteReader())
                    {
                        if (dbDataReader.Read())
                        {
                            int id = Convert.ToInt32(dbDataReader["UserID"]);
                            string dbUsername = dbDataReader["Username"].ToString();
                            string dbPassword = dbDataReader["Password"].ToString();
                            string dbRole = dbDataReader["Role"].ToString();
                            string dbFirstName = dbDataReader["FirstName"].ToString();
                            string dbLastName = dbDataReader["LastName"].ToString();
                            return new Account(id, dbUsername, dbPassword, dbRole, dbFirstName, dbLastName);
                        }
                        else
                        {
                            MessageBox.Show("User not found!", "Error");
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
                return null;
            }
        }

        public bool RegisterNewAccount(Account newAccount)
        {
            if (_dbConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.", "Error");
                return false;
            }

            string query = "INSERT INTO Users (Username, [Password], [Role], FirstName, LastName) VALUES (?, ?, ?, ?, ?)";
            try
            {
                using (OleDbCommand dbCommand = new OleDbCommand(query, _dbConnection))
                {
                    dbCommand.Parameters.AddWithValue("Username", newAccount.Username);
                    dbCommand.Parameters.AddWithValue("Password", newAccount.Password);
                    dbCommand.Parameters.AddWithValue("Role", newAccount.Role);
                    dbCommand.Parameters.AddWithValue("FirstName", newAccount.FirstName);
                    dbCommand.Parameters.AddWithValue("LastName", newAccount.LastName);

                    int rowsAffected = dbCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account registered successfully.", "Success");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to register account.", "Error");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
                return false;
            }
        }

        public bool CreateTest(string testName, string groupName, int number_answers)
        {
            if (_dbConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.", "Error");
                return false;
            }

            try
            {
                // Check if the test already exists
                string checkQuery = "SELECT COUNT(*) FROM NameTest WHERE [Name] = ? AND [Group] = ?";
                using (OleDbCommand checkCommand = new OleDbCommand(checkQuery, _dbConnection))
                {
                    checkCommand.Parameters.AddWithValue("?", testName);
                    checkCommand.Parameters.AddWithValue("?", groupName);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("A test with the same name and group already exists.", "Error");
                        return false;
                    }
                }

                string queryTest = "INSERT INTO NameTest ([Name], [Group]) VALUES (?, ?)";
                using (OleDbCommand commandTest = new OleDbCommand(queryTest, _dbConnection))
                {
                    commandTest.Parameters.AddWithValue("?", testName);
                    commandTest.Parameters.AddWithValue("?", groupName);
                    commandTest.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
                return false;
            }
        }

        public bool SaveQuestionToDatabase(int testID, string questionText, List<TextBox> answerTextBoxes, List<CheckBox> correctCheckBoxes)
        {
            if (_dbConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.", "Error");
                return false;
            }

            OleDbTransaction transaction = _dbConnection.BeginTransaction();

            try
            {
                string queryQuestion = "INSERT INTO QuestionTests (TestID, Question) VALUES (?, ?)";
                using (OleDbCommand commandQuestion = new OleDbCommand(queryQuestion, _dbConnection))
                {
                    commandQuestion.Transaction = transaction;
                    commandQuestion.Parameters.AddWithValue("?", testID);
                    commandQuestion.Parameters.AddWithValue("?", questionText);
                    commandQuestion.ExecuteNonQuery();
                }

                string queryQuestionID = "SELECT @@IDENTITY";
                int questionID;
                using (OleDbCommand commandQuestionID = new OleDbCommand(queryQuestionID, _dbConnection))
                {
                    commandQuestionID.Transaction = transaction;
                    questionID = (int)commandQuestionID.ExecuteScalar();
                }

                string queryAnswer = "INSERT INTO Answers (NumberQuestion, Answer, IsCorrect) VALUES (?, ?, ?)";
                using (OleDbCommand commandAnswer = new OleDbCommand(queryAnswer, _dbConnection))
                {
                    commandAnswer.Transaction = transaction;

                    for (int i = 0; i < answerTextBoxes.Count; i++)
                    {
                        commandAnswer.Parameters.Clear();
                        commandAnswer.Parameters.AddWithValue("?", questionID);
                        commandAnswer.Parameters.AddWithValue("?", answerTextBoxes[i].Text);
                        commandAnswer.Parameters.AddWithValue("?", correctCheckBoxes[i].Checked);
                        commandAnswer.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"{ex.Message}", "Error");
                return false;
            }
        }

        public int GetTestID(string testName, string groupName)
        {
            if (_dbConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.", "Error");
                return -1;
            }

            try
            {
                string query = "SELECT TestID FROM NameTest WHERE [Name] = ? AND [Group] = ?";
                using (OleDbCommand command = new OleDbCommand(query, _dbConnection))
                {
                    command.Parameters.AddWithValue("?", testName);
                    command.Parameters.AddWithValue("?", groupName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
                return -1;
            }
        }

        public List<Tuple<string, string, int>> GetAllTests()
        {
            var tests = new List<Tuple<string, string, int>>();
            string query = "SELECT TestID, Name, [Group] FROM NameTest";
            using (OleDbCommand command = new OleDbCommand(query, _dbConnection))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int testID = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string group = reader.GetString(2);
                        tests.Add(new Tuple<string, string, int>(name, group, testID));
                    }
                }
            }
            return tests;
        }

        public int GetNumberOfAnswers(string testName, string groupName)
        {
            if (_dbConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.", "Error");
                return 0;
            }

            string query = "SELECT NumberAnswers FROM NameTest WHERE [Name] = ? AND [Group] = ?";
            try
            {
                using (OleDbCommand dbCommand = new OleDbCommand(query, _dbConnection))
                {
                    dbCommand.Parameters.AddWithValue("?", testName);
                    dbCommand.Parameters.AddWithValue("?", groupName);
                    int numberOfAnswers = (int)dbCommand.ExecuteScalar();
                    return numberOfAnswers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
                return 0;
            }
        }

        public TestDetails GetTestDetails(int testID)
        {
            TestDetails testDetails = new TestDetails();
            if (_dbConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.", "Error");
                return testDetails;
            }

            try
            {
                string queryQuestions = "SELECT NumberQuestion, Question FROM QuestionTests WHERE TestID = ?";
                using (OleDbCommand commandQuestions = new OleDbCommand(queryQuestions, _dbConnection))
                {
                    commandQuestions.Parameters.AddWithValue("?", testID);
                    using (OleDbDataReader readerQuestions = commandQuestions.ExecuteReader())
                    {
                        while (readerQuestions.Read())
                        {
                            int questionID = int.Parse(readerQuestions["NumberQuestion"].ToString());
                            string questionText = readerQuestions["Question"].ToString();
                            testDetails.Questions.Add(new QuestionDetails { QuestionID = questionID, QuestionText = questionText });
                        }
                    }
                }

                foreach (var question in testDetails.Questions)
                {
                    string queryAnswers = "SELECT Answer, IsCorrect FROM Answers WHERE NumberQuestion = ?";
                    using (OleDbCommand commandAnswers = new OleDbCommand(queryAnswers, _dbConnection))
                    {
                        commandAnswers.Parameters.AddWithValue("?", question.QuestionID);
                        using (OleDbDataReader readerAnswers = commandAnswers.ExecuteReader())
                        {
                            while (readerAnswers.Read())
                            {
                                string answerText = readerAnswers["Answer"].ToString();
                                bool isCorrect = bool.Parse(readerAnswers["IsCorrect"].ToString());
                                question.Answers.Add(new AnswerDetails { AnswerText = answerText, IsCorrect = isCorrect });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
            }

            return testDetails;
        }

        public bool SaveTestResult(int userID, int testID, int correctAnswersCount)
        {
            if (_dbConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.", "Error");
                return false;
            }

            try
            {
                string queryCheck = "SELECT COUNT(*) FROM UsersResult WHERE UserID = ? AND TestID = ?";
                using (OleDbCommand commandCheck = new OleDbCommand(queryCheck, _dbConnection))
                {
                    commandCheck.Parameters.AddWithValue("UserID", userID);
                    commandCheck.Parameters.AddWithValue("TestID", testID);
                    int count = (int)commandCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        string queryUpdate = "UPDATE UsersResult SET Result = ? WHERE UserID = ? AND TestID = ?";
                        using (OleDbCommand commandUpdate = new OleDbCommand(queryUpdate, _dbConnection))
                        {
                            commandUpdate.Parameters.AddWithValue("Result", correctAnswersCount);
                            commandUpdate.Parameters.AddWithValue("UserID", userID);
                            commandUpdate.Parameters.AddWithValue("TestID", testID);
                            commandUpdate.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string queryInsert = "INSERT INTO UsersResult (UserID, TestID, Result) VALUES (?, ?, ?)";
                        using (OleDbCommand commandInsert = new OleDbCommand(queryInsert, _dbConnection))
                        {
                            commandInsert.Parameters.AddWithValue("UserID", userID);
                            commandInsert.Parameters.AddWithValue("TestID", testID);
                            commandInsert.Parameters.AddWithValue("Result", correctAnswersCount);
                            commandInsert.ExecuteNonQuery();
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
                return false;
            }
        }

        public int GetTestResult(int userID, int testID)
        {
            string query = "SELECT Result FROM UsersResult WHERE UserID = ? AND TestID = ?";
            using (OleDbCommand command = new OleDbCommand(query, _dbConnection))
            {
                command.Parameters.AddWithValue("UserID", userID);
                command.Parameters.AddWithValue("TestID", testID);
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
    }
}
