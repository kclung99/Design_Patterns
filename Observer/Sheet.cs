using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Sheet : IObserver
    {
        private DataSource _dataSource;
        public Sheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Sheet has been updated with: " + _dataSource.GetData());
        }
    }
}
