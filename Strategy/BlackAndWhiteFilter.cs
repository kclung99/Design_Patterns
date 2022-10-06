using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string file)
        {
            Console.WriteLine("B&WFilter Applied");
        }
    }
}
