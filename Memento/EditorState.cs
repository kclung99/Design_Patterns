using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class EditorState
    {
        public string Content { get; }
        public EditorState(string content)
        {
            Content = content;
        }
    }
}
