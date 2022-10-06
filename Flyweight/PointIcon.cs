using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class PointIcon
    {
        private PointType _type;
        private byte[] _image;

        public PointIcon(PointType type, byte[] image)
        {
            _type = type;
            _image = image;
        }

        public PointType GetIconType()
        {
            return _type;
        }
    }
}
