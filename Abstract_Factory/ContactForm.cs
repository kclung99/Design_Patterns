using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class ContactForm
    {
        private IWidgetFactory _factory;

        public ContactForm(IWidgetFactory factory)
        {
            _factory = factory;
        }

        public void Render()
        {
            _factory.CreateButton().Render();
            _factory.CreateTextBox().Render();
        }
    }
}
