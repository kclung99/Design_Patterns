using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // required to call Init() before any operation by the documentation
    public class Caramel
    {
        private string _image;
        public void Init(string image)
        {
            _image = image;
            Console.WriteLine("Caramel Filter initiated");
        }

        public void Apply()
        {
            Console.WriteLine("Caramel Filter applied to: " + _image);
        }
    }
}
