using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class PointService
    {
        private PointIconFactory _factory;

        public PointService(PointIconFactory factory)
        {
            _factory = factory;
        }

        public List<Point> GetPoints()
        {
            var points = new List<Point>();
            var point = new Point(1, 2, _factory.GetPointIcon(PointType.CAFE));
            points.Add(point);

            return points;
        }
    }
}
