using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ControleDeTimes.DAO
{
    public class SqlConnection
    {
        private readonly String connectionString;

        public SqlConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;
        }

        public MySqlConnection Criar()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
