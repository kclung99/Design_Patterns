using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class Program
    {
        // Client: WebServer
        // Handler: Handler
        // ConcreteHandler1: Authenticator
        // ConcreteHandler2: Logger

        static void Main(string[] args)
        {
            var request1 = new HttpRequest("KC", "1234");
            var request2 = new HttpRequest("00", "0000");
            var logger = new Logger(null);
            var authenticator = new Authenticator(logger);
            var webServer = new WebServer(authenticator);

            webServer.Handle(request1);
            webServer.Handle(request2);
        }
    }
}
