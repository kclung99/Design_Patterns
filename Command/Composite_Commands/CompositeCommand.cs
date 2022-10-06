using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Standard_Commands;

namespace Command.Composite_Commands
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void Execute()
        {
            foreach(ICommand command in _commands)
            {
                command.Execute();
            }
        }
    }
}
