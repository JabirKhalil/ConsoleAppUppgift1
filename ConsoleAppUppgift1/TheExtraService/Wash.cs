using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUppgift1.TheExtraService
{
    public class Wash :IWash
    {
        public string ServiceName { get ; set ; }
        public decimal Price { get; set; }
    }
}
