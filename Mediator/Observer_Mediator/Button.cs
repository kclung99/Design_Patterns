using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Observer_Mediator
{
    public class Button : UIControl
    {
        private bool _isEnable;
        public bool IsEnable()
        {
            return _isEnable;
        }

        public void setEnable(bool enable)
        {
            _isEnable = enable;
            NotifyEventHandlers();
        }
    }
}
