using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        // Component: IComponent
        // Composite: Group
        // Leaf: Shape

        static void Main(string[] args)
        {
            var group1 = new Group();
            group1.Add(new Shape());
            group1.Add(new Shape());
            group1.Render();

            Console.WriteLine("\n");

            var group2 = new Group();
            group2.Add(new Shape());
            group2.Add(group1);
            group2.Render();
        }
    }
}
