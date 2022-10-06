using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class IOSWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new IOSButton();
        }

        public ITextBox CreateTextBox()
        {
            return new IOSTextBox();
        }
    }
}
