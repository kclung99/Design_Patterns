using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PDFBuilder : IPresentationBuilder
    {
        private PDFDocument _document = new PDFDocument();
        public void AddSlide(Slide slide)
        {
            _document.AddPage(slide);
        }

        public PDFDocument GetPDFDocument()
        {
            return _document;
        }
    }
}
