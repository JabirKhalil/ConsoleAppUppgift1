using Autofac;
using ConsoleAppUppgift1.TheAnimal;
using ConsoleAppUppgift1.TheCustomer;
using ConsoleAppUppgift1.TheMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUppgift1
{
    public static class AfConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<DrawMenu>().As<IDrawMenu>();

            builder.RegisterType<Customer>();
            builder.RegisterType<Animal>();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("TheCustomer"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("TheAnimal"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
               .Where(i => i.Namespace.Contains("TheExtraService"))
               .As(i => i.GetInterfaces()
               .FirstOrDefault(n => n.Name == "I" + i.Name))
               .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
