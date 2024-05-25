using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace test_portal.classes
{
    internal class Data_Base
    {
        public Data_Base()
        {
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/User/Desktop/Test_portal/DB_test.mdb";
            OleDbConnection dbConnected = new OleDbConnection(connection);
            dbConnected.Open();
            string query = "SELECT * FROM table_name";
            OleDbCommand dbCommand = new OleDbCommand();
            OleDbDataReader dbDataReader = dbCommand.ExecuteReader();

            if (dbDataReader.HasRows == false)
            {
                MessageBox.Show("Data not fount!", "Error");
            }
        }
    }
}
