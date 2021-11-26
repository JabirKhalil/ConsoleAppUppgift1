using ConsoleAppUppgift1.TheAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUppgift1.TheCustomer
{
    public class CustomerManager : ICustomerManager
    {

        private Customer.Factory CustomerFactory;
        public List<ICustomer> customerList { get; set; }
        
        public CustomerManager(Customer.Factory customerFactory)
        {
            CustomerFactory = customerFactory;
            customerList = new();
        }
        public void AddCustomer()
        {
            Console.Write("Customer first name:");
            var Name = Console.ReadLine();
            Console.Write("Customer surname:");
            var Surname = Console.ReadLine();
            var animalList = new List<IAnimal>();
            customerList.Add(CustomerFactory(Name, Surname, animalList));            
        }

        public void CustomerNames()
        {
            int i = 0;
            Console.WriteLine("The list of customers");
            Console.WriteLine("--------------------");
            foreach (var customer in customerList)
            {
                i++;
                Console.WriteLine(i + "-Customer: "+customer.Name + " " + customer.Surname);
                Console.WriteLine("");
            }
        }
    }
}
