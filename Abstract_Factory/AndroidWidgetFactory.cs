using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class AndroidWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new AndroidButton();
        }

        public ITextBox CreateTextBox()
        {
            return new AndroidTextBox();
        }
    }
}
