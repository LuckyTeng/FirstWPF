using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace DataBinding
{
    [ValueConversion(typeof(DateTime), typeof(String))]
    public class DoubleToString :IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double) value).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double d;

            if (double.TryParse(value.ToString(), out d))
                return d;
            return double.NaN;
        }
    }
}
