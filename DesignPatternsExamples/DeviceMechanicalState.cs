using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples
{
    class DeviceMechanicalState
    {
        private static readonly object padLock = new object();
        private static DeviceMechanicalState deviceMechanicalStateInstance;
        public bool IsDeviceOpended { get; private set; }        
        public static DeviceMechanicalState DeviceMechanicalStateInstance
        {
            get
            {
                lock (padLock)
                {
                    if (deviceMechanicalStateInstance == null)
                        deviceMechanicalStateInstance = new DeviceMechanicalState();

                    return deviceMechanicalStateInstance; 
                }
            }
        }      
        private DeviceMechanicalState() { }

        public void CloseDevice()
        {
            if (IsDeviceOpended)
                IsDeviceOpended = false;
        }
        public void OpenDevice()
        {
            if (!IsDeviceOpended)
                IsDeviceOpended = true;
        }
    }
}
