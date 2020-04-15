using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
    public class Tv : IDevice
    {
        public void Disable()
        {
            Console.WriteLine("Wyłączam tv");
        }

        public void Enable()
        {
            Console.WriteLine("Włączam tv");
        }

        public string GetVolume()
        {
            return "Pokazuję poziom głośności tv";
        }

        public bool IsEnabled()
        {
            return true;
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("Wycisz tv");
        }
    }
}
