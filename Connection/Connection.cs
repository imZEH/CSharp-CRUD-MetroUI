using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class Connection : Exception
    {
        public static MySqlConnection getMysqlConnection()
        {
            String server = "localhost";
            String database = "Csharp";
            String uid = "root";
            String password = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
