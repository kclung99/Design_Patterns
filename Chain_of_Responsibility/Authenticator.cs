using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next) { }
        protected override bool DoHandle(HttpRequest request)
        {
            if (request.GetUserName() == "KC" && request.GetPassword() == "1234")
                return false;

            return true;
        }
    }
}
