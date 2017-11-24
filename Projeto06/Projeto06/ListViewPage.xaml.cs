using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto06
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class ListViewPage : ContentPage
    {
        public List<Pessoa> Pessoas { get; set; }
        public ListViewPage()
        {
            InitializeComponent();

            Pessoas = new List<Pessoa>(
                new Pessoa[]
                {
                    new Pessoa{Nome="Valdriano", Sobrenome="Oliveira"},
                    new Pessoa{Nome="Iracema", Sobrenome="Soares"}
                }
                );

            BindingContext = new object[] { Pessoas };
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}