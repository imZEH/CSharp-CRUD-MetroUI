using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Class;
using WindowsFormsApplication1.Implementation;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.List;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class users : MetroForm
    {
        List<user> sList = new List<user>();
        int userID = 0;

        public users()
        {
            InitializeComponent();
            getUserList();
        }

        public void getUserList()
        {
            sList.ForEach(i => Debug.Print("{0}\t", i));
            userList u = new userList();
            sList = u.getUsers();
            userGrid.Rows.Clear();
            foreach (var item in sList) 
            {
                DataGridViewRow row = (DataGridViewRow)userGrid.RowTemplate.Clone();
                row.CreateCells(userGrid, item.Name, item.Age, item.Gender,item.Address,item.UserType);
                userGrid.Rows.Add(row);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (userID == 0)
            {
                userImp u = new userImp();
                u.UserInsert(name.Text, gender.Text, age.Text, address.Text, uname.Text, pass.Text);
                getUserList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            userImp u = new userImp();
            u.UserUpdate(userID, name.Text, gender.Text, age.Text, address.Text, uname.Text, pass.Text);
            getUserList();
        }

        private void userGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;//get the Row Index
            userID = sList[i].Id;
            name.Text = sList[i].Name;
            address.Text = sList[i].Address;
            age.Text = sList[i].Age;
            gender.Text = sList[i].Gender;
            uname.Text = sList[i].Username;
            pass.Text = sList[i].Password;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = userGrid.CurrentCell.RowIndex;
            userImp u = new userImp();
            u.UserDelete(sList[rowIndex].Id);
            getUserList();
        }
    }
}
