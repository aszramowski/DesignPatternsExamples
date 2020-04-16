using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ManagerComposite manager = new ManagerComposite("Andrej", "Wardalo", "head of the technology department");
            //manager.AddWorker(new WorkerLeaf("Anna", "Karbowska", "embedded systems engineer"));
            //manager.AddWorker(new WorkerLeaf("Mark", "Zielinski", "IOS application developer"));
            //manager.AddWorker(new WorkerLeaf("Slawomir", "Kowalski", "Web application developer"));
            //
            //manager.DisplayInformationWorker();

            ManagerComposite manager1 = new ManagerComposite("Andrej", "Wardalo", "head of the technology department");
            manager1.AddWorker(new WorkerLeaf("Anna", "Karbowska", "embedded systems engineer"));
            manager1.AddWorker(new WorkerLeaf("Mark", "Zelinski", "IOS application developer"));
            manager1.AddWorker(new WorkerLeaf("Slawomir", "Kowalski", "Web application developer"));
            ManagerComposite manager2 = new ManagerComposite("Jacek", "Nowak", "team manager");
            manager1.AddWorker(manager2);
            manager2.AddWorker(new WorkerLeaf("Waldemar", "Musal", "Evaluator"));
            manager2.AddWorker(new WorkerLeaf("Jan", "Pufund", "Graphic designer"));

            manager1.DisplayInformationWorker();

            

            Console.ReadKey();
        }
    }
}
