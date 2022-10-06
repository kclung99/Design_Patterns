using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Observer_Mediator
{
    public class ArticleDialogBox
    {
        private ListBox _listBox = new ListBox();
        private TextBox _textBox = new TextBox();
        private Button _button = new Button();

        public ArticleDialogBox()
        {
            _listBox.AddEventHandler(new ArticleSelectedEventHandler(_listBox, _textBox, _button));
            _textBox.AddEventHandler(new TextChangedEventHandler(_listBox, _textBox, _button));
        }

        // Simulate User selection
        public void SimulateUserSelection()
        {
            _listBox.SetSelection("1");
            Console.WriteLine("TextBox is set to: " + _textBox.GetContent());
            Console.WriteLine("Button in now: " + _button.IsEnable().ToString());

            _textBox.SetContent("");
            Console.WriteLine("Text Box is set to: " + _textBox.GetContent());
            Console.WriteLine("Button in now: " + _button.IsEnable().ToString());
        }
    }
}
