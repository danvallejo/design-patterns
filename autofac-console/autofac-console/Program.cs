using System.Reflection;
using Autofac;

namespace autofac_console
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<ConsoleOutput>().As<IOutput>();
            //builder.RegisterType<TodayWriter>().As<IDateWriter>();
            //builder.RegisterType<DateWriter>();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsSelf().AsImplementedInterfaces();
            
            Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var dateWriter = new DateWriter(scope.Resolve<IDateWriter>());
                dateWriter.Write();
            }

            using (var scope = Container.BeginLifetimeScope())
            {
                var dateWriter = scope.Resolve<DateWriter>();
                dateWriter.Write();
            }

        }
    }
}
