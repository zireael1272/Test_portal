using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_portal.Interfaces
{
    public interface ILoginInput
    {
        string Username { get; set; }
        string Password { get; set; }
    }
}
