using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SonyTV : IDevice
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("SonyTV set to: " + channel.ToString());
        }

        public void TurnOff()
        {
            Console.WriteLine("SonyTV turned off");
        }

        public void TurnOn()
        {
            Console.WriteLine("SonyTV turned on");
        }
    }
}
