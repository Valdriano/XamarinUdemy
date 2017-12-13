using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Clicked( object sender , EventArgs e )
        {
            if( string.IsNullOrWhiteSpace( this.txtCEP.Text ) || this.txtCEP.Text.Length != 8 )
            {
                await DisplayAlert( "Aviso" , "CEP invalido" , "OK" );
            }
            else
            {
                CEP cep = await ServiceCEP.GetCEP( this.txtCEP.Text );

                if( cep != null )
                {
                    this.lblBairro.Text = $"Bairro: {cep.bairro}";
                    this.lblCEP.Text = $"CEP: {cep.cep}";
                    this.lblCidade.Text = $"Cidade: {cep.localidade}";
                    this.lblComplemento.Text = $"Complemento: {cep.complemento}";
                    this.lblRua.Text = $"Rua: {cep.logradouro}" ;
                    this.lblUF.Text = $"UF: {cep.uf}";
                }
                else
                {
                    this.lblBairro.Text = string.Empty;
                    this.lblCEP.Text = string.Empty;
                    this.lblCidade.Text = string.Empty;
                    this.lblComplemento.Text = string.Empty;
                    this.lblRua.Text = string.Empty;
                    this.lblUF.Text = string.Empty;
                }
            }
        }
    }
}
