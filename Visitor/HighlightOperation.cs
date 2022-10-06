using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Heading node highlighted");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Anchor node highlighted");
        }
    }
}
