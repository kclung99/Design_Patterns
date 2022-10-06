using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Standard_Commands
{
    public class Button
    {
        public ICommand Command { get; set; }
        public Button(ICommand command)
        {
            Command = command;
        }
        public void Click()
        {
            Command.Execute();
        }
    }
}
