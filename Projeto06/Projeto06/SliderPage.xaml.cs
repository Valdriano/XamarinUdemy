using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto06
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class SliderPage : ContentPage
    {
        public SliderPage()
        {
            InitializeComponent();
        }

        private void Slider1_ValueChanged( object sender , ValueChangedEventArgs e )
        {
            this.Label1.Text = Convert.ToString( this.Slider1.Value );
        }
    }
}