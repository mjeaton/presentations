using Ninject.Modules;
using Presenter.ViewModels;

namespace Presenter.Modules
{
    public class ViewModelModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMainWindow>().To<MainWindowViewModel>();
            Bind<IHomeViewModel>().To<HomeViewModel>();
            Bind<ILayoutViewModel>().To<LayoutViewModel>();
        }
    }
}