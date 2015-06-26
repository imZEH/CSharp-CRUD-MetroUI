using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Interface
{
    interface userInterface
    {
        void UserInsert(String name, String gender, String age, String address, String username, String password);
        void UserUpdate(int id, String name, String gender, String age, String address, String username, String password);
    }
}
