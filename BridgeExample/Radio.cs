using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
    public class Radio : IDevice
    {
        public void Disable()
        {
            Console.WriteLine("Wyłączam radio");
        }

        public void Enable()
        {
            Console.WriteLine("Włączam radio");
        }

        public string GetVolume()
        {
            return "Pokazuję poziom głośności radio";
        }

        public bool IsEnabled()
        {
            return false;
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("Wycisz radio");
        }
    }
}
