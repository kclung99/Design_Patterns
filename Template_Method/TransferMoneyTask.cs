using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class TransferMoneyTask : Task
    {
        public TransferMoneyTask(AuditTrail auditTrail)
            : base(auditTrail) { }
        
        protected override void DoExeCute()
        {
            Console.WriteLine("Money Transfered");
        }
    }
}
