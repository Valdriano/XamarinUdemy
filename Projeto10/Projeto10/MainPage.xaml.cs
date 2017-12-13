using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAlertaSimples_Clicked( object sender , EventArgs e )
        {
            DisplayAlert( "Alerta" , "Alerta Simples" , "OK" );
        }

        private void btnAlertaComposto_Clicked( object sender , EventArgs e )
        {
            DisplayAlert( "Alerta" , "Alerta Composto" , "OK" , "Cancelar" );
        }

        private async void btnQuestionar_Clicked( object sender , EventArgs e )
        {
            bool valor = await DisplayAlert( "Questionar" , "Deseja sair?" , "Sim" , "Não" );

            if( valor )
            {
                //faze algo
            }
        }

        private async void btnAction_Clicked( object sender , EventArgs e )
        {
            string result = await DisplayActionSheet( "Selecione" , "Cancelar" , "Fechar" , "C#" , "ASP.NET" , "Xamarin" );

            this.lblResultado.Text = result;
        }
    }
}
