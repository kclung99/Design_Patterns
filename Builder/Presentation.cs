using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Presentation
    {
        private List<Slide> _slides = new List<Slide>();

        public void AddSlide(Slide slide)
        {
            _slides.Add(slide);
        }

        public void Export(IPresentationBuilder builder)
        {
            foreach(Slide slide in _slides)
            {
                builder.AddSlide(slide);
            }
        }
    }
}
