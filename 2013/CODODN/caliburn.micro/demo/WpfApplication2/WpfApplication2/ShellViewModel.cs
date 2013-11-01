namespace WpfApplication2 {
    using System.ComponentModel.Composition;
    using System;

    [Export(typeof(IShell))]
    public class ShellViewModel : IShell 
    {
        public void OkButton()
        {
            Console.WriteLine("here");

        } 
    }
}
