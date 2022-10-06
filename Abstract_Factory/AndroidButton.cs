using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class AndroidButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Android Button");
        }
    }
}
