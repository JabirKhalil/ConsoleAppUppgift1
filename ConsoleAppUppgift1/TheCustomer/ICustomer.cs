using ConsoleAppUppgift1.TheAnimal;
using System.Collections.Generic;

namespace ConsoleAppUppgift1.TheCustomer
{
    public interface ICustomer
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<IAnimal> Animals { get; set; }
    }
}