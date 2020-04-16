using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public class ManagerComposite : IWorker
    {
        private string firstName, lastName, degree;
        private List<IWorker> workers = new List<IWorker>();
        public ManagerComposite(string firstName, string lastName, string degree)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.degree = degree;
        }

        public void DisplayInformationWorker()
        {
            Console.WriteLine(firstName + " " + lastName + " " + degree);
            foreach (IWorker w in workers)
                w.DisplayInformationWorker();
        }

        public void AddWorker(IWorker w)
        {
            workers.Add(w);
        }        
    }
}
