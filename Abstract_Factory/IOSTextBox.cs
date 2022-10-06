using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class IOSTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering IOS TextBox");
        }
    }
}
