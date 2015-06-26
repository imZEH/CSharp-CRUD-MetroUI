using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Class
{
    public class user
    {
        private String name;
        private String gender;
        private String age;
        private String address;
        private String username;
        private String password;
        private String userType;

        public user(string user, string pass, string userType)
        {
            this.username = user;
            this.password = pass;
            this.userType = userType;
        }

        public String Name{ get; set; }
        public String Gender { get; set; }
        public String Age { get; set; }
        public String Address { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String UserType { get { return this.userType; } }
    }
}
