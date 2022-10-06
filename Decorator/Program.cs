using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        // Component: IStream
        // ConcreteComponent: CloudStream
        // Decorator1: EncryptedCloudStream
        // Decorator2: CompressedCloudStream

        static void Main(string[] args)
        {
            StoreData(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));
        }

        public  static void StoreData(IStream stream)
        {
            stream.Write("1234-5678-90");
        }
    }
}
