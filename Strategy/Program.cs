using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        // Context: ImageStorage
        // Strategy1: ICompressor
        // ConcreteStrategy1: JPEGCompressor
        // Strategy2: IFilter
        // ConcreteStrategy2: BlackAndWhiteFilter
        static void Main(string[] args)
        {
            string file = "file";
            
            var imageStorage = new ImageStorage(new JPEGCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store(file);
        }
    }
}
