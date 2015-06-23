using Caliburn.Micro;
using MarkdownSharp;
using System.IO;
using System.Reflection;

namespace Presenter.ViewModels
{
    public class HomeViewModel : Screen, IHomeViewModel
    {
        private string _markdown = "Home.md";
        public HomeViewModel()
        {
            DisplayName = "A Ground-Up Introduction to XAML ";
        }

        private string readFile(string fileName)
        {
            string returnVal = string.Empty;

            if (!string.IsNullOrEmpty(fileName))
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Presenter.Content." + fileName))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        returnVal = reader.ReadToEnd();
                    }
                }
            }
            return returnVal;
        }

        private string _introText;
        public string IntroText
        {
            get
            {
                var md = new Markdown();
                _introText = md.Transform(readFile(_markdown));
                return _introText;
            }
            set
            {
                _introText = value;
                NotifyOfPropertyChange(() => IntroText);
            }
        }

        public string IntroText2
        {
            get
            {

                return string.Empty;
                /*
                var sb = new StringBuilder();
                sb.AppendLine("You're a developer with years of experience creating amazing web or WinForms applications, but you've just been assigned to a *gasp* WPF or Silverlight (or WP7) project! Because you're an expert developer, you're expected to love this new technology and be productive from day 1. You click File | New | WPF (or Silverlight) project and feel completely lost as you open the XAML files. Not only that, but you have to contend with new patterns like MVVM! Trust me, it's not as bad as it appears and XAML is NOT as hard as you think. This hands-on workshop will cover the things you need to know to be successful on your first XAML-based project.");
                sb.AppendLine("Attendees can expect an all-day dive into the following XAML concepts:");
                sb.AppendLine("Overview of XAML");
                sb.AppendLine("Layouts");
                sb.AppendLine("Controls");
                sb.AppendLine("Databinding");
                sb.AppendLine("Styling");
                sb.AppendLine("Templating");
                sb.AppendLine("Patterns such as MVVM");
                sb.AppendLine("And More");
                sb.AppendLine("There will be a lot to cover in 8 hours and the day will get progressively more advanced as we move through more topics.");
                return sb.ToString();
                */
            }
        }
    }
}
