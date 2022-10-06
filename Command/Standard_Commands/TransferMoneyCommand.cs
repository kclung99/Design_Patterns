using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Standard_Commands
{
    public class TransferMoneyCommand : ICommand
    {
        private CustomerService _service;

        public TransferMoneyCommand(CustomerService service)
        {
            _service = service;
        }
        public void Execute()
        {
            _service.TransferMoney();
        }
    }
}
