using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    class DB
    {
        static private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R47Q6UC\\SQLEXPRESS;Initial Catalog=Fnproj;Integrated Security=True");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closedConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

    }
}
