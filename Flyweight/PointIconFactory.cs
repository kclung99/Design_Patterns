using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> _icons = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType type)
        {
            if(!_icons.ContainsKey(type))
            {
                var icon = new PointIcon(type, null);
                _icons.Add(type, icon);
            }

            return _icons[type];
        }

    }
}
