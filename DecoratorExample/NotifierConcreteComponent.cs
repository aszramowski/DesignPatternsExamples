using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class NotifierConcreteComponent : INotify
    {        
        public void Notify(string message)
        {
            Console.WriteLine("Wysyłam standardowe powiadomienie email: " + message);
        }
    }

    public interface INotify
    {
        void Notify(string message);
    }
}
