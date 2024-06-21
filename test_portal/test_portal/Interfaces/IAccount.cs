using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_portal.Interfaces
{
    public interface IAccount
    {
        int Id { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Role { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
