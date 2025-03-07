using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datababaes_GoldenTamago.Services
{
    internal class Auth
    {
        public bool logInUser(string username, string password) {
            if (username.Equals("Admin") && password.Equals("Admin123"))
            {
                return true;
            } else if (username.Equals("Client") && password.Equals("Client123")) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
