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
            String select = "SELECT username,password,userType FROM user Where username= @uname AND password = @pass";
            conn.Open();
            MySqlCommand SQLCMD = new MySqlCommand(select, conn);
            SQLCMD.Parameters.Add("@uname", MySqlDbType.VarChar).Value = uname;
            SQLCMD.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            MySqlDataReader dataReader = SQLCMD.ExecuteReader();
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
        
        public List<user> getUsers()
        {
            conn = Connection.getMysqlConnection();
            List<user> datalist = new List<user>();
            String select = "SELECT * FROM user";
            conn.Open();
            MySqlCommand SQLCMD = new MySqlCommand(select, conn);
            MySqlDataReader dataReader = SQLCMD.ExecuteReader();
            while (dataReader.Read())
            {
                int id = Convert.ToInt32(dataReader["id"]);
                String name = dataReader["name"].ToString();
                String gender = dataReader["gender"].ToString();
                String age = dataReader["age"].ToString();
                String address = dataReader["address"].ToString();
                String username = dataReader["username"].ToString();
                String password = dataReader["password"].ToString();
                String userType = dataReader["userType"].ToString();

                user u = new user(id, name, gender, age, address, username, password, userType);
                datalist.Add(u);
            }

            dataReader.Close();
            conn.Close();

            return datalist;
        }
    }
}
