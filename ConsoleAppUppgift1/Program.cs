using Autofac;
using System;

namespace ConsoleAppUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AfConfig.Configure();

      
            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();
            app.Run();
        }
    }
}
