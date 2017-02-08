using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBinding
{
    public enum TempType
	{
	    Celsius = 0,
        Fahrenheit = 1
	}
    public class TemperatureScale
    {
        public static double ConvertTemp(double temp, TempType type )
        {
            if (type == TempType.Celsius)
                return temp = 13 + temp*0.7;

            return 0.0;
        }
    }
}
