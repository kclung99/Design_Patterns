using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        // Client: Library
        // Subject: IEbook
        // RealSubject: RealEbook
        // Proxy: EbookProxy

        static void Main(string[] args)
        {
            var library = new Library();
            var ebooks = new string[] { "a", "b", "c" };
            foreach (string ebook in ebooks)
            {
                library.Add(new EbookProxy(ebook));
            }

            library.OpenEbook("b");
        }
    }
}
