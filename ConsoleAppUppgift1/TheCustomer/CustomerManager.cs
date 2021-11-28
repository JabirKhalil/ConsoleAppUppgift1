using ConsoleAppUppgift1.OutputMethods;
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
            OutAndInputBuilder.ToConsole1("Customer's first name:");
           
            
            var Name = OutAndInputBuilder.FromConsole();
            OutAndInputBuilder.ToConsole1("Customer's surname:");
          
            var Surname = OutAndInputBuilder.FromConsole();
            var animalList = new List<IAnimal>();
            customerList.Add(CustomerFactory(Name, Surname, animalList));

            OutAndInputBuilder.ToConsole1("The Customer " +Name +" "+ Surname+" has registered.");
        }

        public void CustomerNames()
        {
            int i = 0;
            OutAndInputBuilder.ToConsole("The list of customers");
            OutAndInputBuilder.ToConsole("--------------------");
            foreach (var customer in customerList)
            {
                i++;
                OutAndInputBuilder.ToConsole(i + "-Customer: "+customer.Name + " " + customer.Surname);
                OutAndInputBuilder.ToConsole("");
            }
        }
    }
}
