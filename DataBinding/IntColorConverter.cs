using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace DataBinding
{
    [ValueConversion(typeof(Double), typeof(String))]
    public class IntColorConverter :IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int v = (int)(Double)value;

            if (v >= 0 && v <= 300)
                return "CadetBlue";
            else if (v > 200)
                return "BurlyWood";

            return "Blue";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
