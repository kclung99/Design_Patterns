using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class JPEGCompressor : ICompressor
    {
        public void Compress(string file)
        {
            Console.WriteLine("JPEGCompressor Applied");
        }
    }
}
