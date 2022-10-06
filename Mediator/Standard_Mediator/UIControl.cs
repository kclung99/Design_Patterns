using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Standard_Mediator
{
    public abstract class UIControl
    {
        protected IDialogBox _owner;

        public UIControl(IDialogBox owner)
        {
            _owner = owner;
        }
    }
}
