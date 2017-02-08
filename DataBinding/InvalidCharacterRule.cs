using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace DataBinding
{
    public class InvalidCharacterRule :ValidationRule
    {
        public InvalidCharacterRule()
        {
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = (string)value;

            try
            {
                foreach (char c in str)
                {
                    if (!char.IsDigit(c))
                        return new ValidationResult(false, "Characters is not a number");
                }
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Illegal characters or " + e.Message);
            }

            return new ValidationResult(true, null);
        }

    }
}
