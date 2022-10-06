using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Iterator
{
    class Program
    {
        // Aggregate: IAggregate
        // ConcreteAggregate: BrowserHistory
        // Iterator: IIterator
        // ConcreteIterator: ListIterator

        static void Main(string[] args)
        {
            var browserHistory = new BrowserHistory();
            browserHistory.Push("first");
            browserHistory.Push("second");
            browserHistory.Push("third");

            var iterator = browserHistory.CreateIterator();
            while(iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }
        }
    }
}
