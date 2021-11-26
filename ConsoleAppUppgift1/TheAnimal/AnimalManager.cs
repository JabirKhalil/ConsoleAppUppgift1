using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUppgift1.TheAnimal
{
    public class AnimalManager : IAnimalManager
    {
        private Animal.Factory AnimalFactory;

        public List<IAnimal> animalList { get; set; }

        public AnimalManager(Animal.Factory animalFactory)
        {
            AnimalFactory = animalFactory;
            animalList = new();
        }
        public void AddAnimal()
        {
            Console.Write("Animal name:");
            var name = Console.ReadLine();
          
            animalList.Add(AnimalFactory(name));
        }

        public void AnimalNames()
        {
            int i = 0;
            Console.WriteLine("The list of customers");
            Console.WriteLine("--------------------");
            foreach(var animal in animalList)
            {
                i++;
                Console.WriteLine(i + " -Animal's name: " + animal.Name);
                Console.WriteLine("");
            }
        }
    }
}
