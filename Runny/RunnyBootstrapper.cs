using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runny
{
    using System.Windows;
    using Caliburn.Micro;
    using Runny.ViewModels;

    class RunnyBootstrapper : BootstrapperBase
    {
        public RunnyBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainWindowViewModel>();
        }
    }
}
