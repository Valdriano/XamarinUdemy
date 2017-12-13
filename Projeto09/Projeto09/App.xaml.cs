using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto09
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Projeto09.MainPage();
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

        private ResourceDictionary GetResourceDictionary()
        {
            ResourceDictionary resource = new ResourceDictionary();

            Style styleLabel = new Style( typeof( Label ) );
            Setter setterLabel = new Setter();
            setterLabel.Property = Label.FontFamilyProperty;

            return resource;
        }
    }
}
