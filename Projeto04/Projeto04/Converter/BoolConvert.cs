using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto04.Converter
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public class BoolConvert : IValueConverter
    {
        public object Convert( object value , Type targetType , object parameter , CultureInfo culture )
        {
            bool valor = ( bool ) value;

            if( valor )
                return "Finalizado.png";
            else
                return "Aberto.png";
        }

        public object ConvertBack( object value , Type targetType , object parameter , CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}
