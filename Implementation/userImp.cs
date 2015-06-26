using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Interface;

namespace WindowsFormsApplication1.Implementation
{
    class userImp : userInterface
    {
        private MySqlConnection conn;

        public void UserInsert(String name, String gender, String age, String address, String username, String password)
        {
            try
            {
                String query = "INSERT INTO user(name,gender,age,address,username,password) VALUES(@name,@gender,@age,@address,@username,@password)";
                conn = Connection.getMysqlConnection();
                conn.Open();
                MySqlCommand SQLCMD = new MySqlCommand(query, conn);
                SQLCMD.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                SQLCMD.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                SQLCMD.Parameters.Add("@age", MySqlDbType.VarChar).Value = age;
                SQLCMD.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                SQLCMD.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                SQLCMD.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                SQLCMD.ExecuteNonQuery();
                conn.Close();
                MetroFramework.MetroMessageBox.Show(new users(), "Information successfuly saved", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(new users(), e.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UserUpdate(int id, String name, String gender, String age, String address, String username, String password) 
        {
            try
            {
                String query = "UPDATE user set name=@name, gender=@gender, age=@age, address=@address, username=@username, password=@password WHERE id=@id";
                conn = Connection.getMysqlConnection();
                conn.Open();
                MySqlCommand SQLCMD = new MySqlCommand(query, conn);
                SQLCMD.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                SQLCMD.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                SQLCMD.Parameters.Add("@age", MySqlDbType.VarChar).Value = age;
                SQLCMD.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                SQLCMD.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                SQLCMD.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                SQLCMD.Parameters.Add("@id", MySqlDbType.Int16).Value = id;
                SQLCMD.ExecuteNonQuery();
                conn.Close();
                MetroFramework.MetroMessageBox.Show(new users(), "Information successfuly saved", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(new users(), e.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
