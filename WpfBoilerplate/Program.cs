using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using WpfBoilerplate.View;

namespace WpfBoilerplate
{
    class Program
    {
        [STAThread]
        public static int Main(string[] args)
        {
            var ioc = IoC.Register();
            using (var scope = ioc.BeginLifetimeScope())
            {
                App app = scope.Resolve<App>();
                // Setup your application as you want before running it
                return app.Run(scope.Resolve<MainWindow>());
            }
        }
    }
}
