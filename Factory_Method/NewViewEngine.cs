using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class NewViewEngine : IViewEngine
    {
        public void Render(string viewName, Dictionary<string, string> context)
        {
            Console.WriteLine(viewName + " rendered by new");
        }
    }
}
