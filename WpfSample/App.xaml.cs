using PackUriSample.Module;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using WpfSample.Views;

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        /// <summary>
        /// PackUriSample.Module 추가
        /// </summary>
        /// <param name="moduleCatalog"></param>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            _ = moduleCatalog.AddModule<PackUriSampleModule>();
        }
    }
}
