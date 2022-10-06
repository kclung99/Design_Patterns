using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class NotificationServer
    {
        public Connection Connect(string ip)
        {
            return new Connection();
        }

        public AuthenticationToken Authenticate(string id , string password)
        {
            return new AuthenticationToken();
        }

        public void Send (AuthenticationToken token, string message, string target)
        {
            Console.WriteLine(message + " has been sent to: " + target);
        }
    }
}
