using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto07
{
    [Xamarin.Forms.Xaml.XamlCompilation( Xamarin.Forms.Xaml.XamlCompilationOptions.Compile )]
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Projeto07.MainPage();
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
