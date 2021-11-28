using ConsoleAppUppgift1.OutputMethods;
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

            OutAndInputBuilder.ToConsole1("Animal name:");
            var name = OutAndInputBuilder.FromConsole();


            animalList.Add(AnimalFactory(name));

            OutAndInputBuilder.ToConsole1("The animal "+name + " has registered");
        }

        public void AnimalNames()
        {
            int i = 0;
            OutAndInputBuilder.ToConsole("The list of customers");
            OutAndInputBuilder.ToConsole("--------------------");
            foreach(var animal in animalList)
            {
                i++;
                OutAndInputBuilder.ToConsole(i + " -Animal's name: " + animal.Name);
                OutAndInputBuilder.ToConsole("");
            }
        }
    }
}
