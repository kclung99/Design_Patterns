using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        // Client: HtmlDocument
        // Element: IHtmlNode
        // ConcreteElement1: HeadingNode
        // ConcreteElement2: AnchorNode
        // Visitor: IOperation
        // ConcreteVisitor1: HighlightOperation
        // ConcreteVisitor1: ExtractTextOperation

        static void Main(string[] args)
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            document.Execute(new ExtractTextOperation());
            document.Execute(new HighlightOperation());
        }
    }
}
