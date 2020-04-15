using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
    public class Remote
    {
        private IDevice device;
        public Remote(IDevice device)
        {
            this.device = device;
        }
        public void TogglePower()
        {
            if (device.IsEnabled())
                device.Disable();
            else
                device.Enable();
        }

        public void ShowVolume()
        {
            Console.WriteLine(device.GetVolume());
        }
    }

    public class AdvancedRemote : Remote
    {
        private IDevice device;
        public AdvancedRemote(IDevice device) : base(device)
        {
            this.device = device;
        }

        public void Mute()
        {
            device.SetVolume(0);
        }
    }

    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        string GetVolume();
        void SetVolume(int volume);
    }
}
