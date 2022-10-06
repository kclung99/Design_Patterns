using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Observer_Mediator
{
    public class TextBox: UIControl
    {
        private string _content;
        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
            NotifyEventHandlers();
        }
    }
}
