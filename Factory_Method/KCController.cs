using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class KCController: Controller
    {
        protected override IViewEngine CreateViewEngine()
        {
            return new KCViewEngine();
        }

    }
}
