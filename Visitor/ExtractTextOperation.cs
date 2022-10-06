using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ExtractTextOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Heading node text extracted");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Anchor node text extracted");
        }
    }
}
