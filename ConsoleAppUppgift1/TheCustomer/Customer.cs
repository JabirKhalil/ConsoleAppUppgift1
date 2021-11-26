using ConsoleAppUppgift1.TheAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUppgift1.TheCustomer
{
    public class Customer : ICustomer    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<IAnimal> Animals { get; set; }        

        public delegate Customer Factory(string firstName, string surName, IEnumerable<IAnimal> animals);
        public Customer(string firstName, string surName, IEnumerable<IAnimal> animals)
        {
            Name = firstName;
            Surname = surName;
            Animals = new List<IAnimal>(animals);

        }

        public Customer(string firstName, string surName)
        {
            Name = firstName;
            Surname = surName;
        }

        public Customer()
        {

        }
    }
}
