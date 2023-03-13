using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace EX01_Pokemon.View.Converters
{
    public class TypeToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                return new BitmapImage(new Uri("https://img.pngio.com/pokeball-clipart-logo-pokemon-pokemon-ball-logo-png-pokeball-icon-png-920_963.png")) ;
            }

            string type = value.ToString().ToLower();

            return new BitmapImage(new Uri($"pack://application:,,,/Resources/Icons/{type}.png", UriKind.Absolute));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
