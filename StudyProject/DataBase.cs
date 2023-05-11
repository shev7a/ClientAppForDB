using System.Data.SqlClient;

namespace StudyProject
{
    internal class DataBase
    {
        //Подключение к БД
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-P1SO7CU;Initial Catalog=KnowledgeTestingDB;Integrated Security=true");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
