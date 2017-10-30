using Projeto03.Models;
using Projeto03.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto03.Views
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class PessoaListPage : ContentPage
    {
        public PessoaListPage()
        {
            InitializeComponent();

            BindingContext = new PessoaViewModel();
        }

        public void ListView_Tapped( object sender , ItemTappedEventArgs e )
        {
            Pessoa pessoa = e.Item as Pessoa;

            Navigation.PushAsync( new PessoaDetailsPage( pessoa ) );
        }
    }
}