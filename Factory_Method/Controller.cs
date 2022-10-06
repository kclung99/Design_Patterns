using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public abstract class Controller
    {
        public void Render(string viewName, Dictionary<string, string> context)
        {
            var viewEngine = CreateViewEngine();
            viewEngine.Render(viewName, context);
        }

        protected abstract IViewEngine CreateViewEngine();
    }
}
