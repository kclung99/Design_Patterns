using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface IFilter
    {
        void Apply(string file);
    }
}
