using Autofac;
using WpfBoilerplate.Factory;
using WpfBoilerplate.Service;
using WpfBoilerplate.View;

namespace WpfBoilerplate
{
    public static class IoC
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainViewModelFactory>().As<IMainViewModelFactory>();
            builder.RegisterType<DataService>().As<IDataService>();            
            builder.RegisterType<MainWindow>();
            builder.RegisterType<App>();
            return builder.Build();
        }
    }
}
