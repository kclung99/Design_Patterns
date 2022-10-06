using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class Logger: Handler
    {
        public Logger(Handler next) : base(next) { }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Request has been logged");

            return false;
        }
    }
}
