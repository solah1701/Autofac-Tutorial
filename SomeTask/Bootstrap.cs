using Autofac;
using SomeTask.Modules;
using log4net;

namespace SomeTask
{
    public static class Bootstrap
    {
        private static IContainer Container { get; set; }

        public static void Init()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<TaskManager>().As<ITaskManager>();
            builder.RegisterModule(new LoggingModule());
            Container = builder.Build();
        }

        public static ILog GetLogger()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                return scope.Resolve<ILog>();
            }
        }

        public static ITaskManager GetTaskManager()
        {
            using (var scope = Container.BeginLifetimeScope()) return scope.Resolve<ITaskManager>();
        }
    }
}
