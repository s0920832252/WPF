using System;
using System.Globalization;
using System.Windows.Data;

namespace Trying_Handy_Org_Custom_Controls.Converter
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class BoolToNegativeBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && !(bool) value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
