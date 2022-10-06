using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Standard_Commands
{
    public class CustomerService
    {
        public void TransferMoney()
        {
            Console.WriteLine("Money has been transfered");
        }

        public void AddCustomer()
        {
            Console.WriteLine("Customer has been added");
        }
    }
}
