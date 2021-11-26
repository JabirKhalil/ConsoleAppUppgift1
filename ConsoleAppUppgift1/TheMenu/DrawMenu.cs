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


        public DrawMenu(ICustomerManager customerManager,IAnimalManager animalManager)
        {
            CustomerManager = customerManager;
            AnimalManager = animalManager;
        }

        private void ClearRow()
        {
            Console.Clear();
        }

        //private static void ClearRow()
        //{
        //    // Set cursor below the menu
        //    Console.SetCursorPosition(1, 9);

        //    // Clear Row
        //    Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        //}
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
                Console.WriteLine("The Menu");
                Console.WriteLine("---------------------");
                Console.WriteLine("  Select an option   ");
                Console.WriteLine("---------------------");
                Console.WriteLine("F: Register a customer");
                Console.WriteLine("W: Register an Animal");
                Console.WriteLine("S: Show all customers");
                Console.WriteLine("R: Show all animals");
                Console.WriteLine("E: Exit Program");
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("");

            }
        }
    }
}
