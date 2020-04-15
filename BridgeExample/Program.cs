using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice device = new Radio();
            IDevice deviceNext = new Tv();

            Remote remote = new Remote(device);
            AdvancedRemote remoteNext = new AdvancedRemote(deviceNext);

            remote.TogglePower();
            remoteNext.TogglePower();
            remoteNext.Mute();

            Console.ReadKey();
        }
    }
}
