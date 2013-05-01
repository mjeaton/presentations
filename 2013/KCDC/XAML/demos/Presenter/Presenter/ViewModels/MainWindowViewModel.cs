using System;
using System.Linq;
using Caliburn.Micro;

namespace Presenter.ViewModels
{
    public class MainWindowViewModel : Conductor<Screen>, IMainWindow
    {
        public MainWindowViewModel()
        {
            DisplayName = "Intro to XAML";
            Home();
        }

        public void Home()
        {
            ActivateItem(new HomeViewModel());
        }

        public void Overview()
        {
            ActivateItem(new OverviewViewModel());
        }

        public bool CanOverview
        {
            get { return true; }	
        }

        public void Layout()
        {
            ActivateItem(new LayoutViewModel());
        }

        public void Controls()
        {
            ActivateItem(new ControlsViewModel());
        }
    }
}
