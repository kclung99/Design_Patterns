using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        // Singleton: ConfigManager
        static void Main(string[] args)
        {
            var manager = ConfigManager.instance;
            manager.Settings.Add("KC", "Lung");

            var otherManager = ConfigManager.instance;
            Console.WriteLine(otherManager.Settings["KC"]);
        }
    }
}
