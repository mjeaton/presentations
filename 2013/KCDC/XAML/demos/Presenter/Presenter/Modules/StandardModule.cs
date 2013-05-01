using System;
using System.Linq;
using Caliburn.Micro;
using Ninject.Modules;

namespace Presenter.Modules
{
    public class StandardModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<IWindowManager>().To<WindowManager>();
            Bind<IEventAggregator>().To<EventAggregator>();
        }
    }
}
