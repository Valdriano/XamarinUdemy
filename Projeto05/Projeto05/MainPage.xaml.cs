using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto05
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnStackLayout_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new StackLayoutPage() );
        }

        private void btnAbsoluteLayout_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new AbsoluteLayoutPage() );
        }

        private void btnGridLayout_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new GridLayoutPage() );
        }

        private void btnRelativeLayout_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new RelativeLayoutPage() );
        }

        private void btnScrollView_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new ScrollViewPage() );
        }
    }
}
