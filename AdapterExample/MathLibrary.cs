using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class MathLibrary : IMathLibrary
    {
        public bool IsAdditionCarriedProperly(int a, int b, int result)
        {
            int temp = a + b;
            bool ret;
            if (temp == result)
                ret = true;
            else
                ret = false;

            return ret;
        }
    }

    interface IMathLibrary
    {
        bool IsAdditionCarriedProperly(int a, int b, int result);     
    }
}
