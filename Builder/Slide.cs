using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Slide
    {
        private string _context;

        public Slide(string context)
        {
            _context = context;
        }

        public string GetContext()
        {
            return _context;
        }
    }
}
