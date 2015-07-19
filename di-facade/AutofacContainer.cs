using System.Reflection;
using Autofac;

namespace di_facade
{
    public static class AutofacContainer
    {
        public static IContainer Container { get; private set; }

        static AutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsSelf().AsImplementedInterfaces();

            Container = builder.Build();
        }

        public static T Resolve<T>()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                return scope.Resolve<T>();
            }
        }
    }
}
