using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public interface IViewEngine
    {
        void Render(string viewName, Dictionary<string, string> context);
    }
}
