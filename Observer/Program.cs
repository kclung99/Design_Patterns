using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        // Subject: Subject
        // ConsreteSubject: DataSource
        // Observer: IObserver
        // ConcreteObserver1: Sheet
        // ConcreteObserver2: PieChart

        static void Main(string[] args)
        {
            var dataSource = new DataSource();
            var sheet = new Sheet(dataSource);
            var pieChart = new PieChart(dataSource);

            dataSource.AddObserver(sheet);
            dataSource.AddObserver(pieChart);

            dataSource.SetData("1");
            dataSource.SetData("2");
            dataSource.SetData("3");
        }
    }
}
