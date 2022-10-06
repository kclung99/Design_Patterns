using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ImageStorage
    {
        public ICompressor Compressor { get; set; }
        public IFilter Filter { get; set; }

        public ImageStorage(ICompressor compressor, IFilter filter)
        {
            Compressor = compressor;
            Filter = filter;
        }

        public void Store(string file)
        {
            Compressor.Compress(file);
            Filter.Apply(file);
        }
    }
}
