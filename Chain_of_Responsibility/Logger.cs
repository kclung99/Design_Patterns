using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class Logger: Handler
    {
        public Logger(Handler request) : base(request) { }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Request has been logged");

            return false;
        }
    }
}
