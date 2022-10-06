using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Standard_Commands;

namespace Command.Composite_Commands
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService _service;

        public AddCustomerCommand(CustomerService service)
        {
            _service = service;
        }
        public void Execute()
        {
            _service.AddCustomer();
        }
    }
}
