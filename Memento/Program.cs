using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        // editor: Editor
        // Memento: EditorState
        // history: History

        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "first"; // set content
            history.Push(editor.CreateState()); // save to history

            editor.Content = "second";
            history.Push(editor.CreateState());

            editor.Content = "third";
            editor.Restore(history.Pop()); // restore content

            Console.WriteLine(editor.Content);
        }
    }
}
