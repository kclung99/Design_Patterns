using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Observer_Mediator
{
    class TextChangedEventHandler: IEventHandler
    {
        private ListBox _listBox = new ListBox();
        private TextBox _textBox = new TextBox();
        private Button _button = new Button();

        public TextChangedEventHandler(ListBox listBox, TextBox textBox, Button button)
        {
            _listBox = listBox;
            _textBox = textBox;
            _button = button;
        }

        public void Handle()
        {
            var content = _textBox.GetContent();
            var isEmpty = (content == null || content == "");
            _button.setEnable(!isEmpty);
        }
    }
}
