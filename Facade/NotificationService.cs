using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ipAdress");
            var token = server.Authenticate("KC", "1234");
            server.Send(token, message, target);
            connection.Disconnect();
        }
    }
}
