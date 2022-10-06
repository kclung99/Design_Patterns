using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PDFDocument
    {
        public void AddPage(Slide slide)
        {
            Console.WriteLine(slide.GetContext() + " added to PDF");
        }
    }
}
