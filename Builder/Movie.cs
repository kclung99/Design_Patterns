using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Movie
    {
        public void AddFrame(Slide slide)
        {
            Console.WriteLine(slide.GetContext() + " added to frame");
        }
    }
}
