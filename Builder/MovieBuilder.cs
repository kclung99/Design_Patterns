using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MovieBuilder : IPresentationBuilder
    {
        private Movie _movie = new Movie();
        public void AddSlide(Slide slide)
        {
            _movie.AddFrame(slide);
        }

        public Movie GetMovie()
        {
            return _movie;
        }
    }
}
