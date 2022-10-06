using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Standard_Commands;

namespace Command.Undoable_Commands
{
    public class History
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void Push(ICommand command)
        {
            _commands.Add(command);
        }

        public ICommand Pop()
        {
            var lastIndex = _commands.Count() - 1;
            var result = _commands.Last();
            _commands.RemoveAt(lastIndex);

            return result;
        }
    }
}
