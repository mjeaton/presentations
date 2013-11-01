using System;
using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using Ninject;
using Presenter.Modules;

namespace Presenter
{
    public class Bootstrapper : Bootstrapper<IMainWindow> 
    {

        private IKernel _kernel;
        protected override void Configure()
        {
            _kernel = new StandardKernel(new StandardModule(), new ViewModelModule());
        }

        protected override object GetInstance(Type service, string key)
        {
            return _kernel.Get(service);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _kernel.GetAll(service);
        }

        protected override void BuildUp(object instance)
        {
            _kernel.Inject(instance);
        }
    }
}
