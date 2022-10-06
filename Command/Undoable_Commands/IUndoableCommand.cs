using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Standard_Commands;

namespace Command.Undoable_Commands
{
    public interface IUndoableCommand: ICommand
    {
        void Unexecute();
    }
}
