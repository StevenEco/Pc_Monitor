using Pc_Monitor.Wpf.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;

namespace Pc_Monitor.Wpf;
public class Bootstrapper : PrismBootstrapper
{
    protected override DependencyObject CreateShell()
    {
        return Container.Resolve<RootView>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {

    }
}