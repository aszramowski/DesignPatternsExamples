using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public class WorkerLeaf : IWorker
    {
        private string firstName, lastName, degree;

        public WorkerLeaf(string firstName, string lastName, string degree)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.degree = degree;
        }

        public void DisplayInformationWorker()
        {
            Console.WriteLine(firstName + " " + lastName + " " + degree);
        }
    }

    public interface IWorker
    {
        void DisplayInformationWorker();
    }
}
