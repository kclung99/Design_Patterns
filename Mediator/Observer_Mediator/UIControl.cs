using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Observer_Mediator
{
    public abstract class UIControl
    {
        private List<IEventHandler> _eventHandlers = new List<IEventHandler>();

        public void AddEventHandler(IEventHandler observer)
        {
            _eventHandlers.Add(observer);
        }

        public void RemoveEventHandler(IEventHandler observer)
        {
            _eventHandlers.Remove(observer);
        }

        public void NotifyEventHandlers()
        {
            foreach(IEventHandler eventHandler in _eventHandlers)
            {
                eventHandler.Handle();
            }
        }
    }
}
