using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CompressedCloudStream : IStream
    {
        private IStream _stream;
        public CompressedCloudStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            var compressedData = Compress(data);
            _stream.Write(compressedData);
        }
        private string Compress(string data)
        {
            return data.Substring(0,3);
        }
    }
}
