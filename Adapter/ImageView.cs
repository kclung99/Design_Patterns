using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ImageView
    {
        private string _image;

        public ImageView(string image)
        {
            _image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(_image);
        }
    }
}
