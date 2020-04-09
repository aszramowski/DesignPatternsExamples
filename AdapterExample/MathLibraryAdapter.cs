using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class MathLibraryAdapter : IMathLibrary
    {
        IMathLibraryNew mathLibrary = new MathLibraryNew();

        public bool IsAdditionCarriedProperly(int a, int b, int result)
        {
            int ret = mathLibrary.IsAdditionCarriedProperly(a, b, result);

            if (ret == 1)
                return true;
            else
                return false;
        }
    }
}
