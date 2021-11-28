using ConsoleAppUppgift1.OutputMethods;
using ConsoleAppUppgift1.TheAnimal;
using ConsoleAppUppgift1.TheCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUppgift1.TheMenu
{
    public class DrawMenu : IDrawMenu
    {
        public ICustomerManager CustomerManager { get; set; }
        public IAnimalManager AnimalManager { get; set; }
        ICustomer Customer;
        List<ICustomer> customers = new List<ICustomer>();

        public DrawMenu(ICustomerManager customerManager,IAnimalManager animalManager, ICustomer customer)
        {
            CustomerManager = customerManager;
            AnimalManager = animalManager;
            Customer = customer;
        }

        private void ClearRow()
        {
            Console.Clear();
        }

      
        public void Menu()
        {
            MenuSelection();

            while (true)
            {
                char userInput = Console.ReadKey(true).KeyChar;


                switch (userInput)
                {
                    case 'f' or 'F':
                        ClearRow();
                        MenuSelection();
                        CustomerManager.AddCustomer();
                        break;

                    case 's' or 'S':
                        ClearRow();
                        MenuSelection();
                        CustomerManager.CustomerNames();
                        break;

                    case 'w' or 'W':
                        ClearRow();
                        MenuSelection();
                        AnimalManager.AddAnimal();
                        break;

                    case 'r' or 'R':
                        ClearRow();
                        MenuSelection();
                       AnimalManager.AnimalNames();
                        break;


                    case 'e' or 'E':
                        ClearRow();
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        ClearRow();
                        MenuSelection();
                        Console.Write("That is not a valid choice");
                        break;
                }
            }

          static void MenuSelection()
            {
                OutAndInputBuilder.ToConsole("The Menu");
                OutAndInputBuilder.ToConsole("---------------------");
                OutAndInputBuilder.ToConsole("  Select an option   ");
                OutAndInputBuilder.ToConsole("---------------------");
                OutAndInputBuilder.ToConsole("F: Register a customer");
                OutAndInputBuilder.ToConsole("W: Register an Animal");
                OutAndInputBuilder.ToConsole("S: Show all customers");
                OutAndInputBuilder.ToConsole("R: Show all animals");
                OutAndInputBuilder.ToConsole("E: Exit Program");
                OutAndInputBuilder.ToConsole("%%%%%%%%%%%%%%%%%%%%%");
                OutAndInputBuilder.ToConsole("");

            }
        }
    }
}
