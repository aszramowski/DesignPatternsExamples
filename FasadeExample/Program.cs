using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientAPI client = new ClientAPI();
            client.Account();
            client.MoneySpend();
            client.MoneyTransfer();

            Console.ReadKey();
        }
    }
}
