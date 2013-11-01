using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace WpfApplication1
{
    public class PriorityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var x = (string)value;
            if (x == parameter.ToString().ToLower())
                return true;
            else
                return false;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }
    }
}
