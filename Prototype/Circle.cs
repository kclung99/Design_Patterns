using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle: IComponent
    {
        public int Radius { get; set; }

        public IComponent Clone()
        {
            var circle = new Circle();
            circle.Radius = Radius;

            return circle;
        }

        public void render()
        {
            Console.WriteLine("Rendering Circle...");
        }
    }
}
