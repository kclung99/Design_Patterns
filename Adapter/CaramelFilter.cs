using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CaramelFilter : IFilter
    {
        private Caramel _caramel;

        public CaramelFilter(Caramel caramel)
        {
            _caramel = caramel;
        }

        public void Apply(string image)
        {
            _caramel.Init(image);
            _caramel.Apply();
        }
    }
}
