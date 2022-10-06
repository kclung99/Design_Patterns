using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealEbook : IEbook
    {
        private string _fileName;

        public RealEbook(string fileName)
        {
            _fileName = fileName;
            Load();
        }
        public string GetFileName()
        {
            return _fileName;
        }

        public void Show()
        {
            Console.WriteLine("Showing: " + _fileName);
        }

        private void Load()
        {
            Console.WriteLine("Loading: " + _fileName);
        }
    }
}
