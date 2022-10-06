using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Standard_Mediator
{
    public class Button : UIControl
    {
        private bool _isEnable;
        public Button(IDialogBox owner) : base(owner)
        {
        }

        public bool IsEnable()
        {
            return _isEnable;
        }

        public void setEnable(bool enable)
        {
            _isEnable = enable;
            _owner.Change(this);
        }
    }
}
