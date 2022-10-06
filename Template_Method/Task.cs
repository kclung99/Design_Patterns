using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class Task
    {
        private AuditTrail _auditTrail;

        public Task(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }
        public void Execute()
        {
            _auditTrail.Record();
            DoExeCute();
        }

        protected abstract void DoExeCute();
    }
}
