using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Observer_Mediator
{
    public class ArticleSelectedEventHandler : IEventHandler
    {
        private ListBox _listBox = new ListBox();
        private TextBox _textBox = new TextBox();
        private Button _button = new Button();

        public ArticleSelectedEventHandler(ListBox listBox, TextBox textBox, Button button)
        {
            _listBox = listBox;
            _textBox = textBox;
            _button = button;
        }

        public void Handle()
        {
            _textBox.SetContent(_listBox.GetSelection());
            _button.setEnable(true);
        }
    }
}
