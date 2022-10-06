using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class AdvancedRemoteControl: RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public void SetChannel(int channel)
        {
            _device.SetChannel(channel);
        }
    }
}
