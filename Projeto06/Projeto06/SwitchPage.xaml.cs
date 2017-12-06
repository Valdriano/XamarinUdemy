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
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        private void sthConectado_Toggled( object sender , ToggledEventArgs e )
        {
            if( this.sthConectado.IsToggled )
            {
                this.boxViewConectado.Color = Color.Green;
            }
            else
            {
                this.boxViewConectado.Color = Color.Blue;
            }
        }
    }
}