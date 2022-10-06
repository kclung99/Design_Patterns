using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class WebServer
    {
        private Handler _handler; // first handler in the pipeline

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            _handler.Handle(request);
        }
    }
}
