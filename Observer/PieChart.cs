using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class PieChart : IObserver
    {
        private DataSource _dataSource;
        public PieChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("PieChart has been Updated with: " + _dataSource.GetData());
        }
    }
}
