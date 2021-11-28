using ConsoleAppUppgift1.TheExtraService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUppgift1.TheAnimal
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }
        public List<IClawCutting> ClawCutting { get; set; }
        public List<IWash> Wash { get; set; }

        public delegate Animal Factory(string name);



        public Animal()
        {

        }
        public Animal(string name)
        {
            Name = name;
        }
    }
}
