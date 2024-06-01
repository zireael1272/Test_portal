using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_portal.classes
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


        public Account(int id, string Username, string Password, string Role)
        {
            this.Id = id;
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
        }
    }
}

