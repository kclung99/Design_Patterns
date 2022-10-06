using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        // Client: ImageView
        // Target: IFilter
        // Adapter: CaramelFilter
        // Adaptee: Caramel (third party filter)
        static void Main(string[] args)
        {
            var imageView = new ImageView(":)");
            var caramelFilter = new CaramelFilter(new Caramel());
            imageView.Apply(caramelFilter);
        }
    }
}
