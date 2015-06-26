using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Class
{
    public class user
    {
        private int id;
        private String name;
        private String gender;
        private String age;
        private String address;
        private String username;
        private String password;
        private String userType;

        public user(int id, String name, String gender, String age, String address, String username, String password, String userType)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.username = username;
            this.password = password;
            this.userType = userType;
        }

        public user(string user, string pass, string userType)
        {
            this.username = user;
            this.password = pass;
            this.userType = userType;
        }

        public int Id { get { return id; } }
        public String Name { get { return this.name; } }
        public String Gender { get { return this.gender; } }
        public String Age { get { return this.age; } }
        public String Address{ get { return address; } set { address = value; } }
        public String Username { get { return username; } set { username = value; } }
        public String Password { get { return password; } set { password = value; } }
        public String UserType { get { return userType; } set { userType = value; } }
    }
}
