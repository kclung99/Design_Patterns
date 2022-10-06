using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Standard_Mediator
{
    public class TextBox : UIControl
    {
        private string _content;
        public TextBox(IDialogBox owner) : base(owner)
        {
        }

        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
            _owner.Change(this);
        }
    }
}
