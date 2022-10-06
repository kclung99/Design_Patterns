using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Standard_Mediator
{
    public class ListBox : UIControl
    {
        private string _selection;
        public ListBox(IDialogBox owner) : base(owner)
        {
        }

        public string GetSelection()
        {
            return _selection;
        }

        public void SetSelection(string selection)
        {
            _selection = selection;
            _owner.Change(this);
        }

    }
}
