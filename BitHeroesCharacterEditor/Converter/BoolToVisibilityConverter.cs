using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace BitHeroesCharacterEditor.Converter
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public sealed class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var reverse = parameter?.ToString() == "Negate";

            if (value is bool b) return reverse ? (b ? Visibility.Collapsed : Visibility.Visible) : (b ? Visibility.Visible : Visibility.Collapsed);

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var reverse = parameter?.ToString() == "Negate";

            if (Equals(value, Visibility.Visible))
                return !reverse;
            if (Equals(value, Visibility.Collapsed))
                return reverse;

            return null;
        }
    }
}