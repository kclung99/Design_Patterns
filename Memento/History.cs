using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class History
    {
        public List<EditorState> Mementos { get; set; } = new List<EditorState>();

        public void Push(EditorState memento)
        {
            Mementos.Add(memento);
        }

        public EditorState Pop()
        {
            var lastIndex = Mementos.Count() - 1;
            var val = Mementos.Last();
            Mementos.RemoveAt(lastIndex);

            return val;
        }
    }
}
