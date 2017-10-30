using Sinteg.Mobile.Service;
using Sinteg.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sinteg.Mobile.Views
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class LoginPage : ContentPage
    {
        public LoginPage( IUsuarioServiceApi usuarioServiceApi )
        {
            InitializeComponent();

            BindingContext = new UsuarioViewModel( usuarioServiceApi );
        }
    }
}