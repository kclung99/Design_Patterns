using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Standard_Commands;

namespace Command.Undoable_Commands
{
    public class UndoCommand : ICommand
    {
        private History _history;
        public UndoCommand(History history)
        {
            _history = history;
        }
        public void Execute()
        {
            var undoableCommand = (IUndoableCommand)_history.Pop();
            undoableCommand.Unexecute();
        }
    }
}
