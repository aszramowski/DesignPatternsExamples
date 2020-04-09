using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class MathLibraryNew : IMathLibraryNew
    {
        public int IsAdditionCarriedProperly(int a, int b, int result)
        {
            int temp = a + b;
            int ret;
            if (temp == result)
                ret = 1;
            else
                ret = 0;

            return ret;
        }
    }

    interface IMathLibraryNew
    {
        int IsAdditionCarriedProperly(int a, int b, int result);     
    }
}
