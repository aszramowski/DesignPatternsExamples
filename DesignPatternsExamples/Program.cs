using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples
{
    /// <summary>
    /// This example shows a singleton that stores information about a mechanical state of an electrical device. The device can be opened or closed.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DeviceMechanicalState.DeviceMechanicalStateInstance.IsDeviceOpended);
            DeviceMechanicalState.DeviceMechanicalStateInstance.OpenDevice();
            Console.WriteLine(DeviceMechanicalState.DeviceMechanicalStateInstance.IsDeviceOpended);
            DeviceMechanicalState.DeviceMechanicalStateInstance.OpenDevice();
            Console.ReadKey();
        }
    }
}
