using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class DataSource: Subject
    {
        private string _data;

        public string GetData()
        {
            return _data;
        }
        public void SetData(string data)
        {
            _data = data;
            Notify();
        }
    }
}
