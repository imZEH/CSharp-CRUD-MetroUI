using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Class;
using WindowsFormsApplication1.List;

namespace WindowsFormsApplication1
{
    public partial class loginForm : MetroForm
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            List<user> sList = new List<user>();
            userList u = new userList();
            sList = u.getuserType(uname.Text, pass.Text);
            String type= null;
            for (int i = 0; i < sList.Count; i++)
            {
                type = sList[i].UserType;
            }

            if (type == "ADMINISTRATOR")
            {
                users frm = new users();
                frm.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Username and Password does not match", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
