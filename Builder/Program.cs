using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        // Director: Presentation
        // Builder: IPresentationBuilder
        // ConcreteBuilder1: MovieBuilder
        // ConcreteBuilder2: PDFBuilder
        static void Main(string[] args)
        {
            var presentation = new Presentation();
            presentation.AddSlide(new Slide("a"));
            presentation.AddSlide(new Slide("b"));
            presentation.AddSlide(new Slide("c"));

            var pdfBuilder = new PDFBuilder();
            var movieBuilder = new MovieBuilder();

            presentation.Export(pdfBuilder);
            presentation.Export(movieBuilder);

            var pdf = pdfBuilder.GetPDFDocument();
            var movie = movieBuilder.GetMovie();
        }
    }
}
