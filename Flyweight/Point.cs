using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Point
    {
        private int _x;
        private int _y;
        private PointIcon _icon;

        public Point(int x, int y, PointIcon icon)
        {
            _x = x;
            _y = y;
            _icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Icon");
        }

    }
}
