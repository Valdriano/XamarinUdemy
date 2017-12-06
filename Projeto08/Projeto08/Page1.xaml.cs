using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto08
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnModal_Clicked( object sender , EventArgs e )
        {
            Navigation.PushModalAsync( new Page1() );
        }

        private void btnPush_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new Page1() );
        }

        private void btnFechaModal_Clicked( object sender , EventArgs e )
        {
            Navigation.PopModalAsync();
        }

        private void btnFechaPush_Clicked( object sender , EventArgs e )
        {
            Navigation.PopAsync();
        }
    }
}