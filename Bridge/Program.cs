using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        // Abstraction: RemoteControl
        // RefinedAbstraction: AdvancedRemoteControl
        // Implementor: IDevice
        // ConcreteImplementor: SonyTV
        static void Main(string[] args)
        {
            var control = new AdvancedRemoteControl(new SonyTV());
            control.TurnOn();
            control.SetChannel(80);
        }
    }
}
