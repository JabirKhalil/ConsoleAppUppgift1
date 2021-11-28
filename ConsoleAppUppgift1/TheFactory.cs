using ConsoleAppUppgift1.TheAnimal;
using ConsoleAppUppgift1.TheCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUppgift1
{
    public class TheFactory
    {
        


        public static ICustomer CreateCustomer()
        {
            return new Customer();
        }


        public static IAnimal CreateAnimal()
        {
            return new Animal();
        }

      
    }
}
