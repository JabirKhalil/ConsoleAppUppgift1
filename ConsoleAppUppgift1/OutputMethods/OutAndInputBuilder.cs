using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUppgift1.OutputMethods
{
   public class OutAndInputBuilder 
    {
        public static string FromConsole()
        {
            return Console.ReadLine();
        }

        public static void ToConsole(string message)
        {
            Console.WriteLine(message);
        }

        public static void ToConsole1(string message)
        {
            Console.Write(message);
        }
    }
}
