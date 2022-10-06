using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class BrowserHistory : IAggregate<string>
    {
        private List<string> _urls = new List<string>();

        public void Push(string url)
        {
            _urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = _urls.Count() - 1;
            var result = _urls.Last();
            _urls.RemoveAt(lastIndex);

            return result;
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }


        public class ListIterator : IIterator<string>
        {
            private BrowserHistory _browserHistory;
            private int _index;

            public ListIterator(BrowserHistory browserHistory)
            {
                _browserHistory = browserHistory;
            }

            public string Current()
            {
                return _browserHistory._urls.ElementAt(_index);
            }

            public bool HasNext()
            {
                return _index < _browserHistory._urls.Count();
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}
