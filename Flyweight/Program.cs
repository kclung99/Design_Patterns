using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        // Client : PointService
        // Flyweight: PointIcon
        // ConcreteFlyweight: Point
        // FlyweightFactory: PointIconFactory

        static void Main(string[] args)
        {
            var service = new PointService(new PointIconFactory());
            var points = service.GetPoints();
            foreach(Point point in points)
            {
                point.Draw();
            }
        }
    }
}
