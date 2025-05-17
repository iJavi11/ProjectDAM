using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop
{
    public class LoginRequest
    {
        public string login { get; set; }
        public string password { get; set; }

        public LoginRequest(string username, string passwd)
        {
            login = username;
            password = passwd;
        }
    }
}
