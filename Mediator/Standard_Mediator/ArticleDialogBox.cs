using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Standard_Mediator
{
    public class ArticleDialogBox : IDialogBox
    {
        private ListBox _listBox;
        private TextBox _textBox;
        private Button _button;

        public ArticleDialogBox()
        {
            _listBox = new ListBox(this);
            _textBox = new TextBox(this);
            _button = new Button(this);
        }

        // Simulate User selection
        public void SimulateUserSelection()
        {
            _listBox.SetSelection("a");
            Console.WriteLine("TextBox is set to: " + _textBox.GetContent());
            Console.WriteLine("Button in now: " + _button.IsEnable().ToString());

            _textBox.SetContent("");
            Console.WriteLine("Text Box is set to: " + _textBox.GetContent());
            Console.WriteLine("Button in now: " + _button.IsEnable().ToString());
        }

        public void Change(UIControl control)
        {
            if (control == _listBox)
            {
                ArticleSelected();
            }
            if (control == _textBox)
            {
                TextChanged();
            }
        }

        private void ArticleSelected()
        {
            _textBox.SetContent(_listBox.GetSelection());
            _button.setEnable(true);
        }

        private void TextChanged()
        {
            var content = _textBox.GetContent();
            var isEmpty = (content == null || content == "");
            _button.setEnable(!isEmpty);
        }
    }
}
