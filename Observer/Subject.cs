using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
