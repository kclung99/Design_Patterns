using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {
        // AbstractClass: Task
        // ConcreteClass: TransferMoneyTask
        static void Main(string[] args)
        {
            var transferMoneyTask = new TransferMoneyTask(new AuditTrail());
            transferMoneyTask.Execute();
        }
    }
}
