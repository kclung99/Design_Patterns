using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class HttpRequest
    {
        private string _userName;
        private string _password;

        public HttpRequest(string userName, string password)
        {
            _userName = userName;
            _password = password;
        }

        public string GetUserName()
        {
            return _userName;
        }

        public string GetPassword()
        {
            return _password;
        }

    }
}
