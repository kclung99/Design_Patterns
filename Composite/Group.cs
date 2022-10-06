using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Group: IComponent
    {
        private List<IComponent> _components = new List<IComponent>();

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Render()
        {
            foreach(IComponent component in _components)
            {
                component.Render();
            }
        }
    }
}
