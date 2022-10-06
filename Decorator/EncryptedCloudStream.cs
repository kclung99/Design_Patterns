using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EncryptedCloudStream : IStream
    {
        private IStream _stream;
        public EncryptedCloudStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            var encryptedData = Encrypt(data);
            _stream.Write(encryptedData);
        }

        private string Encrypt(string data)
        {
            return "12#56&234*#123#";
        }
    }
}
