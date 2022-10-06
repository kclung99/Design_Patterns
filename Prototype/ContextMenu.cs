using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ContextMenu
    {
        public void Duplicate(IComponent component)
        {
            component.Clone();
            Console.WriteLine("Cloned");
        }
    }
}
