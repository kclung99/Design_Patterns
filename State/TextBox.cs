using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class TextBox : ITool
    {
        public void Click()
        {
            Console.WriteLine("Draw TextBox");
        }
    }
}
