using Sinteg.Mobile.Service;
using Sinteg.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Sinteg.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            IUsuarioServiceApi usuarioServiceApi = DependencyService.Get<IUsuarioServiceApi>();

            MainPage = new NavigationPage( new LoginPage( usuarioServiceApi ) );
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
