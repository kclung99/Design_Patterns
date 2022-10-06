using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ConfigManager
    {
        public Dictionary<string, string> Settings { get; set; } = new Dictionary<string, string>();
        public static ConfigManager instance { get; } = new ConfigManager();

    }
}
