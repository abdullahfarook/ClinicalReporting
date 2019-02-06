using System;
using System.Globalization;
using System.Windows.Data;

namespace ClinicalReporting.Common
{
    public class GenderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string) parameter == (string) value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool) value ? parameter : null;
        }
    }
}