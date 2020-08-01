using Autofac;
using System;

namespace _26BeautySalon
{
    class Program26
    {
        private static ICustomerService CustomerService { get; set; }

        private static IContainer Container { get; set; }

        public Program26(ICustomerService customerService)
        {
            CustomerService = customerService;
        }

        static void Main(string[] args)
        {
            RegisterContainer();
            Container.Resolve<ICustomerService>().CreateCustomer(CustomerStatus.Brown, "ADAM");
            
            Console.WriteLine();
        }

        static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<JsonDataSource>().As<IDataSource>();
            builder.RegisterType<CustomerService>().AsImplementedInterfaces().SingleInstance();
            Container = builder.Build();
        }
    }
}
