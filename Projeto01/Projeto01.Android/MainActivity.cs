using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Projeto01.Droid
{
    [Activity( Label = "Projeto01" , Icon = "@drawable/icon" , Theme = "@style/MainTheme" , MainLauncher = true , ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private EditText editTextValor1, editTextValor2;
        private TextView textViewResultado;
        private Button buttonSomar;
        protected override void OnCreate( Bundle bundle )
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate( bundle );

            //global::Xamarin.Forms.Forms.Init( this , bundle );
            //LoadApplication( new App() );

            SetContentView( Resource.Layout.layout1 );


            editTextValor1 = FindViewById<EditText>( Resource.Id.txtValor1 );
            editTextValor2 = FindViewById<EditText>( Resource.Id.txtValor2 );
            buttonSomar = FindViewById<Button>( Resource.Id.btnSomar );
            textViewResultado = FindViewById<TextView>( Resource.Id.txtResultado );

            buttonSomar.Click += delegate
            {
                decimal vlr1 = Convert.ToDecimal( editTextValor1.Text );
                decimal vlr2 = Convert.ToDecimal( editTextValor2.Text );

                textViewResultado.Text = $"O resultado é: {MyClass.Somar( vlr1 , vlr2 ).ToString( "N2" )}";
            };
        }
    }
}

