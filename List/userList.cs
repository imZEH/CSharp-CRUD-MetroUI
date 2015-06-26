using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Class;

namespace WindowsFormsApplication1.List
{
    public class userList : Exception
    {
        private MySqlConnection conn;
        public List<user> getuserType(String uname, String pass)
        {
            conn = Connection.getMysqlConnection();
            List<user> datalist = new List<user>();
            String select = "SELECT username,password,userType FROM user Where username= '"+ uname + "' AND password = '" + pass + "'";
            conn.Open();
            MySqlCommand selcmd = new MySqlCommand(select, conn);
            MySqlDataReader dataReader = selcmd.ExecuteReader();
            dataReader.Read();
            if (dataReader.HasRows)
            {
                string username = dataReader["username"].ToString();
                string password = dataReader["password"].ToString();
                string userType = dataReader["userType"].ToString();

                user u = new user(username, password, userType);
                datalist.Add(u);
            }

            dataReader.Close();
            conn.Close();

            return datalist;
        }
    }
}
