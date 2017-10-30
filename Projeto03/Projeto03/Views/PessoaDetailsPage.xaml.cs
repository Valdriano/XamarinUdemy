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
    public partial class PessoaDetailsPage : ContentPage
    {
        public PessoaDetailsPage( Pessoa pessoa )
        {
            InitializeComponent();

            BindingContext = new PessoaDetailViewModel( pessoa );
        }
    }
}