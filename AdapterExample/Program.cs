using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IMathLibrary mathLibrary = new MathLibrary();
            IMathLibrary mathLibraryNew = new MathLibraryAdapter();

            bool result = mathLibrary.IsAdditionCarriedProperly(4, 4, 8);
            bool resultNew = mathLibraryNew.IsAdditionCarriedProperly(5, 5, 10);

            Console.WriteLine(result);
            Console.WriteLine(resultNew);
            Console.ReadKey();
        }
    }
}
