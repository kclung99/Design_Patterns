using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Undoable_Commands
{
    public class ImageService
    {
        public int Size { get; set; } = 0;
        public void Resize(int size)
        {
            Console.WriteLine("Image is now {0} by {0}", size.ToString());
            Size = size;
        }
    }
}
