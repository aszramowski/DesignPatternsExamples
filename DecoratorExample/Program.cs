using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            INotify notifier = new NotifierConcreteComponent();
            notifier = new NotifySmsDecorator(notifier);
            notifier = new NotifyFacebookDecorator(notifier);

            notifier.Notify("Uwaga wykryto pożar!");

            Console.ReadKey();
        }
    }
}
