using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto08
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnNavigationPage_Clicked( object sender , EventArgs e )
        {
            Application.Current.MainPage = new NavigationPage( new Page1() );
        }

        private void btnTabberPage_Clicked( object sender , EventArgs e )
        {
            Application.Current.MainPage = new Page2();
        }

        private void btnCarouselPage_Clicked( object sender , EventArgs e )
        {
            Application.Current.MainPage = new Page3();
        }

        private void btnMasterPage_Clicked( object sender , EventArgs e )
        {
            Application.Current.MainPage = new Page4();
        }
    }
}
