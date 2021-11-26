using ConsoleAppUppgift1.TheCustomer;
using ConsoleAppUppgift1.TheMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUppgift1
{
    public class Application : IApplication
    {
        private IDrawMenu DrawMenu { get; set; }
        public Application (IDrawMenu drawMenu)
            {
                DrawMenu = drawMenu;
            }
        public void Run()
        {


            DrawMenu.Menu();

        }






    }
}
