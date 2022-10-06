using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        // Client: ContextMenu
        // Prototype: IComponent
        // ConretePrototype: Circle

        static void Main(string[] args)
        {
            var circle = new Circle();
            var contextMenu = new ContextMenu();
            contextMenu.Duplicate(circle);
        }
    }
}
