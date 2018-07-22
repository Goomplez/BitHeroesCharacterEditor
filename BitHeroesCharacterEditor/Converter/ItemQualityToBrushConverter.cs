using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using BitHeroesCharacterEditor.Model;

namespace BitHeroesCharacterEditor.Converter
{
    [ValueConversion(typeof(ItemQuality), typeof(SolidColorBrush))]
    public sealed class ItemQualityToBrushConverter : MarkupExtension, IValueConverter
    {
        private static readonly ItemQualityToBrushConverter Converter = new ItemQualityToBrushConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ItemQuality i)
                switch (i)
                {
                    case ItemQuality.Common:
                        return new SolidColorBrush(Color.FromRgb(254, 254, 254));
                    case ItemQuality.Uncommon:
                        return new SolidColorBrush(Color.FromRgb(150, 254, 124));
                    case ItemQuality.Rare:
                        return new SolidColorBrush(Color.FromRgb(146, 157, 243)); 
                    case ItemQuality.Epic:
                        return new SolidColorBrush(Color.FromRgb(254, 127, 124));
                    case ItemQuality.Legendary:
                        return new SolidColorBrush(Color.FromRgb(254, 254, 0));
                    case ItemQuality.Set:
                        return new SolidColorBrush(Color.FromRgb(0, 254, 251));
                    case ItemQuality.Mythic:
                        return new SolidColorBrush(Color.FromRgb(254, 0, 71));
                    default:
                        return null;
                }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Converter;
        }
    }
}