using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public abstract class Handler
    {
        private Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                Console.WriteLine("Pipeline aborted");
                return;
            }
            if (_next != null)
                _next.Handle(request);
        }

        protected abstract bool DoHandle(HttpRequest request);
    }
}
