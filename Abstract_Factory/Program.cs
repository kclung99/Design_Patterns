using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        // Client: ContactForm
        // AbstractFactory: IWidgetFactory
        // ConcreteFactory1: AndroidWidgetFactory
        // ConcreteFactory2: IOSWidgetFactory
        // AbstractProduct: IWidget
        // AbstractProduct1: IButton
        // ConcreteProduct1.1: AndroidButton
        // ConcreteProdect1.2: IOSButton
        // AbstractProduct2: ITextBox
        // ConcreteProduct2.1: AndroidTextBox
        // ConcreteProdect2.2: IOSTextBox

        static void Main(string[] args)
        {
            var form1 = new ContactForm(new AndroidWidgetFactory());
            form1.Render();

            var form2 = new ContactForm(new IOSWidgetFactory());
            form2.Render();
        }
    }
}
