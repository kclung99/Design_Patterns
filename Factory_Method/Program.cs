using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        // Product: IViewEngine
        // ConcreteProduct1: KCViewEngine
        // ConcreteProduct2: NewViewEngine
        // Creator: Controller
        // ConcreteCreator1: KCController
        // ConcreteCreator2: NewController

        static void Main(string[] args)
        {
            var controller = new KCController();
            controller.Render("File1", null);

            var newController = new NewController();
            newController.Render("File2", null);
        }
    }
}
