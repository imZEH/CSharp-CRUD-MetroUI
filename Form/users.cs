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
using WindowsFormsApplication1.Implementation;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.List;

namespace WindowsFormsApplication1
{
    public partial class users : MetroForm
    {
        public users()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userImp u = new userImp();
            u.User(name.Text, gender.Text, age.Text, address.Text, uname.Text, pass.Text);
        }
    }
}
